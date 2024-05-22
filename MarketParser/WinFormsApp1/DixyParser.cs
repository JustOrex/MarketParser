using AngleSharp.Html.Parser;

namespace MarketParser
{
    internal class DixyParser : IParser<string[]>
    {
        private string repeatCheck = null;
        
        public string[] Parse(string source)
        {

            
            
            var DomParser = new HtmlParser();

            var document = DomParser.ParseDocument(source);

            var list = new List<string>();

            var item = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("dixyModal__title"));

            var itemPrices = document.QuerySelectorAll("div.dixyCatalogItemPrice.dixyModal__price div").Where(item => item.ClassName != null && item.ClassName.Contains("dixyCatalogItemPrice__new")).ToList();
  

            int num = 0;
            foreach (var i in item)
            {
                var str = $"{i.TextContent} ---  {itemPrices[num].TextContent.Trim()}р";

                list.Add(str);
                num++;
                
                if(repeatCheck == str)
                {
                    return null;
                }
                
                
                if(repeatCheck == null)
                {
                    repeatCheck = str;
                }

                
            }

            if (list.Count == 0)
            {
                return null;
            }
            else
            {
                return list.ToArray();
            }
        }

    }
}
