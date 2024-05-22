
namespace MarketParser
{
    internal class Market
    {
        public int id { get; private set; }

        public string name { get; private set; }

        public Market(int id, string name)
        {
            this.id = id;

            this.name = name;
        }
    }
}
