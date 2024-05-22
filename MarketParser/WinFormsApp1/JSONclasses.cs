
namespace MarketParser
{

        public class Rootobject
        {
            public Product[] products { get; set; }
            public string totalCount { get; set; }
            public int currentPage { get; set; }
            public string countPerPage { get; set; }
            public string next { get; set; }
            public Input input { get; set; }
        }

        public class Input
        {
            public object[] input { get; set; }
            public object[] post { get; set; }
            public Get get { get; set; }
            public string authorization { get; set; }
        }

        public class Get
        {
            public string limit { get; set; }
            public string offset { get; set; }
            public string shop_id { get; set; }
            public string city_id { get; set; }
            public string fields { get; set; }
        }

        public class Product
        {
            public string id { get; set; }
            public string pricebefore { get; set; }
            public string priceafter { get; set; }
            public string discount_type { get; set; }
            public string discount { get; set; }
            public string externalurl { get; set; }
            public string discounts_id { get; set; }
            public string image_contains_price { get; set; }
            public string startdate { get; set; }
            public string enddate { get; set; }
            public string name2 { get; set; }
            public string name { get; set; }
            public Image336 image336 { get; set; }
            public Imagefull imagefull { get; set; }
            public string countPlus { get; set; }
            public int countMinus { get; set; }
            public string[] shops_ids { get; set; }
            public string comments { get; set; }
            public string daystitle { get; set; }
            public string date { get; set; }
            public string discount_name { get; set; }
            public int color { get; set; }
            public int noted { get; set; }
            public int notalladdr { get; set; }
            public string url { get; set; }
            public int liked { get; set; }
            public string desc { get; set; }
            public string discount_url { get; set; }
            public object[] brands { get; set; }
            public bool started_today { get; set; }
            public bool published_today { get; set; }
            public object added_time_text { get; set; }
        }

        public class Image336
        {
            public string src { get; set; }
            public int w { get; set; }
            public int h { get; set; }
        }

        public class Imagefull
        {
            public string src { get; set; }
            public int w { get; set; }
            public int h { get; set; }
        }

    }

