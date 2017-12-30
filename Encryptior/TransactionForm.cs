using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Encryptior
{
    public partial class TransactionForm : Form
    {
        private int expiry = 59;
        public Models.Balance Balance; 
        public Models.TransactionInput transaction;
        public Models.TransactionResult TransResult;

        public TransactionForm(string UnlockFileHash, string filename)
        {
            // double transFee = (double)(transaction.GasPrice * transaction.GasLimit) / 1000000000000000000;
            InitializeComponent();
            if (filename.Length >= 50)
            {
                labelFilename.Text = filename.Substring(1, 50) + "...";
            }
            else
            {
                labelFilename.Text = filename;
            }
            backgroundWorkerTransaction.RunWorkerAsync(UnlockFileHash);
        }

        private void timerExpiry_Tick(object sender, EventArgs e)
        {
            expiry--;
            if (expiry > 0)
            {
                labelExpiredNotification.Text = "Transaction expires in " + expiry.ToString() + "s";
            }
            else
            {
                buttonConfirm.Enabled = false;
                labelExpiredNotification.Text = "Transacion expired. Please try again.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            backgroundWorkerPay.RunWorkerAsync();
            buttonConfirm.Enabled = false;
        }

        private void backgroundWorkerTransaction_DoWork(object sender, DoWorkEventArgs e)
        {
            string UnlockFileHash = (string)e.Argument;
            transaction = Program.apiWorker.NewTransaction(UnlockFileHash);
            Balance = Program.apiWorker.GetBalance();
        }

        private void backgroundWorkerTransaction_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var transactionCost = transaction.GasLimit * transaction.GasPrice;
            double transFee = (double)transactionCost / 1000000000000000000;

            textBoxFileCostUsd.Text = transaction.CostUSD.ToString() + " $";
            textBoxFileCostEth.Text = transaction.CostETH.ToString() + " ETH";
            textBoxTransFee.Text = transFee.ToString() + " ETH";
            textBoxTotalEther.Text = Convert.ToString(transaction.CostETH + transFee) + " ETH";
            textBoxTotalUsd.Text = ((transaction.CostETH + transFee) * transaction.ETH2USD).ToString("0.00") + " $";
            textBoxCourse.Text = "(@ " + transaction.ETH2USD + " $/ETH)";
            labelFunds.Text = "My Account: " + Balance.BalanceETH + " ETH";
            if (transaction.CostETH + transFee > Balance.BalanceETH)
            {
                buttonConfirm.Enabled = false;
                labelExpiredNotification.Text = "Not enough funds to make a transaction";
                timerExpiry.Stop();
            }
            else
            {
                buttonConfirm.Enabled = true;
                timerExpiry.Start();
            }
        }

        private void backgroundWorkerPay_DoWork(object sender, DoWorkEventArgs e)
        {
            TransResult = Program.apiWorker.PayTransaction(transaction, Program.PrivateKey);
        }

        private void backgroundWorkerPay_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
