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
using System.Numerics;
using System.Diagnostics;
using System.Globalization;

namespace Encryptior
{
    public partial class Payout : Form
    {
        public Payout(string amount)
        {
            InitializeComponent();
            labelMyFunds.Text = "My account: " + amount;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxAddress.Text.HexToByteArray().Length == 20) && (textBoxAddress.Text.Length == 42))
                {
                    double amount;
                    if (double.TryParse(textBoxAmount.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out amount) && IsValidCost(amount))
                    {
                        string fileName = Properties.Settings.Default.DefaultAccount;
                        string json = File.ReadAllText(fileName);
                        Nethereum.KeyStore.KeyStoreService KeyStore = new Nethereum.KeyStore.KeyStoreService();
                        string address = KeyStore.GetAddressFromKeyStore(json);
                        Form credentials = new PasswordForm(fileName, address);
                        if (credentials.ShowDialog() == DialogResult.OK)
                        {
                            Form transfer = new TransferForm(amount, textBoxAddress.Text);
                            this.DialogResult = transfer.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Bad Password");
                            this.DialogResult = DialogResult.Abort;
                        }
                    }
                    else
                    {
                        textBoxAmount.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxAddress.Text.HexToByteArray().Length == 20)&&(textBoxAddress.Text.Length == 42))
                {
                    Identicon identicon = new Identicon(textBoxAddress.Text, 8);
                    pictureBoxIdenticon.Image = identicon.GetBitmap(128);
                    textBoxAddress.ForeColor = Color.Black;
                }
                else
                {
                    textBoxAddress.ForeColor = Color.Red;
                }
            }
            catch
            {
                textBoxAddress.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(textBoxAmount.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out amount) && IsValidCost(amount))
            {
                textBoxAmount.ForeColor = Color.Black;
            }
            else
            {
                textBoxAmount.ForeColor = Color.Red;
            }
        }

        private void buttonGas_Click(object sender, EventArgs e)
        {
            Process.Start("https://ethgasstation.info/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var icon = new Identicon(textBoxAddress.Text, 8);
            var Icon = icon.GetIcon(128);
            var stream = File.OpenWrite(@"C:\Users\stevan\Desktop\icon.ico");
            Icon.Save(stream);
            stream.Close();
        }

        private bool IsValidCost(double _cost)
        {
            return (_cost >= 0);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.encryptior.com/Documentation/Seller");
        }
    }
}
