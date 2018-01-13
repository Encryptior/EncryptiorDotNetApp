using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptior
{
    public partial class ChooseWallet : Form
    {
        public static string[] Wallets;
        public string Filename;
        public string Address;
        private bool Decrypt;

        public ChooseWallet(bool decrypt = true)
        {
            Decrypt = decrypt;
            InitializeComponent();
            refreshWalletList();
        }

        private void refreshWalletList()
        {
            listView1.View = View.Details;
            if (!Directory.Exists(Program.WalletPath))
                Directory.CreateDirectory(Program.WalletPath);
            Wallets = Directory.GetFiles(Program.WalletPath, "*.wallet");
            if (Wallets.Length == 0) return;
            List<string> Accounts = new List<string>();
            listView1.Items.Clear();
            foreach (string walletFileName in Wallets)
            {
                string accountJson = File.ReadAllText(walletFileName);
                var keyStoreDocument = JObject.Parse(accountJson);
                ListViewItem item = new ListViewItem();
                Identicon identicon = new Identicon(keyStoreDocument["address"].ToString(), 8);
                imageListIdenticons.Images.Add(identicon.GetBitmap(32));

                listView1.Items.Add(new ListViewItem() { ImageIndex = imageListIdenticons.Images.Count - 1, Text = keyStoreDocument["address"].ToString(), Name = walletFileName });
            }
        }

        private void buttonCreateWallet_Click(object sender, EventArgs e)
        {
            using (FirstPassword frm = new FirstPassword())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    refreshWalletList();
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (openFileDialog.FileNames.Length != 0)
            {
                foreach (var fileName in openFileDialog.FileNames)
                {
                    try
                    {
                        string json = File.ReadAllText(fileName);
                        Nethereum.KeyStore.KeyStoreService KeyStore = new Nethereum.KeyStore.KeyStoreService();
                        string address = KeyStore.GetAddressFromKeyStore(json);
                        File.WriteAllText(Program.WalletPath + "\\" + address + ".wallet", json);
                    }
                    catch { }
                }
            }
            refreshWalletList();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                UnlockAccount();
            else
                MessageBox.Show("Please select a wallet from the list", "No wallet selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            UnlockAccount();
        }

        void UnlockAccount()
        {
            Filename = listView1.SelectedItems[0].Name;
            Address = listView1.SelectedItems[0].Text;
            if (Decrypt)
            {
                using (PasswordForm credentials = new PasswordForm(Filename, Address))
                {
                    var result = credentials.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Program.PrivateKey = credentials.PrivateKey;
                        Program.ActiveAddress = Address;
                        Properties.Settings.Default.DefaultAccount = Filename;
                        Properties.Settings.Default.Save();
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (result == DialogResult.Abort)
                    {
                        MessageBox.Show("Bad Password", "Password Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOpenFiles_Click(object sender, EventArgs e)
        {
            Process.Start(Program.WalletPath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.encryptior.com/#about");
        }
    }
}
