using BybitMapper.Extensions;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class LiquidatedOrderData
    {
        [JsonConstructor]
        public LiquidatedOrderData(decimal id, decimal qty, string side, decimal time, string symbol, decimal price)
        {
            Id = id;
            Qty = qty;
            Side = side;
            OrderSide = Side.ToEnum<OrderSideType>();
            Time = time;
            Symbol = symbol;
            Price = price;
        }

        [JsonRequired, JsonProperty("id")]
        public decimal Id { get; }
        [JsonRequired, JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType OrderSide { get; }
        [JsonRequired, JsonProperty("time")]
        public decimal Time { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("price")]
        public decimal Price { get; }
    }
}
