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
using Nethereum.Hex.HexConvertors.Extensions;
using System.Diagnostics;

namespace Encryptior
{
    public partial class TransferForm : Form
    {
        Nethereum.Signer.Transaction transaction;
        private double Amount;
        private string ToAddress;
        Models.GasPrice GasPrice;
        Models.Balance Balance;
        BigInteger gasLimit = 21000;
        BigInteger ChosenGasPrice;

        public TransferForm(double amount, string toAddress)
        {
            // double transFee = (double)(transaction.GasPrice * transaction.GasLimit) / 1000000000000000000;
            InitializeComponent();
            Amount = amount;
            ToAddress = toAddress;
            backgroundWorkerTransaction.RunWorkerAsync();
            labelTo.Text = toAddress;
            Identicon icon = new Identicon(toAddress, 8);
            pictureBoxIdenticon.Image = icon.GetBitmap(32);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var txCount = Balance.Nonce;
            BigInteger weis = (BigInteger)(Amount * 1000000000000000000);
            transaction = new Nethereum.Signer.Transaction(ToAddress, weis, txCount, ChosenGasPrice, gasLimit);
            Nethereum.Signer.EthECKey key = new Nethereum.Signer.EthECKey(Program.PrivateKey);
            transaction.Sign(key);

            var transactionHash = Program.apiWorker.SendRawTransaction(transaction.GetRLPEncoded().ToHex());
            Process.Start("https://ropsten.etherscan.io/tx/" + transactionHash.TransactionHash);
            this.DialogResult = DialogResult.OK;
        }

        private void backgroundWorkerTransaction_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                GasPrice = Program.apiWorker.GetGasPrice();
                Balance = Program.apiWorker.GetBalance();
            }
            catch (Exception ex)
            {
                string x = ex.Message;
            }
        }

        private string number2time(double minutes)
        {
            TimeSpan span = TimeSpan.FromMinutes(minutes);
            string formatted = string.Format("{0}",
                span.Duration().Minutes > 0 ? string.Format("{0:0} min{1}, ", span.Minutes + 1, span.Minutes + 1 == 1 ? String.Empty : "s") : string.Empty
                );

            if (formatted.EndsWith(", ")) formatted = formatted.Substring(0, formatted.Length - 2);

            if (string.IsNullOrEmpty(formatted)) formatted = "1 min";

            return formatted;
        }

        private void backgroundWorkerTransaction_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChosenGasPrice = GasPrice.MediumPrice;
            double transFee = (double)(ChosenGasPrice * gasLimit) / 1000000000000000000;
            groupBoxConfTime.Enabled = true;
            textBoxFileCostEth.Text = Amount + " ETH";
            textBoxTransFee.Text = (transFee).ToString() + " ETH";
            textBoxTotalEther.Text = Convert.ToString(Amount + transFee) + " ETH";
            labelFunds.Text = "My Account: " + Balance.BalanceETH.ToString();

            labelSlow.Text = number2time(GasPrice.LowPriceWait);
            labelMedium.Text = number2time(GasPrice.MediumPriceWait);
            labelFast.Text = number2time(GasPrice.HighPriceWait);

            if (Amount + transFee > Balance.BalanceETH)
            {
                buttonConfirm.Enabled = false;
                labelNotEnough.Visible = true;
            }
            else
            {
                buttonConfirm.Enabled = true;
            }
        }

        private void changeFee()
        {
            double transFee = (double)(ChosenGasPrice * gasLimit) / 1000000000000000000;
            textBoxTransFee.Text = (transFee).ToString() + " ETH";
            textBoxTotalEther.Text = Convert.ToString(Amount + transFee) + " ETH";
            if (Amount + transFee > Balance.BalanceETH)
            {
                buttonConfirm.Enabled = false;
                labelNotEnough.Visible = true;
            }
            else
            {
                buttonConfirm.Enabled = true;
            }
        }

        private void radioButtonSlow_CheckedChanged(object sender, EventArgs e)
        {
            ChosenGasPrice = GasPrice.LowPrice;
            changeFee();
        }

        private void radioButtonMed_CheckedChanged(object sender, EventArgs e)
        {
            ChosenGasPrice = GasPrice.MediumPrice;
            changeFee();
        }

        private void radioButtonFast_CheckedChanged(object sender, EventArgs e)
        {
            ChosenGasPrice = GasPrice.HighPrice;
            changeFee();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In order to execute ether transaction, a certain fee is added to the basic transaction cost. Value of this fee determines probable execution time - if the network is congested, miners will request higher fees and confirmation times will be longer.\n\nValues for the transaction confirmation time provided here are just indicative (averages), and real transaction may take shorter or longer - we have no control over this.\n\nSource: https://ethgasstation.info/", "Confirmation Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
