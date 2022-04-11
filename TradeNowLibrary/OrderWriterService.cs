using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace TradeNowLibrary
{
    public class OrderWriterService : IOrderWriterService

    {
        private readonly IOrderWriterService orderWriterService;

        public void saveOrder(dynamic saved)
        {
            string FileName = "jsondata.json";

            var json = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(FileName));

            json.Add(saved);

            File.WriteAllText(FileName, JsonConvert.SerializeObject(json));
        }

        public dynamic readOrder()
        {
            var newvar = JArray.Parse(File.ReadAllText("jsondata.json"));
            return newvar;
        }
    }
}