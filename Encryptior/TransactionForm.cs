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

 
        private string number2time(double minutes)
        {
            TimeSpan span = TimeSpan.FromMinutes(minutes);
            string formatted = string.Format("{0}",
                span.Duration().Minutes > 0 ? string.Format("{0:0} min{1}, ", span.Minutes+1, span.Minutes+1 == 1 ? String.Empty : "s") : string.Empty
                );

            if (formatted.EndsWith(", ")) formatted = formatted.Substring(0, formatted.Length - 2);

            if (string.IsNullOrEmpty(formatted)) formatted = "1 min";

            return formatted;
        } 

        private void backgroundWorkerTransaction_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            transaction.SelectedGasPrice = transaction.GasPrice.MediumPrice;
            var transactionCost = transaction.GasLimit * transaction.SelectedGasPrice;
            double transFee = (double)transactionCost / 1000000000000000000;
            groupBoxConfTime.Enabled = true;
            textBoxFileCostUsd.Text = transaction.CostUSD.ToString() + " $";
            textBoxFileCostEth.Text = transaction.CostETH.ToString() + " ETH";
            textBoxTransFee.Text = (transFee * transaction.ETH2USD).ToString("0.00") + " $";
            textBoxTotalEther.Text = Convert.ToString(transaction.CostETH + transFee) + " ETH";
            textBoxTotalUsd.Text = ((transaction.CostETH + transFee) * transaction.ETH2USD).ToString("0.00") + " $";
            textBoxCourse.Text = "(@ " + transaction.ETH2USD + " $/ETH)";
            labelFunds.Text = "My Account: " + Balance.BalanceETH + " ETH";

            labelSlow.Text = number2time(transaction.GasPrice.LowPriceWait);
            labelMedium.Text = number2time(transaction.GasPrice.MediumPriceWait);
            labelFast.Text = number2time(transaction.GasPrice.HighPriceWait);

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

        private void changeFee(BigInteger GasPrice)
        {
            var transactionCost = transaction.GasLimit * GasPrice;
            double transFee = (double)transactionCost / 1000000000000000000;
            textBoxFileCostEth.Text = transaction.CostETH.ToString() + " ETH";
            textBoxTransFee.Text = (transFee * transaction.ETH2USD).ToString("0.00") + " $";
            textBoxTotalEther.Text = Convert.ToString(transaction.CostETH + transFee) + " ETH";
            textBoxTotalUsd.Text = ((transaction.CostETH + transFee) * transaction.ETH2USD).ToString("0.00") + " $";
            if (transaction.CostETH + transFee > Balance.BalanceETH)
            {
                buttonConfirm.Enabled = false;
                labelExpiredNotification.Text = "Not enough funds to make a transaction";
            }
            else
            {
                buttonConfirm.Enabled = true;
            }
        }


        private void radioButtonSlow_CheckedChanged(object sender, EventArgs e)
        {
            transaction.SelectedGasPrice = transaction.GasPrice.LowPrice;
            changeFee(transaction.GasPrice.LowPrice);
        }

        private void radioButtonMed_CheckedChanged(object sender, EventArgs e)
        {
            transaction.SelectedGasPrice = transaction.GasPrice.MediumPrice;
            changeFee(transaction.GasPrice.MediumPrice);
        }

        private void radioButtonFast_CheckedChanged(object sender, EventArgs e)
        {
            transaction.SelectedGasPrice = transaction.GasPrice.HighPrice;
            changeFee(transaction.GasPrice.HighPrice);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In order to execute ether transaction, a certain fee is added to the basic transaction cost. Value of this fee determines probable execution time - if the network is congested, miners will request higher fees and confirmation times will be longer.\n\nValues for the transaction confirmation time provided here are just indicative (averages), and real transaction may take shorter or longer - we have no control over this.\n\nSource: https://ethgasstation.info/", "Confirmation Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
