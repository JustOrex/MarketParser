

namespace MarketParser
{
    internal class ParseFromSkidkaOnline : IParseFromWebSite
    {
       

        public event Action<object, string[]> OnNewData;

        public event Action<object> OnCompleted;

        private int MarketId;

        private int CityId;

        public ParseFromSkidkaOnline( int MarketId, int CityId)
        {
            this.MarketId = MarketId;
            this.CityId = CityId;
        }

        
        public async Task Start()
        {
            ParserWorker<string[]> pw = new(new SkidkaOnlineParser(), true, 30, new SkidkaOnlineSettings(MarketId,CityId));
            pw.OnNewData += Pw_OnNewData;
            await pw.Start();
            OnCompleted?.Invoke(this);
        }

        private void Pw_OnNewData(object arg1, string[] arg2)
        {
            OnNewData?.Invoke(arg1, arg2);
        }
    }
}

