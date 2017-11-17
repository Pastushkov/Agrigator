using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregator
{
    public class Class1
    {
    }

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

        }

        public abstract void Initialize(string url, string account, string secretKey, string terminalID, string artificateName, string artificatePassword);

        public abstract CheckResponse Check(int providerProductID, string jsonFields);

        public abstract PayResponse Pay(int providerProductID,string jsonFields, string idempotenKey);

        public abstract ComissionResponce Comission(int providerProductID, string jsonFields);

        public abstract string GeFields(int providerProductID);
        public abstract object GetSurvices();
    }

    

}
