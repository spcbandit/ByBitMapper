using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV1.Data.ObjectDTO.Market
{
    /// <summary>
    /// Респонс инструмента
    /// </summary>
    public sealed class LatestInformationSymboltData
    {
        [JsonConstructor]
        public LatestInformationSymboltData(long time, string symbol, decimal bestBidPrice, decimal bestAskPrice, decimal volume, decimal quoteVolume, decimal lastPrice, decimal highPrice, 
            decimal lowPrice, decimal openPrice)
        {
            Time = time;
            Symbol = symbol;
            BestBidPrice = bestBidPrice;
            BestAskPrice = bestAskPrice;
            Volume = volume;
            QuoteVolume = quoteVolume;
            LastPrice = lastPrice;
            HighPrice = highPrice;
            LowPrice = lowPrice;
            OpenPrice = openPrice;
        }

        [JsonProperty("time")]
        public long Time { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("bestBidPrice")]
        public decimal BestBidPrice { get; set; }
        [JsonProperty("bestAskPrice")]
        public decimal BestAskPrice { get; set; }
        [JsonProperty("volume")]
        public decimal Volume { get; set; }
        [JsonProperty("quoteVolume")]
        public decimal QuoteVolume { get; set; }
        [JsonProperty("lastPrice")]
        public decimal LastPrice { get; set; }
        [JsonProperty("highPrice")]
        public decimal HighPrice { get; set; }
        [JsonProperty("lowPrice")]
        public decimal LowPrice { get; set; }
        [JsonProperty("openPrice")]
        public decimal OpenPrice { get; set; }
    }
}
