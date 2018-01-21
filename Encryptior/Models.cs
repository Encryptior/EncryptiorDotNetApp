using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Encryptior
{
    public class Models
    {

        public class ProjectData
        {
            public string EncryptedFilename { get; set; }
            public string DataFolder { get; set; }
        }

        public class File
        {
            public string FileHash { get; set; }
            public string Owner { get; set; }
            public double CostUSD { get; set; }
            public string Password { get; set; }
            public string TransactionHash { get; set; }
        }

        public class Balance
        {
            public double BalanceETH { get; set; }
            public double ETH2USD { get; set; }
            public double BalanceUSD { get; set; }
            public BigInteger Nonce { get; set; }
        }

        public class TransactionInput
        {
            public long Timestamp { get; set; }
            public string FileHash { get; set; }
            public double CostUSD { get; set; }
            public double ETH2USD { get; set; }
            public double CostETH { get; set; }
            public BigInteger CostWei { get; set; }
            public string ByteCode { get; set; }
            public GasPrice GasPrice { get; set; }
            public BigInteger GasLimit { get; set; }
            public string ContractAddress { get; set; }
            public string PayTo { get; set; }
            public BigInteger Nonce { get; set; }
            public BigInteger SelectedGasPrice { get; set; }
        }

        public class TransactionEntry
        {
            public long Timestamp { get; set; }
            public string TransactionHash { get; set; }
            public string FileHash { get; set; }
            public string Status { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public double CostUSD { get; set; }
            public double ETH2USD { get; set; }
            public double CostETH { get; set; }
        }

        public class TransactionResult
        {
            public long Timestamp { get; set; }
            public string TransactionHash { get; set; }
            public string Status { get; set; }
        }

        public class GasPrice
        {
            public BigInteger LowPrice { get; set; }
            public BigInteger MediumPrice { get; set; }
            public BigInteger HighPrice { get; set; }
            public double LowPriceWait { get; set; }
            public double MediumPriceWait { get; set; }
            public double HighPriceWait { get; set; }
        }

        public class CurrentVersion
        {
            public string Version { get; set; }
            public string DownloadLink { get; set; }
        }
    }
}
