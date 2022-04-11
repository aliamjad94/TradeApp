using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TradeNowLibrary
{
    public class SerializerDeserializer
    {
        public string ConvertObjectToString<myObjectType>(myObjectType myObject)
        {
            string content = string.Empty;

            var js = new DataContractJsonSerializer(typeof(myObjectType));

            var ms = new MemoryStream();

            js.WriteObject(ms, myObject);

            ms.Position = 0;

            var reader = new StreamReader(ms);

            content = reader.ReadToEnd();
            
            return content;
        }

        public myObjectType ConvertStringToObject<myObjectType>(string myObjectString, string myObjectName)
        {
            myObjectType myObject = (myObjectType)Activator.CreateInstance(Type.GetType(myObjectName));

            var js = new DataContractJsonSerializer(typeof(myObjectType));

            byte[] byteArray = Encoding.UTF8.GetBytes(myObjectString);

            var ms = new MemoryStream(byteArray);

            myObject = (myObjectType)js.ReadObject(ms);

            return myObject;
        }
    }
}
