using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptior
{
    public partial class Faucet : Form
    {
        public Faucet()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var transaction = Program.apiWorker.GimmeMoney();
            Process.Start("https://ropsten.etherscan.io/tx/" + linkLabel1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            var transaction = Program.apiWorker.GimmeMoney();
            linkLabel1.Text = transaction.TransactionHash;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ok, got your attention.\nTHIS IS NOT REAL ETHER(MONEY)!!!\nNobody would give you money for noting...\nDon't use this accounts to make real payments, and more importantly DON'T USE REAL ETHER ACCOUNTS HERE!", "Important Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
