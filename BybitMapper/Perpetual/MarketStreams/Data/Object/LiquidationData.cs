using BybitMapper.Extensions;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.MarketStreams.Data.Object
{
    /// <summary>
    /// Коллекция объектов LiquidationData
    /// </summary>
    public class LiquidationData
    {
        public LiquidationData(string symbol, string side, decimal price, decimal qty, long time)
        {
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<SideType>();
            Price = price;
            Qty = qty;
            Time = time;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public SideType SideType { get; }
        [JsonProperty("price")]
        public decimal Price { get; }
        [JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonProperty("time")]
        public long Time { get; }
    }
}
