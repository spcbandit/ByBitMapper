using System.Collections.Generic;
using BybitMapper.Spot.MarketStreamsV3.Convertors;
using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Data
{
    public class DepthData
    {
        [JsonConstructor]
        public DepthData(string tradingPair, long timestamp,  IReadOnlyList<DeptBidAsk> bid, IReadOnlyList<DeptBidAsk> ask)
        {
            TradingPair = tradingPair;
            Timestamp = timestamp;
            Bid = bid;
            Ask = ask;
        }

        [JsonProperty("s")]
        public string TradingPair { get; }
        [JsonProperty("t")]
        public long Timestamp { get; }
        [JsonProperty("b")]
        public IReadOnlyList<DeptBidAsk> Bid { get; }
        [JsonProperty("a")]
        public IReadOnlyList<DeptBidAsk> Ask { get; }
    }

    [JsonConverter(typeof(DepthDataJsonConverterV3))]
    public class DeptBidAsk
    {
        public DeptBidAsk(decimal price, decimal quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public decimal Price { get; }
        public decimal Quantity { get; }
    }
}
