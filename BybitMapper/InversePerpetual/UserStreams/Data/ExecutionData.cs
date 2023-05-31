using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.UserStreams.Data
{
    public sealed class ExecutionData
    {
        [JsonConstructor]
        public ExecutionData(string symbol, string side, string orderId, string execId, string orderLinkId, decimal price, decimal orderQty, string execType, decimal execQty, decimal execFee, decimal leavesQty, bool isMaker, DateTime? tradeTime)
        {
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            OrderId = orderId;
            ExecId = execId;
            OrderLinkId = orderLinkId;
            Price = price;
            OrderQty = orderQty;
            ExecType = execType;
            ExecTypeEnum = ExecType.ToEnum<ExecType>();
            ExecQty = execQty;
            ExecFee = execFee;
            LeavesQty = leavesQty;
            IsMaker = isMaker;
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
        public string ExecType { get; }
        public ExecType ExecTypeEnum { get; }
        [JsonProperty("exec_qty")]
        public decimal ExecQty { get; }
        [JsonProperty("exec_fee")]
        public decimal ExecFee { get; }
        [JsonProperty("leaves_qty")]
        public decimal LeavesQty { get; }
        [JsonProperty("is_maker")]
        public bool IsMaker { get; }
        [JsonProperty("trade_time")]
        public DateTime? TradeTime { get; }
        
    }
}
