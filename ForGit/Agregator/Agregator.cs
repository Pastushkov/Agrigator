using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace AgregatorNS
{
   public class NewAgregator : Agregator
    {

       public string ArtificatePassword { get; set; }

        public string ArtificateName { get; set; }

        public string TerminalID { get; set; }

        public  string SecretKey { get; set; }

        public string Account { get; set; }

        public string Url{get;set;}

        HttpClient httpClient = new HttpClient();

        
      
        public override CheckResponse Check(int providerProductID, string jsonFields)
        {


            CheckResponse res = new CheckResponse();
            
            Encoding win1251 = Encoding.GetEncoding(1251);
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, Url);
            httpRequest.Content = new StringContent(jsonFields, win1251);
            
            try
            {
                using (HttpResponseMessage httpResponse = httpClient.SendAsync(httpRequest).Result)
                {
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        res.jsonValue = httpResponse.Content.ReadAsStringAsync().Result;
                        res.Status = true;
                    }
                    else
                        res.Status = false;
                    
                }
            }
            catch
            {

            }

            return res;
        }

        public override ComissionResponce Comission(int providerProductID, string jsonFields)
        {
            throw new NotImplementedException();
        }

        public override string GeFields(int providerProductID)
        {
            throw new NotImplementedException();
        }

        public override object GetSurvices()
        {
            throw new NotImplementedException();
        }

        public override PayResponse Pay(int providerProductID, string jsonFields, string idempotenKey)
        {
            throw new NotImplementedException();
        }

        public override void Initialize(string url, string account, string secretKey, string terminalID, string artificateName, string artificatePassword)
        {
            Url = url;
            Account = account;
            SecretKey = secretKey;
            TerminalID = terminalID;
            ArtificateName = artificateName;
            ArtificatePassword = ArtificatePassword;
        }                    
    }
}
