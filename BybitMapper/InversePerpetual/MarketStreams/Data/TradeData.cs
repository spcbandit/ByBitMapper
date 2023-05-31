using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
   public sealed class TradeData
    {
        [JsonConstructor]
        public TradeData(DateTime? timestamp, long tradTimeMs, string symbol, string side, decimal size, decimal price, string tickDirection, string tradeId, string crossSeq)
        {
            Timestamp = timestamp;
            TradTimeMs = tradTimeMs;
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Size = size;
            Price = price;
            TickDirection = tickDirection;
            TickDirectionType = TickDirection.ToEnum<TickDirectionType>();
            TradeId = tradeId;
            CrossSeq = crossSeq;
        }

        [JsonRequired, JsonProperty("timestamp")]
        public DateTime? Timestamp { get; }
        [JsonRequired, JsonProperty("trade_time_ms")]
        public long TradTimeMs { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonRequired, JsonProperty("size")]
        public decimal Size { get; }
        [JsonRequired, JsonProperty("price")]
        public decimal Price { get; }
        [JsonRequired, JsonProperty("tick_direction")]
        public string TickDirection { get; }
        public TickDirectionType TickDirectionType { get; }
        [JsonRequired, JsonProperty("trade_id")]
        public string TradeId { get; }
        [JsonRequired, JsonProperty("cross_seq")]
        public string CrossSeq { get; }
    }
}
