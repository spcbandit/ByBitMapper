using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Data
{
    /// <summary>
    /// Информация об инструменте
    /// </summary>
    public class TickerInfoData
    {
        [JsonConstructor]
        public TickerInfoData(long timestamp, string symbol, decimal? closePrice, decimal? highPrice, decimal? lowPrice,
            decimal? openPrice, decimal? volume, decimal? quoteVolume, decimal? change)
        {
            Timestamp = timestamp;
            Symbol = symbol;
            ClosePrice = closePrice;
            HighPrice = highPrice;
            LowPrice = lowPrice;
            OpenPrice = openPrice;
            Volume = volume;
            QuoteVolume = quoteVolume;
            Change = change;
        }

        [JsonProperty("t")]
        public long Timestamp { get; }
        [JsonProperty("s")]
        public string Symbol { get; }
        [JsonProperty("c")]
        public decimal? ClosePrice { get; }
        [JsonProperty("h")]
        public decimal? HighPrice { get; }
        [JsonProperty("l")]
        public decimal? LowPrice { get; }
        [JsonProperty("o")]
        public decimal? OpenPrice { get; }
        [JsonProperty("v")]
        public decimal? Volume { get; }
        [JsonProperty("qv")]
        public decimal? QuoteVolume { get; }
        [JsonProperty("m")]
        public decimal? Change { get; }
    }
}
