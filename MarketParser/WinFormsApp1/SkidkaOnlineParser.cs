using Newtonsoft.Json;


namespace MarketParser
{
    internal class SkidkaOnlineParser : IParser<string[]>
    {
        public string[] Parse(string source)
        {

            var list = new List<string>();

            var products = JsonConvert.DeserializeObject<Rootobject>(source);
            foreach (var i in products.products)
            {
                if(!string.IsNullOrWhiteSpace(i.priceafter))
                  list.Add(i.name + " --- " + i.priceafter + " руб");
            }

            return list.ToArray();
        }
    }
}
