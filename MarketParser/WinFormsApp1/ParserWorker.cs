using AngleSharp.Html.Parser;

namespace MarketParser
{
    internal class ParserWorker<T> where T : class
    {
        IParser<T> parser;

        IParserSettings parserSettings;

        HTMLloader htmlLoader;
        public IParser<T> Parser
        {
            get
            {
                return parser;
            }

            set
            {
                parser = value;
            }
        }
        public IParserSettings ParserSettings
        {
            get
            {
                return parserSettings;
            }

            set
            {
                parserSettings = value;
                htmlLoader = new HTMLloader(value);
            }
        }

        public bool isActive { get; private set; }

        public event Action<object, T> OnNewData;

        private bool isPage;

        private int pagesInStep;
        public ParserWorker(IParser<T> Parser, bool isPage, int pagesInStep)
        {
            this.Parser = Parser;

            this.isPage = isPage;

            this.pagesInStep = pagesInStep;
        }

        public ParserWorker(IParser<T> Parser, bool isPage, int pagesInStep, IParserSettings ParserSettings) : this(Parser, isPage, pagesInStep)
        {
            this.ParserSettings = ParserSettings;
        }


        public async Task Start()
        {
            isActive = true;

            await Worker();
        }


        private async Task Worker()
        {
            for (var i = parserSettings.StartPoint; i <= int.MaxValue; i += pagesInStep)
            {
                if (!isActive)
                { 
                    return;
                }

                string source;

                if (isPage)
                {
                    source = await htmlLoader.GetSourceByPageId(i);
                }
                else
                {
                    source = await htmlLoader.GetSourceWithOutPageId();
                }


                if (source.Count() < 1000)
                {
                    break;
                }

                var res = parser.Parse(source);

                if(res == null)
                {
                    break;
                }

                OnNewData?.Invoke(this, res);

                if (!isPage)
                {
                    break;
                }
            }
            isActive = false;
        }


    }
}
