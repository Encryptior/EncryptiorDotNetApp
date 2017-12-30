using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using Nethereum.Hex.HexConvertors.Extensions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System.Security.Cryptography;

namespace Encryptior
{
    public partial class LockFolder : Form
    {
        private string outFilePath;
        Dictionary<string, string> FilesToEncrypt = new Dictionary<string, string>();


        public LockFolder()
        {
            InitializeComponent();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            double cost;
            if (double.TryParse(textBoxCost.Text, out cost))
            {
                try
                {
                    saveFileDialog.FileName = Path.GetFileName(textBoxProjectName.Text) + ".encrypted.zip";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string outFilePath = saveFileDialog.FileName;
                        string password = System.Web.Security.Membership.GeneratePassword(32, 0);
                        foreach (ListViewItem item in listViewFiles.Items)
                        {
                            FilesToEncrypt.Add(item.Name, item.Text);
                        }
                        bool state = false;
                        listViewFiles.Enabled = state;
                        buttonDelete.Enabled = state;
                        buttonOpenFiles.Enabled = state;
                        textBoxCost.Enabled = state;
                        textBoxProjectName.Enabled = state;
                        buttonLock.Enabled = state;

                        backgroundCompressor.RunWorkerAsync(new string[] {
                        outFilePath,
                        password,
                        cost.ToString()
                        });
                        pictureBoxLoading.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBoxCost.ForeColor = Color.Red;
            }
        }

        #region Checksum
        public static string GetChecksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }
        #endregion

        #region Compression
        private void ProgressCallback(object sender, ProgressEventArgs args)
        {
            backgroundCompressor.ReportProgress(Convert.ToInt32(args.PercentComplete), args.Name);
        }

        private void ProcessFileCallback(object sender, ScanEventArgs args)
        {
            backgroundCompressor.ReportProgress(0, "Encrypting file: " + args.Name);
        }

        private void backgroundCompressor_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] args = (string[])e.Argument;
            outFilePath = args[0];
            string password = args[1];
            string cost = args[2];

            FileStream fsOut = File.Create(outFilePath);
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);
            zipStream.SetLevel(3);
            zipStream.Password = password;
            foreach(var item in FilesToEncrypt)
            {
                FileInfo fi = new FileInfo(item.Key);
                string entryName = item.Value;
                ZipEntry newEntry = new ZipEntry(entryName);
                newEntry.DateTime = fi.LastWriteTime;
                newEntry.AESKeySize = 256;
                newEntry.Size = fi.Length;
                zipStream.PutNextEntry(newEntry);
                byte[] buffer = new byte[4096];
                using (FileStream streamReader = File.OpenRead(item.Key))
                {
                    StreamUtils.Copy(streamReader, zipStream, buffer, ProgressCallback, new TimeSpan(0,0,0,0,100), null, item.Key);
                }
                backgroundCompressor.ReportProgress(100, item.Key);

                zipStream.CloseEntry();
                if (backgroundCompressor.CancellationPending) //in case someone closes the window
                {
                    zipStream.Close();
                    fsOut.Close();
                    File.Delete(outFilePath);
                    backgroundCompressor.Dispose();
                    return;
                }
            }
            zipStream.IsStreamOwner = true; // Makes the Close also Close the underlying stream
            zipStream.Close();
            fsOut.Close();
            backgroundCompressor.ReportProgress(100, "Generating Hash...");
            string fileHash = GetChecksum(outFilePath);
            backgroundCompressor.ReportProgress(100, "Contacting server...");

            /*        FastZipEvents events = new FastZipEvents();
                    events.Progress = ProgressCallback;
                    events.ProcessFile = ProcessFileCallback;
                    FastZip fastZip = new FastZip(events);
                    fastZip.CreateEmptyDirectories = true;
                    fastZip.Password = password;
                    fastZip.CreateZip(outFilePath, inFilePath, true, "");
                    backgroundCompressor.ReportProgress(100, "Generating Hash...");
                    string fileHash = GetChecksum(outFilePath);
                    backgroundCompressor.ReportProgress(100, "Contacting server...");*/


            var newFile = new Models.File
            {
                CostUSD = Convert.ToDouble(cost),
                FileHash = fileHash,
                Owner = Program.ActiveAddress,
                Password = password
            };
            Program.apiWorker.NewFile(newFile);
        }

        private void backgroundCompressor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                string status = (string)e.UserState;
                if (e.ProgressPercentage < 100)
                {
                    listViewFiles.Items[status].SubItems[3].Text = "Encrypting, " + e.ProgressPercentage.ToString() + "%";
                }
                else
                {
                    listViewFiles.Items[status].SubItems[3].Text = "Encrypted. 100%";
                }
            }
            catch
            {
                //dialog closed, garbage...
            }
        }

        private void backgroundCompressor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pictureBoxLoading.Visible = false;
                // Process.Start(outFilePath);
                DecrypterPage form = new DecrypterPage(outFilePath);
                form.Show();
                bool state = true;
                listViewFiles.Enabled = state;
                buttonDelete.Enabled = state;
                buttonOpenFiles.Enabled = state;
                textBoxCost.Enabled = state;
                textBoxProjectName.Enabled = state;
                buttonLock.Enabled = state;
            }
            catch //exception, someone closed
            {
                //do nothing, file deleted, process is garbage
            }
        }
        #endregion

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {
            textBoxCost.ForeColor = Color.Black;
        }


        private string ReadableFileSize(long len)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (listViewFiles.SelectedItems.Count > 0)
            {
                listViewFiles.Items.Remove(listViewFiles.SelectedItems[0]);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.ShowDialog();
            listViewFiles.BeginUpdate();
            foreach (var fileName in dialog.FileNames)
            {
                Icon iconForFile = SystemIcons.WinLogo;

                FileInfo file = new FileInfo(fileName);
                ListViewItem item = new ListViewItem(file.Name, 1);
                item.Name = fileName;
                if (!imageList1.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                    imageList1.Images.Add(file.Extension, iconForFile);
                }
                item.SubItems.Add(file.LastAccessTime.ToString());
                item.SubItems.Add(ReadableFileSize(file.Length));
                item.SubItems.Add("Unencrypted");
                item.ImageKey = file.Extension;
                listViewFiles.Items.Add(item);

            }
            listViewFiles.EndUpdate();
        }

        private void listViewFiles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewFiles.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

  
        private void delete_Click(object sender, EventArgs e)
        {
            while (listViewFiles.SelectedItems.Count > 0)
            {
                listViewFiles.Items.Remove(listViewFiles.SelectedItems[0]);
            }
        }

        private void listViewFiles_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(listViewFiles.SelectedItems[0].Name);
        }

        private void LockFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundCompressor.CancelAsync();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxSingleUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSingleUser.Checked)
            {
                checkBoxSingleUser.Text = "Single User Buy:";
                textBoxSingleUser.Visible = true;
            }
            else
            {
                checkBoxSingleUser.Text = "Single User Buy";
                textBoxSingleUser.Visible = false;
            }
        }
    }
}
