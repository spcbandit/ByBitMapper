using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class OrderBookL2EventData
    {
        [JsonConstructor]
        public OrderBookL2EventData(string price, string symbol, string side, int size)
        {
            Price = price;
            Symbol = symbol;
            Side = side;
            Size = size;
        }
        [CanBeNull, JsonProperty("price")]
        public string Price { get; }
        [CanBeNull, JsonProperty("symbol")]
        public string Symbol { get; }
        [CanBeNull, JsonProperty("side")]
        public string Side { get; }
        [CanBeNull, JsonProperty("size")]
        public int Size { get; }

    }
}