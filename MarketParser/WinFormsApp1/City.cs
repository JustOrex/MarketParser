
namespace MarketParser
{
    internal class City
    {
        public int id { get; private set; }

        public string name { get; private set; }

        public City(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
