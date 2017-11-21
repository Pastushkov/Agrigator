using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregatorNS;
using RequestData;

namespace TestAgregatorNS
{
    class Program
    {
        static void Main(string[] args)
        {
            
           AgregatorNS.Agregator agregator = new NewAgregator();
           ((NewAgregator)agregator).Url = "http://www.albahari.com/EchoPost.aspx";
           
            Console.WriteLine(agregator.Check(53,"Request 53").jsonValue);
            Data data = new Data();
            Console.WriteLine(Serialization.ObjToXmlString(data));
            

            Console.ReadLine();
        }
    }
}
