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
    public sealed class CancelOrderData
    {
        [JsonConstructor]
        public CancelOrderData(string userId, string orderId, string symbol, string side, string type, decimal price, decimal qty,
            string timeInForce, string orderStatus, double lastExecTime, double lastExecPrice, decimal leavesQty, decimal cumExecQty, decimal cumExecValue, decimal cumExecFee, string rejectReason, string orderLinkId, DateTime? createdAt, DateTime? updatedAt)
        {
            UserId = userId;
            OrderId = orderId;
            Symbol = symbol;
            Side = side;
            OrderSide = Side.ToEnum<OrderSideType>();
            Type = type;
            OrderType = Type.ToEnum<OrderType>();
            Price = price;
            Qty = qty;
            TimeInForce = timeInForce;
            TimeInForceType = TimeInForce.ToEnum<TimeInForceType>();
            OrderStatus = orderStatus;
            OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
            LastExecTime = lastExecTime;
            LastExecPrice = lastExecPrice;
            LeavesQty = leavesQty;
            CumExecQty = cumExecQty;
            CumExecValue = cumExecValue;
            CumExecFee = cumExecFee;
            RejectReason = rejectReason;
            OrderLinkId = orderLinkId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        [JsonProperty("user_id")]
        public string UserId { get; }
        [JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType OrderSide { get; }
        [JsonProperty("order_type")]
        public string Type { get; }
        public OrderType OrderType { get; }
        [JsonProperty("price")]
        public decimal Price { get; }
        [JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonProperty("time_in_force")]
        public string TimeInForce { get; }
        public TimeInForceType TimeInForceType { get; }
        [JsonProperty("order_status")]
        public string OrderStatus { get; }
        public OrderStatusType OrderStatusType { get; }
        [JsonProperty("last_exec_time")]
        public double LastExecTime { get; }
        [JsonProperty("last_exec_price")]
        public double LastExecPrice { get; }
        [JsonProperty("leaves_qty")]
        public decimal LeavesQty { get; }
        [JsonProperty("cum_exec_qty")]
        public decimal CumExecQty { get; }
        [JsonProperty("cum_exec_value")]
        public decimal CumExecValue { get; }
        [JsonProperty("cum_exec_fee")]
        public decimal CumExecFee { get; }
        [JsonProperty("reject_reason")]
        public string RejectReason { get; }
        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [CanBeNull, JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }
        [CanBeNull, JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; }


    }
}
