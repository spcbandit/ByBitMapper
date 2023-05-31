using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position
{
    
    public sealed class DataUserTradeRecordsData
    {
        public DataUserTradeRecordsData(string orderId, string orderLinkId, string side, string symbol, string execId, decimal price, 
            decimal orderPrice, decimal orderQty, string order, decimal feeRate, decimal execPrice, string exec, decimal execQty, 
            decimal execFee, decimal execValue, decimal leaveQty, decimal closedSize, string lastLiqInd, long tradeTime, long tradeTimeMs)
        {
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Symbol = symbol;
            ExecId = execId;
            Price = price;
            OrderPrice = orderPrice;
            OrderQty = orderQty;
            Order = order;
            OrderType = Order.ToEnum<OrderType>();
            FeeRate = feeRate;
            ExecPrice = execPrice;
            Exec = exec;
            ExecType = Exec.ToEnum<ExecType>();
            ExecQty = execQty;
            ExecFee = execFee;
            ExecValue = execValue;
            LeaveQty = leaveQty;
            ClosedSize = closedSize;
            LastLiqInd = lastLiqInd;
            LiquidityType = LastLiqInd.ToEnum<LiquidityType>();
            TradeTime = tradeTime;
            TradeTimeMs = tradeTimeMs;
        }

        [JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("exec_id")]
        public string ExecId { get; }
        [JsonProperty("price")]
        public decimal Price { get; }
        [JsonProperty("order_price")]
        public decimal OrderPrice { get; }
        [JsonProperty("order_qty")]
        public decimal OrderQty { get; }
        [JsonProperty("order_type")]
        public string Order { get; }
        public OrderType OrderType { get; }
        [JsonProperty("fee_rate")]
        public decimal FeeRate { get; }
        [JsonProperty("exec_price")]
        public decimal ExecPrice { get; }
        [JsonProperty("exec_type")]
        public string Exec { get; }
        public ExecType ExecType { get; }
        [JsonProperty("exec_qty")]
        public decimal ExecQty { get; }
        [JsonProperty("exec_fee")]
        public decimal ExecFee { get; }
        [JsonProperty("exec_value")]
        public decimal ExecValue { get; }
        [JsonProperty("leaves_qty")]
        public decimal LeaveQty { get; }
        [JsonProperty("closed_size")]
        public decimal ClosedSize { get; }
        [JsonProperty("last_liquidity_ind")]
        public string LastLiqInd { get; }
        public LiquidityType LiquidityType { get; }
        [JsonProperty("trade_time")]
        public long TradeTime { get; }
        [JsonProperty("trade_time_ms")]
        public long TradeTimeMs { get; }
    }
}
