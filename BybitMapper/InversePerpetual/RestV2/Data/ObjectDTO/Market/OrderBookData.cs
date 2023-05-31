using BybitMapper.Extensions;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market
{
    public class OrderBookData
    {
        [JsonConstructor]
        public OrderBookData(string symbol, decimal price, decimal size, string side)
        {
            Symbol = symbol;
            Price = price;
            Size = size;
            Side = side;
            OrderSide = Side.ToEnum<OrderSideType>();
        }

        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("price")]
        public decimal Price { get; }
        [JsonRequired, JsonProperty("size")]
        public decimal Size { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType OrderSide { get; }
    }
}
