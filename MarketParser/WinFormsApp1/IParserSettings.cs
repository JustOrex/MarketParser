
namespace MarketParser
{
    internal interface IParserSettings
    {
        string Url { get; set; }

        string Prefix { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }
    }
}
