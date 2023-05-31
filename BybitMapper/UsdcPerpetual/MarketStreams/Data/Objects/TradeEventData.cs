using BybitMapper.Extensions;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

using JetBrains.Annotations;
using Newtonsoft.Json;

using System;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class TradeEventData
    {
        [JsonConstructor]
        public TradeEventData(string symbol, string tickDirection, decimal price, decimal size, DateTime? timestamp,
            long tradeTimeMs, string side, string tradeId)
        {
            Symbol = symbol;
            TickDirection = tickDirection;
            TickDirectionType = TickDirection.ToEnum<TickDirectionType>();
            Price = price;
            Size = size;
            Timestamp = timestamp;
            TradeTimeMs = tradeTimeMs;
            Side = side;
            SideType = Side.ToEnum<SideType>();
            TradeId = tradeId;
        }

        [CanBeNull, JsonProperty("symbol")]
        public string Symbol { get; set; }
        [CanBeNull, JsonProperty("tick_direction")]
        public string TickDirection { get; set; }
        public TickDirectionType TickDirectionType { get; }
        [CanBeNull, JsonProperty("price")]
        public decimal Price { get; set; }
        [CanBeNull, JsonProperty("size")]
        public decimal Size { get; set; }
        [CanBeNull, JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }
        [CanBeNull, JsonProperty("trade_time_ms")]
        public long TradeTimeMs { get; set; }
        [CanBeNull, JsonProperty("side")]
        public string Side { get; set; }
        public SideType SideType { get; set; }
        [CanBeNull, JsonProperty("trade_id")]
        public string TradeId { get; set; }

    }
}