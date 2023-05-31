using System.Collections.Generic;
using BybitMapper.Spot.RestV3.Converters;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Market
{
    public class OrderBookResultData
    {
        [JsonConstructor]
        public OrderBookResultData(long time, IReadOnlyList<OrderRaw> bids, IReadOnlyList<OrderRaw> asks)
        {
            Time = time;
            Bids = bids;
            Asks = asks;
        }

        [JsonProperty("time")]
        public long Time { get; }
        [JsonProperty("bids")]
        public IReadOnlyList<OrderRaw> Bids { get; }
        [JsonProperty("asks")]
        public IReadOnlyList<OrderRaw> Asks { get; }
    }

    [JsonConverter(typeof(OrderBookConverter))]
    public class OrderRaw
    {
        public OrderRaw(decimal price, decimal size)
        {
            Price = price;
            Size = size;
        }

        public decimal Price { get; }
        public decimal Size { get; }
    }
}
