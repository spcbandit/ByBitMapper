using BybitMapper.Extensions;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;

using JetBrains.Annotations;
using Newtonsoft.Json;

using System;

namespace BybitMapper.Perpetual.MarketStreams.Data.Object
{
    /// <summary>
    /// Коллекция объектов TradeDate
    /// </summary>
    public sealed class TradeDate
    { 
        [JsonConstructor]
        public TradeDate(string symbol, string tickDirection, decimal price, decimal size, DateTime? timestamp, 
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
        public string Symbol { get; }
        [CanBeNull, JsonProperty("tick_direction")]
        public string TickDirection { get; }
        public TickDirectionType TickDirectionType { get; }
        [CanBeNull, JsonProperty("price")]
        public decimal Price { get; }

        [CanBeNull, JsonProperty("size")]
        public decimal Size { get; }
        [CanBeNull, JsonProperty("timestamp")]
        public DateTime? Timestamp { get; }
        [CanBeNull, JsonProperty("trade_time_ms")]
        public long TradeTimeMs { get; }
        [CanBeNull, JsonProperty("side")]
        public string Side { get; }
        public SideType SideType { get; }
        [CanBeNull, JsonProperty("trade_id")]
        public string TradeId { get; }
    }
}
