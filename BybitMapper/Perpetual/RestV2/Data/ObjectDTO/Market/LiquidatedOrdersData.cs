using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class LiquidatedOrdersData
    {
        [JsonConstructor]
        public LiquidatedOrdersData(decimal id, decimal qty, string side, decimal time, string symbol, decimal price)
        {
            Id = id;
            Qty = qty;
            Side = side;
            OrderSide = Side.ToEnum<OrderSideType>();
            Time = time;
            Symbol = symbol;
            Price = price;
        }

        [JsonProperty("id")]
        public decimal Id { get; }
        [JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType OrderSide { get; }
        [JsonProperty("time")]
        public decimal Time { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("price")]
        public decimal Price { get; }
    }
}
