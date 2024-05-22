using System.Net;

namespace MarketParser
{
    internal class HTMLloader
    {
       readonly HttpClient client;

        readonly string url;

        public HTMLloader (IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.Url}{settings.Prefix}";
        }

        public async Task <string> GetSourceByPageId(int id)
        {
            var currenturl = url.Replace("[CurrentId]", id.ToString());

            var response = await client.GetAsync(currenturl);

            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }


            return source;
            
        }

        public async Task <string> GetSourceWithOutPageId()
        {

            var response = await client.GetAsync(url);

            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }


            return source;

        }
    }
}
