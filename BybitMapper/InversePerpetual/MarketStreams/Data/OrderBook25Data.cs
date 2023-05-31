using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    public sealed class OrderBook25Data
    {
        [JsonConstructor]
        public OrderBook25Data(decimal price, string symbol, string id, string side, decimal? size)
        {
            Price = price;
            Symbol = symbol;
            Id = id;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Size = size;
        }

        [JsonRequired, JsonProperty("price")]
        public decimal Price { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("id")]
        public string Id { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [CanBeNull, JsonProperty("size")]
        public decimal? Size { get; }
    }
}
