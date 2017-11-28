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
       
        public string errorCode;
        public string errorMessage;
        public string jsonValue;
        bool status;

        public bool Status
        {
            get { return status; }
            set
            {
                if (value)
                {
                    errorCode = null;
                    errorMessage = null;
                    status = value;
                }

            }
        }

    }

    public class PayResponse
    {
        public int state;
        public string providerTransactionID;
        public string errorCod;
        public string errorMessage;
        public string jsonValue;
        public string idempotentKey;
           
    }

    public class ComissionResponce
    {
        public int providerProductID;
        public double providerComission;
    }
    

    public abstract class Agregator
    {
        
        public void AgregatorLogger(string TypeMessage, string message)
        {
            if (TypeMessage != "debug" && TypeMessage != "info" && TypeMessage != "error")
                throw new ArgumentOutOfRangeException();

                string logFile = "Agregator.log";
                StringBuilder content = new StringBuilder();
                content.AppendLine(DateTime.Today + " Type=> " + TypeMessage + " Message=> " + message);
                try
                {
                    File.AppendAllText(logFile, content.ToString());
                }
                catch (Exception)
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
