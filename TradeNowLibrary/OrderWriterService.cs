using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;


namespace TradeNowLibrary
{
    public class OrderWriterService : IOrderWriterService

    {
        private readonly IOrderWriterService orderWriterService;
        public void saveOrder(TraderTicket data)
        {
            var Serializer = new SerializerDeserializer();

            // Writing new Order Data into Json File //

            string jsonFile = @"C:\Users\ali.amjad\source\repos\iTradeNow\TradeNow\jsondata.json";

            var dataSerialized = Serializer.ConvertObjectToString(data);

            File.WriteAllText(jsonFile, dataSerialized);

        }

        public dynamic readOrder()
        {
            var Deserializer = new SerializerDeserializer();

            string objectString = File.ReadAllText(@"C:\Users\ali.amjad\source\repos\iTradeNow\TradeNow\jsondata.json");

            var dataDeSerialized = Deserializer.ConvertStringToObject<TraderTicket>(objectString, "TradeNowLibrary.TraderTicket");

            return dataDeSerialized;
        }

    }
}