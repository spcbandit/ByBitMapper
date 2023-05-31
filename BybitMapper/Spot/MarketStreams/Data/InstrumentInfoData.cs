using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreams.Data
{
    /// <summary>
    /// Информация об инструменте
    /// </summary>
    public class InstrumentInfoData
    {
        [JsonConstructor]
        public InstrumentInfoData(long timestamp, string symbol, string tradingPair, decimal closePrice, decimal highPrice, decimal lowPrice, decimal openPrice, decimal volume, 
            decimal quoteVolume, decimal change, int exchangeID)
        {
            Timestamp = timestamp;
            Symbol = symbol;
            TradingPair = tradingPair;
            ClosePrice = closePrice;
            HighPrice = highPrice;
            LowPrice = lowPrice;
            OpenPrice = openPrice;
            Volume = volume;
            QuoteVolume = quoteVolume;
            Change = change;
            ExchangeID = exchangeID;
        }

        [JsonProperty("t")]
        public long Timestamp { get; set; }
        [JsonProperty("s")]
        public string Symbol { get; set; }
        [JsonProperty("sn")]
        public string TradingPair { get; set; }
        [JsonProperty("c")]
        public decimal ClosePrice { get; set; }
        [JsonProperty("h")]
        public decimal HighPrice { get; set; }
        [JsonProperty("l")]
        public decimal LowPrice { get; set; }
        [JsonProperty("o")]
        public decimal OpenPrice { get; set; }
        [JsonProperty("v")]
        public decimal Volume { get; set; }
        [JsonProperty("qv")]
        public decimal QuoteVolume { get; set; }
        [JsonProperty("m")]
        public decimal Change { get; set; }
        [JsonProperty("e")]
        public int ExchangeID { get; set; }
    }
}
