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
    public partial class DecrypterPage : Form
    {
        private string fileName;
        private string UnlockFileHash;
        private Models.File encryptedFile;
        private Models.TransactionResult transaction;
        private string unzipFolder;

        private static string GetChecksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        public DecrypterPage(string FileName)
        {
            fileName = FileName;
            InitializeComponent();
            backgroundWorkerHash.RunWorkerAsync();
        }

        private void backgroundWorkerHash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBoxLoading.Visible = false;
            if (encryptedFile == null)
            {
                this.Close();
                MessageBox.Show((string)e.Result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                flowLayoutPanel1.Visible = false;
                groupBoxFileDetails.Visible = true;
                linkLabelFilename.Text = fileName;
                labelCost.Text = encryptedFile.CostUSD.ToString() + "$";
                linkLabelOwner.Text = encryptedFile.Owner;
                Identicon icon = new Identicon(linkLabelOwner.Text, 8);
                pictureBoxIdenticonOwner.Image = icon.GetBitmap(24);
                if (encryptedFile.TransactionHash != null)
                {
                    flowLayoutPanelTStatus.Visible = true;
                    backgroundWorkerTransaction.RunWorkerAsync();
                }
                if (encryptedFile.Password != null)
                {
                    groupBoxPassword.Visible = true;
                    textBoxPass.Text = encryptedFile.Password;
                    buttonBuy.Enabled = false;
                }
            }
        }

        private void backgroundWorkerHash_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelStatus.Text = (string)e.UserState;
        }

        private void backgroundWorkerHash_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerHash.ReportProgress(0, "Generating File Checksum");
            UnlockFileHash = GetChecksum(fileName);
            backgroundWorkerHash.ReportProgress(10, "Contacting Server");
            try
            {
                encryptedFile = Program.apiWorker.CheckFile(UnlockFileHash);
                if (encryptedFile == null)
                {
                    e.Result = "File is not for sale, or it was deleted.";
                }
            }
            catch (Exception ex)
            {
                encryptedFile = null;
                e.Result = ex.Message;
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            TransactionForm trForm = new TransactionForm(UnlockFileHash, Path.GetFileName(linkLabelFilename.Text));
            trForm.ShowDialog();
            if (trForm.DialogResult != DialogResult.OK)
                return;
            try
            {
                linkLabelTransHash.Text = trForm.TransResult.TransactionHash;
                labelTxDate.Text = DateTime.FromBinary(trForm.transaction.Timestamp).ToString(CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern) + " UTC";
                linkLabelTransStatus.Font = new Font(linkLabelTransStatus.Font, FontStyle.Regular);
                linkLabelTransStatus.Text = "No Receipt";
                pictureBoxLoadingTransaction.Visible = true;
                groupBoxTransaction.Visible = true;
                timerTransactionChecker.Start();
            }
            catch
            {
                MessageBox.Show("The transaction didn't go through.\nThis can often happen if you initiated new transaction before previous was mined.\nPlease check your transaction log for confirmation.", "Transaction problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backgroundWorkerTransaction_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                transaction = Program.apiWorker.CheckTransaction(encryptedFile.TransactionHash);
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }

        private void backgroundWorkerTransaction_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            if ((string)e.Result == null)
            {
                flowLayoutPanelTStatus.Visible = false;
                groupBoxTransaction.Visible = true;
                linkLabelTransHash.Text = encryptedFile.TransactionHash;
                labelTxDate.Text = DateTime.FromBinary(transaction.Timestamp).ToString(CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern) + " UTC";
                if (encryptedFile.Password != null)
                {
                    linkLabelTransStatus.Text = "Completed";
                    groupBoxPassword.Visible = true;
                    textBoxPass.Text = encryptedFile.Password;
                    buttonBuy.Enabled = false;
                }
                else
                {
                    linkLabelTransStatus.Text = Program.apiWorker.CheckTransaction(encryptedFile.TransactionHash).Status;
                    pictureBoxLoadingTransaction.Visible = true;
                    timerTransactionChecker.Start();
                }
                linkLabelTransStatus.Text = Program.apiWorker.CheckTransaction(encryptedFile.TransactionHash).Status;
            }
            else
            {
                label3.Text = (string)e.Result;
            }
        }


        private void timerTransactionChecker_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorkerStatus.IsBusy)
                backgroundWorkerStatus.RunWorkerAsync();
        }


        private void backgroundWorkerStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                transaction = Program.apiWorker.CheckTransaction(linkLabelTransHash.Text);
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }


        private void backgroundWorkerStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((string)e.Result == null)
            {
                linkLabelTransStatus.Text = transaction.Status;
                if (transaction.Status == "Completed")
                {
                    var unlockedFile = Program.apiWorker.CheckFile(UnlockFileHash);
                    groupBoxPassword.Visible = true;
                    textBoxPass.Text = unlockedFile.Password;
                    pictureBoxLoadingTransaction.Visible = false;
                    timerTransactionChecker.Stop();
                }
                if (transaction.Status == "Transaction Failed")
                {
                    linkLabelTransStatus.Font = new Font(linkLabelTransStatus.Font, FontStyle.Bold);
                    pictureBoxLoadingTransaction.Visible = false;
                    timerTransactionChecker.Stop();
                }
                if (transaction.Status == "No Payment")
                {
                    pictureBoxLoadingTransaction.Visible = false;
                    timerTransactionChecker.Stop();
                }
            }
            else
            {

            }
        }
        private void linkLabelFilename_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabelFilename.Text);
        }

        private void linkLabelOwner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ropsten.etherscan.io/address/" + linkLabelOwner.Text);
        }

        private void linkLabelTransHash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ropsten.etherscan.io/tx/" + linkLabelTransHash.Text);
        }

        private void linkLabelTransStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (linkLabelTransStatus.Text)
            {
                case "Completed":
                    MessageBox.Show("Transaction is confirmed, and you can see the zip password", "Transaction: Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "No Receipt":
                    MessageBox.Show("We're waiting for the transaction confirmation", "Transaction: No Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Transaction Failed":
                    MessageBox.Show("Something went wrong with the transaction - you naughty little hacker!", "Transaction: Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "No Payment":
                    MessageBox.Show("You canceled the payment, or the transaction expired", "No Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void buttonUnlockFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Select foder where to save the files";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string addedFolder = Path.GetFileName(fileName).Split('.')[0];
                unzipFolder = folderBrowserDialog.SelectedPath + "/" + addedFolder;
                FastZipEvents events = new FastZipEvents();
                events.ProcessFile = ProcessFileMethod;
                events.Progress = ProgressCallback;
                FastZip fastZip = new FastZip(events);
                fastZip.CreateEmptyDirectories = true;
                fastZip.Password = textBoxPass.Text;
                flowLayoutPanelUnzip.Visible = true;
                backgroundDecompressor.RunWorkerAsync(fastZip);
            }
        }

        private void backgroundDecompressor_DoWork(object sender, DoWorkEventArgs e)
        {
            FastZip fastZip = (FastZip)e.Argument;
            fastZip.ExtractZip(fileName, unzipFolder, null);
        }

        private void ProcessFileMethod(object sender, ScanEventArgs args)
        {
            backgroundDecompressor.ReportProgress(0, args.Name);
        }

        private void ProgressCallback(object sender, ProgressEventArgs args)
        {
            backgroundDecompressor.ReportProgress(Convert.ToInt32(args.PercentComplete), args.Name);
        }


        private void backgroundDecompressor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelUnzipStatus.Text = "Unzipping file " + (string)e.UserState + " " + e.ProgressPercentage + "%";
        }

        private void backgroundDecompressor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelUnzipStatus.Text = "Finished";
            flowLayoutPanelUnzip.Visible = false;
            Process.Start(unzipFolder);
            groupBoxUnzipped.Visible = true;
        }

        private void buttonOpenFiles_Click(object sender, EventArgs e)
        {
            Process.Start(unzipFolder);
        }
    }
}
