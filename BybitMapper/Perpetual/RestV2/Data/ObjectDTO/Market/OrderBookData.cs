using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using Newtonsoft.Json;


namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class OrderBookData
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

        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("price")]
        public decimal Price { get; }
        [JsonProperty("size")]
        public decimal Size { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType OrderSide { get; }
    }
}
