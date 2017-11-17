using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregator
{
    class NewAgregator : Agregator
    {

        string ArtificatePassword
        {
            get; set;
        }
        string ArtificateName
        {
            get; set;
        }
        string TerminalID
        {
            get; set;
        }
        string SecretKey
        {
            get; set;
        }
        string Account
        {
            get; set;
        }
        string Url
        {
            get;
            set;
        }

        public override CheckResponse Check(int providerProductID, string jsonFields)
        {
            
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

        public override void Initialize(string url, string account, string secretKey, string terminalID, string artificateName, string artificatePassword)
        {
            Url = url;
            Account = account;
            SecretKey = secretKey;
            TerminalID = terminalID;
            ArtificateName = artificateName;
            ArtificatePassword = ArtificatePassword;
        }

        public override PayResponse Pay(int providerProductID, string jsonFields, string idempotenKey)
        {
            throw new NotImplementedException();
        }

      

       


    }
}
