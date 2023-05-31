using System;
using BybitMapper.Extensions;
using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Data
{
    public class TradeData
    {
        [JsonConstructor]
        public TradeData(string tradeId, long timestamp, decimal price, decimal quantity, bool? trueIndicates, string type)
        {
            TradeId = tradeId;
            Timestamp = timestamp;
            Price = price;
            Quantity = quantity;
            TrueIndicates = trueIndicates;
            Type = type;
        }

        [JsonProperty("v")]
        public string TradeId { get; }
        [JsonProperty("t")]
        public long Timestamp { get; }
        [JsonProperty("p")]
        public decimal Price { get; }
        [JsonProperty("q")]
        public decimal Quantity { get; }
        [JsonProperty("m")]
        public bool? TrueIndicates { get; }
        [JsonProperty("type")]
        public string Type { get; }
        public DateTime? Time
        {
            get
            {
                return ((long)Timestamp).ToDateTimeFromUnixTimeMilliseconds();
            }
        }
    }
}
