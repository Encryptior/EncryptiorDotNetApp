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
using System.Threading;

namespace Encryptior
{
    public partial class EncryptiorMainPage : Form
    {
        public static string[] Wallets;
        List<string> listPublicFiles = new List<string>();
        private Models.CurrentVersion activeVersion;

        public EncryptiorMainPage()
        {
            InitializeComponent();
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            labelVersion.Text = "Version: " + version;
            try
            {
                activeVersion = Program.apiWorker.GetAppVersion();
                if (activeVersion.Version != version)
                {
                    linkNewVersionInstall.Visible = true;
                    linkNewVersionInstall.Text = "Version " + activeVersion.Version + " available. Click to Download.";
                }
            }
            catch { }
        }

        private void EncryptiorMainPage_Load(object sender, EventArgs e)
        {
            if (!unlockDefaultWallet())
                this.Close();
        }

        bool unlockDefaultWallet()
        {
            try
            {
                string fileName = Properties.Settings.Default.DefaultAccount;
                string json = File.ReadAllText(fileName);
                Nethereum.KeyStore.KeyStoreService KeyStore = new Nethereum.KeyStore.KeyStoreService();
                string address = KeyStore.GetAddressFromKeyStore(json);
                using (PasswordForm credentials = new PasswordForm(fileName, address))
                {
                    var result = credentials.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Program.PrivateKey = credentials.PrivateKey;
                        Program.ActiveAddress = address;
                        linkLabelEthAddr.Text = Program.ActiveAddress;
                        pictureBoxIdenticon.Image = Properties.Resources._25;
                        logAndReadBalance.RunWorkerAsync();
                        Identicon identicon = new Identicon(linkLabelEthAddr.Text, 8);
                        return true;
                    }
                    else 
                    {
                        MessageBox.Show("Bad Password", "Password Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch
            {
                using (ChooseWallet makeChoose = new ChooseWallet())
                {
                    makeChoose.ShowDialog();
                    if (makeChoose.DialogResult == DialogResult.OK)
                    {
                        linkLabelEthAddr.Text = Program.ActiveAddress;
                        pictureBoxIdenticon.Image = Properties.Resources._25;
                        logAndReadBalance.RunWorkerAsync();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("You need to unlock an active account to use this application", "Application error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }



        #region ApiAuthenticator
        private void logAndReadBalance_DoWork(object sender, DoWorkEventArgs e)
        {
            logAndReadBalance.ReportProgress(1, "Authenticating...");
            bool authenticated = Program.apiWorker.Authenticate(Program.PrivateKey);
            logAndReadBalance.ReportProgress(2, "Reading Account Balance...");
            if (authenticated)
            {
                var balance = Program.apiWorker.GetBalance();
                e.Result = balance;
            }
        }

        private void logAndReadBalance_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //labelConnInfo.Text = (string)e.UserState;
        }

        private void logAndReadBalance_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Models.Balance balance = (Models.Balance)e.Result;
            if (balance != null)
            {
                string balanceeth = balance.BalanceETH.ToString("0.0000");
                string balanceusd = balance.BalanceUSD.ToString("0.00");
                labelUsd.Text = balance.BalanceETH.ToString("0.0000") + "eth  " + balance.BalanceUSD.ToString("0.00") + "$";
            }
            Identicon identicon = new Identicon(Program.ActiveAddress, 8);
            pictureBoxIdenticon.Image = identicon.GetBitmap(32);
        }
        #endregion




        private void buttonOpenEncrypted_Click(object sender, EventArgs e)
        {
            try
            {
                if (openZipDialog.ShowDialog() == DialogResult.OK)
                {
                    Form decrypter = new DecrypterPage(openZipDialog.FileName);
                    decrypter.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonWorkingFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = Properties.Settings.Default.Workspace;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Workspace = folderBrowserDialog.SelectedPath + "/";
                Properties.Settings.Default.Save();
                string LibraryFile = Properties.Settings.Default.Workspace + "Library.json";
                string PublicFolder = Properties.Settings.Default.Workspace + "Public Data";
                string PrivateFolder = Properties.Settings.Default.Workspace + "Private Data";
                if (!File.Exists(LibraryFile))
                {
                    File.Create(LibraryFile);
                }
                if (!Directory.Exists(PublicFolder))
                {
                    Directory.CreateDirectory(PublicFolder);
                }
                if (!Directory.Exists(PrivateFolder))
                {
                    Directory.CreateDirectory(PrivateFolder);
                }
                refreshWorkspace();
            }
        }

        private void refreshWorkspace()
        {
            string LibraryFile = Properties.Settings.Default.Workspace + "Library.json";
            List<Models.ProjectData> projectData = JsonConvert.DeserializeObject<List<Models.ProjectData>>(File.ReadAllText(LibraryFile));
            foreach (var project in projectData)
            {

            }
        }
   

        private void linkLabelEthAddr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ropsten.etherscan.io/address/" + linkLabelEthAddr.Text);
        }

        private void buttonChangeWallet_Click(object sender, EventArgs e)
        {
            using (ChooseWallet makeChoose = new ChooseWallet())
            {
                makeChoose.ShowDialog();
                if (makeChoose.DialogResult == DialogResult.OK)
                {
                    linkLabelEthAddr.Text = Program.ActiveAddress;
                    Identicon identicon = new Identicon(Program.ActiveAddress, 8);
                    pictureBoxIdenticon.Image = Properties.Resources._25;
                    logAndReadBalance.RunWorkerAsync();
                }
                else
                {
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This version is using Ropsten test network to make and confirm payments. Any indicated funds are therefore not real, and wallets made in the pre-alpha version should not be used later for real world payments.\n\nAlso, it is most likely riddled with bugs...", "Important Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (Program.ActiveAddress != null)
            {
                if (!readBalance.IsBusy)
                {
                    readBalance.RunWorkerAsync();
                }
            }
        }

        private void readBalance_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var balance = Program.apiWorker.GetBalance();
                e.Result = balance;
            }
            catch
            {
                e.Result = null;
            }
        }

        private void buttonFaucet_Click(object sender, EventArgs e)
        {
            Form faucet = new Faucet();
            faucet.ShowDialog();
        }

        private void buttonTransactions_Click(object sender, EventArgs e)
        {
            Process.Start("https://ropsten.etherscan.io/address/" + linkLabelEthAddr.Text);
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            Form payout = new Payout(labelUsd.Text);
            payout.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(Program.ActiveAddress);
            ToolTip tt = new ToolTip();
            IWin32Window win = this;
            tt.Show("Address Copied to Clipboard", win, MousePosition.X - this.Location.X + 20, MousePosition.Y - this.Location.Y, 3000);
        }

        private void buttonQR_Click(object sender, EventArgs e)
        {
            Form qr = new AddressQR("0xNopeNotForTheTestVersionAccounts");
            qr.ShowDialog();
        }

        private void buttonLockData_Click(object sender, EventArgs e)
        {
            Form locker = new LockFolder();
            locker.Show();
            /*
            try
            {
                folderBrowserDialog.Description = "Select folder to lock";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Form locker = new LockFolder(folderBrowserDialog.SelectedPath);
                    locker.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void linkNewVersionInstall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var client = new WebClient())
            {
                Process.Start(@"https://www.encryptior.com/" + activeVersion.DownloadLink);
                this.Close();
            }
        }
    }
}
