using BybitMapper.Spot.RestV1.Convertors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Data.ObjectDTO.Market
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
    [JsonConverter(typeof(OrderBookConvertor))]
    public class OrderRaw
    {
        public OrderRaw(decimal price, decimal size)
        {
            Price = price;
            Size = size;
        }

        public decimal Price { get; set; }
        public decimal Size { get; set; }
    }
}
