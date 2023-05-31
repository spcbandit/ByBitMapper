using BybitMapper.Extensions;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Perpetual.MarketStreams.Data.Object
{
    /// <summary>
    /// Коллекция объектов OrderBookL2SnapshotData
    /// </summary>
    public sealed class OrderBookL2Data
    {
        [JsonConstructor]
        public OrderBookL2Data(decimal price, string symbol, string id, string side, decimal? size)
        {
            Price = price;
            Symbol = symbol;
            Id = id;
            Side = side;
            SideType = Side.ToEnum<SideType>();
            Size = size;
        }

        [JsonProperty("price")]
        public decimal Price { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("id")]
        public string Id { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public SideType SideType { get; }
        [CanBeNull, JsonProperty("size")]
        public decimal? Size { get; }
    }
}
