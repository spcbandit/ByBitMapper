using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;

namespace BybitMapper.Perpetual.UserStreams.Data.Object
{
    /// <summary>
    /// WebSocket USDT Perpetual/Private Execution response data
    /// </summary>
    public sealed class ExecutionEventData
    {
        [JsonConstructor]
        public ExecutionEventData(string symbol, string side, string orderId, string execId, string orderLinkId, decimal price, 
            decimal orderQty, string exec, decimal execQty, decimal execFee, decimal leavesQty, bool isMarker, DateTime? tradeTime)
        {
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            OrderId = orderId;
            ExecId = execId;
            OrderLinkId = orderLinkId;
            Price = price;
            OrderQty = orderQty;
            Exec = exec;
            ExecType = Exec.ToEnum<ExecType>();
            ExecQty = execQty;
            ExecFee = execFee;
            LeavesQty = leavesQty;
            IsMarker = isMarker;
            TradeTime = tradeTime;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonProperty("exec_id")]
        public string ExecId { get; }
        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [JsonProperty("price")]
        public decimal Price { get; }
        [JsonProperty("order_qty")]
        public decimal OrderQty { get; }
        [JsonProperty("exec_type")]
        public string Exec { get; }
        public ExecType ExecType { get; }
        [JsonProperty("exec_qty")]
        public decimal ExecQty { get; }
        [JsonProperty("exec_fee")]
        public decimal ExecFee { get; }
        [JsonProperty("leaves_qty")]
        public decimal LeavesQty { get; }
        [JsonProperty("is_maker")]
        public bool IsMarker { get; }
        [JsonProperty("trade_time")]
        public DateTime? TradeTime { get; }
    }
}
