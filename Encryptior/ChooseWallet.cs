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

        public ChooseWallet()
        {
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
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            UnlockAccount();
        }

        void UnlockAccount()
        {
            string filename = listView1.SelectedItems[0].Name;
            string address = listView1.SelectedItems[0].Text;
            using (PasswordForm credentials = new PasswordForm(filename, address))
            {
                var result = credentials.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Program.PrivateKey = credentials.PrivateKey;
                    Program.ActiveAddress = address;
                    Properties.Settings.Default.DefaultAccount = filename;
                    Properties.Settings.Default.Save();
                    this.DialogResult = DialogResult.OK;
                }
                else if (result == DialogResult.Abort)
                {
                    MessageBox.Show("Bad Password", "Password Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
