using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Market
{
    public class LatestInformationSymbolData
    {
        /// <summary>
        /// Последняя информация о инструменте
        /// </summary>
        /// <param name="timestamp">Текущее время в миллисекундах</param>
        /// <param name="name">Название торговой пары</param>
        /// <param name="bestAskPrice">Лучший бид</param>
        /// <param name="bestBidPrice">Лучший аск</param>
        /// <param name="volume">Объем</param>
        /// <param name="quoteVolume">Объем торговой котировки</param>
        /// <param name="lastTradedPrice">Последняя торгуемая цена</param>
        /// <param name="high">Максимум</param>
        /// <param name="low">Минимум</param>
        /// <param name="open">Цена открытия</param>
        [JsonConstructor]
        public LatestInformationSymbolData(long timestamp, string name, string bestAskPrice, string bestBidPrice,
            string volume, string quoteVolume, string lastTradedPrice, string high, string low, string open)
        {
            Timestamp = timestamp;
            Name = name;
            BestBidPrice = bestBidPrice;
            BestAskPrice = bestAskPrice;
            Volume = volume;
            QuoteVolume = quoteVolume;
            LastTradedPrice = lastTradedPrice;
            High = high;
            Low = low;
            Open = open;
        }

        [JsonProperty("t")]
        public long Timestamp { get; }
        [JsonProperty("s")]
        public string Name { get; }
        [JsonProperty("bp")]
        public string BestBidPrice { get; }
        [JsonProperty("ap")]
        public string BestAskPrice { get; }
        [JsonProperty("v")]
        public string Volume { get; }
        [JsonProperty("qv")]
        public string QuoteVolume { get; }
        [JsonProperty("lp")]
        public string LastTradedPrice { get; }
        [JsonProperty("h")]
        public string High { get; }
        [JsonProperty("l")]
        public string Low { get; }
        [JsonProperty("o")]
        public string Open { get; }
    }
}
