using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using Nethereum.Hex.HexConvertors.Extensions;

namespace Encryptior
{
    class ApiWorker
    {
        public string AccessToken;

        private const string ApiPath = @"https://www.encryptior.com/ropsten/api/";

        private string GetRequest(string url, string token)
        {
            string answer;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                if (token != null)
                    client.DefaultRequestHeaders.Add("Authorization", token);
                var response = client.GetAsync(url).Result;
                answer = response.Content.ReadAsStringAsync().Result;
            }         
            return answer;
        }

        private string PostRequestAuth(string url, string token, Dictionary<string, string> postParams)
        {
            var formContent = new FormUrlEncodedContent(postParams);
            string answer;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("Authorization", token);
                var response = client.PostAsync(url, formContent).Result;
                answer = response.Content.ReadAsStringAsync().Result;
            }
            return answer;
        }

        private string signToken(Nethereum.Signer.EthECKey ECKey, string messageS)
        {
            byte[] message = Encoding.UTF8.GetBytes(messageS);
            Nethereum.Signer.EthereumMessageSigner signer = new Nethereum.Signer.EthereumMessageSigner();
            return signer.EncodeUTF8AndSign(messageS, ECKey);
        }

        public bool Authenticate(string privateKey)
        {
            Nethereum.Signer.EthECKey ECKey = new Nethereum.Signer.EthECKey(privateKey);
            string address = ECKey.GetPublicAddress();
            string tempToken = GetRequest(ApiPath + "auth/" + address, null).Replace("\"", "");
            string accessToken = PostRequestAuth(ApiPath + "auth", tempToken, new Dictionary<string, string>()
            {
                {"address", address},
                {"signed", signToken(ECKey,tempToken) }
            });
            AccessToken = accessToken.Replace("\"", "");
            return (AccessToken != null);
        }

        public List<Models.File> GetMyFiles()
        {
            string json;
            if (AccessToken == null)
                return null;
            else
            {
                json = GetRequest(ApiPath + "file/myfiles", AccessToken);
            }
            return JsonConvert.DeserializeObject<List<Models.File>>(json);
        }

        public Models.Balance GetBalance()
        {
            string json;
            if (AccessToken == null)
                return null;
            else
            {
                json = GetRequest(ApiPath + "transaction/balance", AccessToken);
            }
            return JsonConvert.DeserializeObject<Models.Balance>(json);
        }

        public bool NewFile(Models.File input)
        {
            string json;
            if (AccessToken == null)
                return false;
            else
            {
                json = PostRequestAuth(ApiPath + "file/new", AccessToken, new Dictionary<string, string>()
            {
                {"cost", input.CostUSD.ToString() },
                {"hash", input.FileHash },
                {"password", input.Password }
            });
            }
            try
            {
                JsonConvert.DeserializeObject<Models.File>(json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Models.File CheckFile(string hash)
        {
            string json;
            if (AccessToken == null)
                return null;
            else
            {
                json = GetRequest(ApiPath + "file/" + hash, AccessToken);
            }
            return JsonConvert.DeserializeObject<Models.File>(json);
        }

        public Models.TransactionInput NewTransaction(string hash)
        {
            string json;
            if (AccessToken == null)
                return null;
            else
            {
                json = PostRequestAuth(ApiPath + "transaction/new/", AccessToken, new Dictionary<string, string>()
            {
                {"hash", hash },
            });
            }
            try
            {
                return JsonConvert.DeserializeObject<Models.TransactionInput>(json);
            }
            catch
            {
                return null;
            }
        }

        public Models.TransactionResult PayTransaction(Models.TransactionInput transaction, string PrivateKeyString)
        {
            if (AccessToken == null)
                return null;
            Nethereum.Signer.EthECKey PrivateKey = new Nethereum.Signer.EthECKey(PrivateKeyString);
            Nethereum.Signer.Transaction rawTrans = new Nethereum.Signer.Transaction(transaction.ContractAddress, transaction.CostWei, transaction.Nonce, transaction.SelectedGasPrice, transaction.GasLimit, transaction.ByteCode);
            rawTrans.Sign(PrivateKey);
            string signed = rawTrans.GetRLPEncoded().ToHex(true);
            string json = PostRequestAuth(ApiPath + "transaction/pay/" + transaction.Timestamp, AccessToken, new Dictionary<string, string>()
            {
                {"SignedCode", signed }
            });
            return JsonConvert.DeserializeObject<Models.TransactionResult>(json);
        }

        public Models.TransactionResult CheckTransaction(string hash)
        {
            if (AccessToken == null)
                return null;
            string json =  GetRequest(ApiPath + "transaction/check/" + hash, AccessToken);
            return JsonConvert.DeserializeObject<Models.TransactionResult>(json);
        }

        public Models.TransactionResult GimmeMoney()
        {
            if (AccessToken == null)
                return null;
            string json = GetRequest(ApiPath + "transaction/gimme/", AccessToken);
            return JsonConvert.DeserializeObject<Models.TransactionResult>(json);
        }

        public Models.TransactionResult SendRawTransaction(string signed)
        {
            if (AccessToken == null)
                return null;
            string json = PostRequestAuth(ApiPath + "transaction/raw/", AccessToken, new Dictionary<string, string>()
            {
                {"SignedCode", signed }
            });
            return JsonConvert.DeserializeObject<Models.TransactionResult>(json);
        }

        public Models.GasPrice GetGasPrice()
        {
            if (AccessToken == null)
                return null;
            string json = GetRequest(ApiPath + "transaction/gasprice/", AccessToken);
            return JsonConvert.DeserializeObject<Models.GasPrice>(json);
        }

        public Models.CurrentVersion GetAppVersion()
        {
            string json = GetRequest(ApiPath + "AppVersion", null);
            return JsonConvert.DeserializeObject<Models.CurrentVersion>(json);
        }
    }
}
