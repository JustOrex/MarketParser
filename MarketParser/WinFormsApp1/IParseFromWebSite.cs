

namespace MarketParser
{
    internal interface IParseFromWebSite
    {

        public event Action<object, string[]> OnNewData;

        public event Action<object> OnCompleted;

        Task Start();
        


    }
}
