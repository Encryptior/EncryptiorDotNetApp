using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nethereum.Hex.HexConvertors.Extensions;
using Newtonsoft.Json.Linq;

// Set the TextBox's PasswordChar property
// to X or something at design time.

namespace Encryptior
{
    public partial class PasswordForm : Form
    {
        private string Json;
        public string PrivateKey;

        public PasswordForm(string fileName, string address)
        {
            Json = File.ReadAllText(fileName);
            InitializeComponent();
            labelAddress.Text = address;
            Identicon identicon = new Identicon(address, 8);
            pictureBoxIdenticon.Image = identicon.GetBitmap(100);
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txtPassword.Enabled = false;
            buttonCancel.Enabled = false;
            buttonOK.Enabled = false;
            labelinfo.Visible = true;
            string password = txtPassword.Text;
            backgroundWorker1.RunWorkerAsync(password);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var password = (string)e.Argument;
                var keyStoreService = new Nethereum.KeyStore.KeyStoreService();
                PrivateKey = keyStoreService.DecryptKeyStoreFromJson(password, Json).ToHex();
                e.Result = true;
            }
            catch
            {
                e.Result = false;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonOK.PerformClick();
            }
        }
    }
}
