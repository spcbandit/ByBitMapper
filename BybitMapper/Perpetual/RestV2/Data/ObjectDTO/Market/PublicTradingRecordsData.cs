using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;
using System;


namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class PublicTradingRecordsData
    {
        [JsonConstructor]
        public PublicTradingRecordsData(long id, string symbol, decimal price, decimal qty, string side, DateTime? time, long tradeTimeMs)
        {
            Id = id;
            Symbol = symbol;
            Price = price;
            Qty = qty;
            Side = side;
            OrderSide = Side.ToEnum<OrderSideType>();
            Time = time;
            TradeTimeMs = tradeTimeMs;
        }

        [JsonProperty("id")]
        public long Id { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("price")]
        public decimal Price { get; }
        [JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType OrderSide { get; }
        [JsonProperty("time")]
        public DateTime? Time { get; }
        [JsonProperty("trade_time_ms")]
        public long TradeTimeMs { get; }
    }
}
