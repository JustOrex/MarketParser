

namespace MarketParser
{
    internal class DixySettings : IParserSettings
    {

       
        public string Url { get; set; } = "https://dixy.ru/catalog/";       
        public string Prefix { get; set; } = "?PAGEN_1=[CurrentId]";
        public int StartPoint { get; set; } = 1;
        public int EndPoint { get; set; } = 0;
    }
}
