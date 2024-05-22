
namespace MarketParser
{
    internal class ParseFromDixi : IParseFromWebSite
    {

        public event Action<object, string[]> OnNewData;

        public event Action<object> OnCompleted;
        public async Task Start()
        {
            var pw = new ParserWorker<string[]>(new DixyParser(), true, 1, new DixySettings());
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
