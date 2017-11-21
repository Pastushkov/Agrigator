using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RequestData
{
    public static class Serialization
    {
        public static string ObjToXmlString(object obj)
        {
            XmlSerializer xmlSerialize = new XmlSerializer(obj.GetType());

            using (Stream res = File.Create("Data.xml"))
                xmlSerialize.Serialize(res, obj);

            return File.ReadAllText("Data.xml");
        }
    }

    public class Data // Request and SignMsg
    {
        public Data()
        {
            
        }

        public Request Request { get; set; }

        public string SingMesg { get; set; }
    }

    public class Request // In Data | RtHeader , body, Rfooter
    {
        public Request()
        {

        }

        public RtHeader RtHeader { get; set;}

        public body Body { get; set; }

        public Rfooter Rfooter { get; set;}
    }

    public class RtHeader //In Request | idMsgType
    {
        public RtHeader()
        {

        }

        public string IdMsgType { get; set; }
    }

    public class body// In Request | 
    {
        public body()
        {

        }
    }

    public class Rfooter // In Request | MsgDataTime, idKey
    {
        public Rfooter()
        {

        }

        public string MsgDataTime { get; set;}

        public string IdKey { get; set; }
    }  
}
