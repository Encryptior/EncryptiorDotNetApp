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
using Nethereum.Hex.HexConvertors.Extensions;
using Newtonsoft.Json.Linq;

namespace Encryptior
{
    public partial class FirstPassword : Form
    {
        private string Password = "";
        private Nethereum.Signer.EthECKey ecKey = Nethereum.Signer.EthECKey.GenerateKey();
        private byte[] privateKey;


        public FirstPassword()
        {
            InitializeComponent();
            labelAddress.Text = ecKey.GetPublicAddress();
            Identicon identicon = new Identicon(labelAddress.Text, 8);
            pictureBoxIdenticon.Image = identicon.GetBitmap(100);
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                if (txtPassword.Text == txtRepeat.Text)
                {
                    Password = txtPassword.Text;
                    txtPassword.Enabled = false;
                    txtRepeat.Enabled = false;
                    buttonCancel.Enabled = false;
                    buttonOK.Enabled = false;
                    labelinfo.Visible = true;
                    this.Cursor = Cursors.WaitCursor;
                    backgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Passwords don't match", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtRepeat.Text = "";
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var privateKey = ecKey.GetPrivateKeyAsBytes();
            var account = new Nethereum.Web3.Accounts.Account(privateKey);
            Password = txtPassword.Text;
            Nethereum.KeyStore.KeyStoreService KeyStore = new Nethereum.KeyStore.KeyStoreService();
            string json = KeyStore.EncryptAndGenerateDefaultKeyStoreAsJson(txtPassword.Text, privateKey, ecKey.GetPublicAddress());
            e.Result = json;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string json = (string)e.Result;
            File.WriteAllText(Program.WalletPath + "/" + ecKey.GetPublicAddress() + ".wallet", json);
            this.DialogResult = DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelWarning.Visible = !labelWarning.Visible;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ecKey = Nethereum.Signer.EthECKey.GenerateKey();
            labelAddress.Text = ecKey.GetPublicAddress();
            Identicon identicon = new Identicon(labelAddress.Text, 8);
            pictureBoxIdenticon.Image = identicon.GetBitmap(100);
        }
    }
}
