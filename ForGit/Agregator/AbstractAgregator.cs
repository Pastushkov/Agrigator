using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregatorNS
{  
    public class CheckResponse
    {
        bool Status;
        string errorCode;
        string errorMessage;
        string jsonValue;
    }

    public class PayResponse
    {
        int state;
        string providerTransactionID;
        string errorCod;
        string errorMessage;
        string jsonValue;
        string idempotentKey;
           
    }

    public class ComissionResponce
    {
        int providerProductID;
        double providerComission;
    }

    public abstract class Agregator
    {
        public void AgregatorLogger(string TypeMessage, string message)
        {
            string logFile = "Agregator.log";
            StringBuilder content = new StringBuilder();
            content.AppendLine(DateTime.Today + " Type=> " + TypeMessage + " Message=> " + message);
            
            try
            {
                File.AppendAllText(logFile,content.ToString());
            }
            catch
            {

            }
        }

        public abstract void Initialize(string url, string account, string secretKey, string terminalID, string artificateName, string artificatePassword);

        public abstract CheckResponse Check(int providerProductID, string jsonFields);

        public abstract PayResponse Pay(int providerProductID,string jsonFields, string idempotenKey);

        public abstract ComissionResponce Comission(int providerProductID, string jsonFields);

        public abstract string GeFields(int providerProductID);
        public abstract object GetSurvices();
    }

    

}
