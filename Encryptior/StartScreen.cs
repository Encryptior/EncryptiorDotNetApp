using Nethereum.Hex.HexConvertors.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptior
{
    public partial class StartScreen : Form
    {
        public string Version;
        public Models.CurrentVersion ActiveVersion;
        public Models.Balance Balance;

        string Password;
        string Json;
        bool ToggleImage = false;

        Random generator = new Random(unchecked((int)DateTime.Now.Ticks));
        class BgWorkerResult
        {
            public BgWorkerResult(string status, bool success)
            {
                Status = status;
                Success = success;
            }
            public string Status { get; set; }
            public bool Success { get; set; }
        }

        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = Properties.Settings.Default.DefaultAccount;
                Json = File.ReadAllText(fileName);
            }
            catch
            {
                using (ChooseWallet makeChoose = new ChooseWallet(false))
                {
                    makeChoose.ShowDialog();
                    if (makeChoose.DialogResult == DialogResult.OK)
                    {
                        Properties.Settings.Default.DefaultAccount = makeChoose.Filename;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("You need to unlock an account to use this application.", "Application problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Abort;
                    }
                }
            }

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Version = fvi.FileVersion;
            labelVersion.Text = "Version: " + Version;
            Identicon identicon = new Identicon(Nethereum.Signer.EthECKey.GenerateKey().GetPublicAddress(), 8);
            pictureBoxIdenticon.Image = identicon.GetBitmap(32);
            backgroundInitialiser.RunWorkerAsync();
            ToggleImage = true;
        }


        private void timerStall_Tick(object sender, EventArgs e)
        {
            if (ToggleImage)
            {
                timerStall.Interval = generator.Next(500, 1000);
                Identicon identicon = new Identicon(Nethereum.Signer.EthECKey.GenerateKey().GetPublicAddress(), 8);
                pictureBoxIdenticon.Image = identicon.GetBitmap(32);
            }
        }

        private void backgroundInitialiser_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundInitialiser.ReportProgress(0, "Choosing Wallet...");
            if (!unlockDefaultWallet())
            {
                e.Result = new BgWorkerResult("You need to unlock an account to use this application.", false);
                return;
            }

            backgroundInitialiser.ReportProgress(10, "Checking Connection...");
            if (!CheckInternetConnection()) //check connection
            {
                e.Result = new BgWorkerResult("You need an active internet connection to use this application.", false);
                return;
            }
            backgroundInitialiser.ReportProgress(20, "Checking Version...");
            try
            {
                ActiveVersion = Program.apiWorker.GetAppVersion();
            }
            catch { }

            backgroundInitialiser.ReportProgress(30, "Unlocking Wallet...");
            var keyStoreService = new Nethereum.KeyStore.KeyStoreService();
            try
            {
                Program.PrivateKey = keyStoreService.DecryptKeyStoreFromJson(Password, Json).ToHex();
            }
            catch
            {
                e.Result = new BgWorkerResult("Bad Password.", false);
                return;
            }
            backgroundInitialiser.ReportProgress(40, "Contacting API...");
            if (Program.apiWorker.Authenticate(Program.PrivateKey))
            {
                Balance = Program.apiWorker.GetBalance();
            }
            backgroundInitialiser.ReportProgress(100);
            e.Result = new BgWorkerResult("Done", true);
            return;
        }

        private void backgroundInitialiser_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelLoading.Text = (string)e.UserState;
            if (e.ProgressPercentage > 0)
            {
                this.TopMost = true;
            }
        }

        private void backgroundInitialiser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = (BgWorkerResult)e.Result;
            if (result.Success)
            {
                timerStall.Stop();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(result.Status, "Application problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
        }

        public static bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        bool unlockDefaultWallet()
        {
            try
            {
                string fileName = Properties.Settings.Default.DefaultAccount;
                Json = File.ReadAllText(fileName);
                Nethereum.KeyStore.KeyStoreService KeyStore = new Nethereum.KeyStore.KeyStoreService();
                Program.ActiveAddress = KeyStore.GetAddressFromKeyStore(Json);
                using (PasswordForm credentials = new PasswordForm(fileName, Program.ActiveAddress, false))
                {
                    ToggleImage = false;
                    var result = credentials.ShowDialog();
                    ToggleImage = true;
                    if (result == DialogResult.OK)
                    {
                        Password = credentials.Password;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                 return false;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void closeBox_MouseEnter(object sender, EventArgs e)
        {
            closeBox.BackColor = Color.Red;
        }

        private void closeBox_MouseLeave(object sender, EventArgs e)
        {
            closeBox.BackColor = Color.Transparent;
        }

        private void closeBox_MouseDown(object sender, MouseEventArgs e)
        {
            closeBox.BackColor = Color.IndianRed;
        }
    }
}
