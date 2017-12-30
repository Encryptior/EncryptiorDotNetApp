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
        private double transFee;
        double Balance;

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
            var transactionHash = Program.apiWorker.SendRawTransaction(transaction.GetRLPEncoded().ToHex());
            Process.Start("https://ropsten.etherscan.io/tx/" + transactionHash.TransactionHash);
            this.DialogResult = DialogResult.OK;
        }

        private void backgroundWorkerTransaction_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var gasPrice = Program.apiWorker.GetGasPrice().Price;
                var balance = Program.apiWorker.GetBalance();
                Balance = balance.BalanceETH;
                BigInteger gasLimit = 30000;
                var txCount = balance.Nonce;
                BigInteger weis = (BigInteger)(Amount * 1000000000000000000);
                transaction = new Nethereum.Signer.Transaction(ToAddress, weis, txCount, gasPrice, gasLimit);
                Nethereum.Signer.EthECKey key = new Nethereum.Signer.EthECKey(Program.PrivateKey);
                transaction.Sign(key);

                var transactionCost = gasLimit * gasPrice;
                transFee = (double)transactionCost / 1000000000000000000;
            }
            catch (Exception ex)
            {
                string x = ex.Message;
            }
        }

        private void backgroundWorkerTransaction_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            textBoxFileCostEth.Text = Amount + " ETH";
            textBoxTransFee.Text = transFee.ToString() + " ETH";
            textBoxTotalEther.Text = Convert.ToString(Amount + transFee) + " ETH";
            labelFunds.Text = "My Account: " + Balance.ToString();
            if (Amount + transFee > Balance)
            {
                buttonConfirm.Enabled = false;
                labelNotEnough.Visible = true;
            }
            else
            {
                buttonConfirm.Enabled = true;
            }
        }
    }
}
