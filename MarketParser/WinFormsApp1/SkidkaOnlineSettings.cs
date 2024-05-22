

namespace MarketParser
{
    internal class SkidkaOnlineSettings : IParserSettings
    {
        public SkidkaOnlineSettings(int marketId, int cityId)
        {
            Url = $"https://skidkaonline.ru/apiv3/products/?limit=30&offset=[CurrentId]&shop_id={marketId}&city_id={cityId}&fields=id,name,name2,shops_ids,url,noted,discount_url,discount_name,date,notalladdr,image336,imagefull,brands,pricebefore,priceafter,discount_type,discount,externalurl,countPlus,countMinus,comments,desc,color,daystitle,liked,started_today,published_today";
        }
        public string Url { get; set; } 
        public string Prefix { get; set; } = null;
        public int StartPoint { get; set; } = 0;
        public int EndPoint { get; set; } = 0;
    }
}
