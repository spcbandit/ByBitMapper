using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class UserTradeData
    {
        [JsonConstructor]
        public UserTradeData(decimal closedSize, decimal crossSeq, decimal execFee, string execId, decimal execPrice, decimal execQty, double execTime, string execType, decimal execValue, decimal feeRate, string lastLiquidityInd, decimal leavesQty, decimal nthFill, string orderId, string orderLinkId, decimal orderPrice, decimal orderQty, string orderType, string side, string symbol, string userId, long tradeTimeMs)
        {
            ClosedSize = closedSize;
            CrossSeq = crossSeq;
            ExecFee = execFee;
            ExecId = execId;
            ExecPrice = execPrice;
            ExecQty = execQty;
            ExecTime = execTime;
            ExecType = execType;
            ExecTypeEnum = ExecType.ToEnum<ExecType>();
            ExecValue = execValue;
            FeeRate = feeRate;
            LastLiquidityInd = lastLiquidityInd;
            LastLiquidityIndType = LastLiquidityInd.ToEnum<LiquidityType>();
            LeavesQty = leavesQty;
            NthFill = nthFill;
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            OrderPrice = orderPrice;
            OrderQty = orderQty;
            OrderType = orderType;
            if (OrderType == null)
                OrderTypeEnum = null;
            else
               OrderTypeEnum = OrderType.ToEnum<OrderType>();
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Symbol = symbol;
            UserId = userId;
            TradeTimeMs = tradeTimeMs;
        }

        [JsonRequired, JsonProperty("closed_size")]
        public decimal ClosedSize { get; }
        [JsonRequired, JsonProperty("cross_seq")]
        public decimal CrossSeq { get; }
        [JsonRequired, JsonProperty("exec_fee")]
        public decimal ExecFee { get; }
        [JsonRequired, JsonProperty("exec_id")]
        public string ExecId { get; }
        [JsonRequired, JsonProperty("exec_price")]
        public decimal ExecPrice { get; }
        [JsonRequired, JsonProperty("exec_qty")]
        public decimal ExecQty { get; }
        [JsonRequired, JsonProperty("exec_time")]
        public double ExecTime { get; }
        [JsonRequired, JsonProperty("exec_type")]
        public string ExecType { get; }
        public ExecType ExecTypeEnum { get; }
        [JsonRequired, JsonProperty("exec_value")]
        public decimal ExecValue { get; }
        [JsonRequired, JsonProperty("fee_rate")]
        public decimal FeeRate { get; }
        [JsonRequired, JsonProperty("last_liquidity_ind")]
        public string LastLiquidityInd { get; }
        public LiquidityType LastLiquidityIndType { get; }
        [JsonRequired, JsonProperty("leaves_qty")]
        public decimal LeavesQty { get; }
        [JsonRequired, JsonProperty("nth_fill")]
        public decimal NthFill { get; }
        [JsonRequired, JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonRequired, JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [JsonRequired, JsonProperty("order_price")]
        public decimal OrderPrice { get; }
        [JsonRequired, JsonProperty("order_qty")]
        public decimal OrderQty { get; }
        [CanBeNull, JsonProperty("order_type")]
        public string OrderType { get; }
        public OrderType? OrderTypeEnum { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("user_id")]
        public string UserId { get; }
        [JsonRequired, JsonProperty("trade_time_ms")]
        public long TradeTimeMs { get; }
    }
}
