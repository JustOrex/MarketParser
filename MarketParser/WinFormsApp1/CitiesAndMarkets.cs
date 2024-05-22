using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketParser
{
    internal struct CitiesAndMarkets
    {
        public Dictionary<string, City> cities = new()
        {
            ["Москва"] = new City(1,"moskva"),["Санкт-Петербург"] = new City(2, "sankt-peterburg"),["Ярославль"] = new City(169, "yaroslavl"),["Новосибирск"] = new City(99, "novosibirsk"),["Екатеринбург"] = new City(49, "yekaterinburg"), ["Нижний Новгород"] = new City(95, "nizhniy-novgorod"), ["Казань"] = new City(60, "kazan"),
            ["Самара"] = new City(123, "samara"),["Челябинск"] = new City(158, "chelyabinsk"),["Омск"] = new City(104, "omsk"),["Уфа"] = new City(151, "ufa"),["Красноярск"] = new City(73, "krasnoyarsk"),["Пермь"] = new City(110, "perm"),["Волгоград"] = new City(10, "volgograd"),
            ["Воронеж"] = new City(42, "voronezh"),["Саратов"] = new City(125, "saratov"),["Краснодар"] = new City(72, "krasnodar"),["Тюмень"] = new City(147, "tyumen"),["Тольятти"] = new City(143, "tolyatti"),["Ижевск"] = new City(56, "izhevsk"),["Барнаул"] = new City(25, "barnaul"),
            ["Ульяновск"] = new City(149, "ulyanovsk"),["Иркутск"] = new City(57, "irkutsk"),["Владивосток"] = new City(37, "vladyvostok"),["Хабаровск"] = new City(153, "khabarovsk"),["Махачкала"] = new City(85, "makhachkala"),["Оренбург"] = new City(106, "orenburg"),["Томск"] = new City(144, "tomsk"),
            ["Новокузнецк"] = new City(97, "novokuznetsk"),["Липецк"] = new City(78, "lipeck"),["Ставрополь"] = new City(134, "stavropol"),["Белгород"] = new City(26, "belgorod"),["Сургут"] = new City(136, "surgut"),["Череповец"] = new City(8, "cherepovets"),["Якутск"] = new City(168, "yakutsk"),
            ["Кемерово"] = new City(64, "kemerovo"),["Тула"] = new City(146, "tula"),["Магнитогорск"] = new City(82, "magnitogorsk"),["Нижний Тагил"] = new City(96, "nizhniy-tagil"),["Смоленск"] = new City(130, "smolensk"),["Вологда"] = new City(41, "vologda"),["Тамбов"] = new City(140, "tambov"),
            ["Астрахань"] = new City(23, "astrakhan"),["Киров"] = new City(66, "kirov"),["Тверь"] = new City(141, "tver"),["Архангельск"] = new City(22, "arkhangelsk"),["Волжский"] = new City(40, "volzhskiy"),["Владикавказ"] = new City(38, "vladikavkaz"),["Стерлитамак"] = new City(135, "sterlitamak"),
            ["Рязань"] = new City(122, "ryazan"),["Чебоксары"] = new City(157, "cheboksary"),["Иваново"] = new City(55, "ivanovo"),["Владимир"] = new City(39, "vladimir"),["Курган"] = new City(74, "kurgan"),["Саранск"] = new City(124, "saransk"),["Кострома"] = new City(71, "kostroma"),
            ["Набережные Челны"] = new City(88, "naberezhnyye-chelny"),["Калининград"] = new City(61, "kaliningrad"),["Брянск"] = new City(33, "bryansk"),["Чита"] = new City(161, "chita"),["Орел"] = new City(105, "orel"),["Мурманск"] = new City(87, "murmansk"),["Петрозаводск"] = new City(112, "petrozavodsk"),
            ["Пенза"] = new City(109, "penza"),["Курск"] = new City(75, "kursk"),["Сочи"] = new City(133, "sochi"),["Калуга"] = new City(62, "kaluga"), ["Нижневартовск"] = new City(93, "nizhnevartovsk"), ["Йошкар-Ола"] = new City(59, "jjoshkar-ola"), ["Новороссийск"] = new City(98, "novorossijjsk"),
            ["Комсомольск-на-Амуре"] = new City(70, "komsomolsk-na-amure"),["Таганрог"] = new City(139, "taganrog"), ["Ростов-на-Дону"] = new City(119, "rostov-na-donu")

        };

        public Dictionary<string, Market> markets = new()
        {
            ["Магнит"] = new Market(2,"magnit"), ["Пятёрочка"] = new Market(9, "pyaterochka"), ["Вкусвилл"] = new Market(1140, "vkusvill"), ["Светофор"] = new Market(1265, "-svetofor")
        };
        public CitiesAndMarkets() { }
    }
}
