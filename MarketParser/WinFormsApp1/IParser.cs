

namespace MarketParser
{
    internal interface IParser<T> where T : class
    {
        T Parse(string source); 
    }
}
