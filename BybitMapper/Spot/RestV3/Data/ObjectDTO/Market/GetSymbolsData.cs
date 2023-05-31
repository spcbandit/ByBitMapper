using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Market
{
    public class GetSymbolsData
    {
        /// <summary>
        /// Символ
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="alias">Псевдомин</param>
        /// <param name="baseCoin">Базовая валюта</param>
        /// <param name="quoteCoin">Валюта котировки</param>
        /// <param name="basePrecision">Десятичная точность (базовой валюты)</param>
        /// <param name="quotePrecision">Десятичная точность (котируемая валюта)</param>
        /// <param name="minTradeQty">Мин. количество ордеров (недействительно для рыночных ордеров на покупку)</param>
        /// <param name="minTradeAmt">Мин. стоимость ордера (действительно только для рыночных ордеров на покупку)</param>
        /// <param name="minPricePrecision">Мин. количество десятичных разрядов</param>
        /// <param name="maxTradeQty">Максимум. количество заказа (игнорируется при размещении заказа с типом заказа LIMIT_MAKER)</param>
        /// <param name="maxTradeAmt">Максимум. стоимость заказа (игнорируется при размещении заказа с типом заказа LIMIT_MAKER)</param>
        /// <param name="category">Категория 1 указывает на то, что цена этой валюты относительно волатильна. 1 означает, что символ открыт для торговли</param>
        [JsonConstructor]
        public GetSymbolsData(string name, string alias, string baseCoin, string quoteCoin, 
            decimal basePrecision, decimal quotePrecision, decimal minTradeQty, 
            decimal minTradeAmt, decimal minPricePrecision, decimal maxTradeQty, 
            decimal maxTradeAmt, int category)
        {
            Name = name;
            Alias = alias;
            BaseCoin = baseCoin;
            QuoteCoin = quoteCoin;
            BasePrecision = basePrecision;
            QuotePrecision = quotePrecision;
            MinTradeQty = minTradeQty;
            MinTradeAmt = minTradeAmt;
            MinPricePrecision = minPricePrecision;
            MaxTradeQty = maxTradeQty;
            MaxTradeAmt = maxTradeAmt;
            Category = category;
        }

        [JsonProperty("name")]
        public string Name { get; }
        [JsonProperty("alias")]
        public string Alias { get; }
        [JsonProperty("baseCoin")]
        public string BaseCoin { get; }
        [JsonProperty("quoteCoin")]
        public string QuoteCoin { get; }
        [JsonProperty("basePrecision")]
        public decimal BasePrecision { get; }
        [JsonProperty("quotePrecision")]
        public decimal QuotePrecision { get; }
        [JsonProperty("minTradeQty")]
        public decimal MinTradeQty { get; }
        [JsonProperty("minTradeAmt")]
        public decimal MinTradeAmt { get; }
        [JsonProperty("minPricePrecision")]
        public decimal MinPricePrecision { get; }
        [JsonProperty("maxTradeQty")]
        public decimal MaxTradeQty { get; }
        [JsonProperty("maxTradeAmt")]
        public decimal MaxTradeAmt { get; }
        [JsonProperty("category")]
        public int Category { get; }
    }
}
