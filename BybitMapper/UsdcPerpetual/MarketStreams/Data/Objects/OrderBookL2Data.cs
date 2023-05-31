using BybitMapper.Extensions;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
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
        public decimal Price { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        public SideType SideType { get; set; }
        [CanBeNull, JsonProperty("size")]
        public decimal? Size { get; set; }
    }
}
