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
    public sealed class PlaceOrderData
    {
        [JsonConstructor]
        public PlaceOrderData(string userId, string orderId, string symbol, string side, string type, decimal price, decimal qty, string timeInForce, string orderStatus, string lastExecTime, string lastExecPrice, decimal leavesQty, decimal cumExecQty, decimal cumExecValue, decimal cumExecFee, string rejectReason, string orderLinkId, DateTime? createdAt, DateTime? updatedAt)
        {
            UserId = userId;
            OrderId = orderId;
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
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
        [JsonRequired, JsonProperty("user_id")]
        public string UserId { get; }
        [JsonRequired, JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonRequired, JsonProperty("order_type")]
        public string Type { get; }
        public OrderType OrderType { get; }
        [JsonRequired, JsonProperty("price")]
        public decimal Price { get; }
        [JsonRequired, JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonRequired, JsonProperty("time_in_force")]
        public string TimeInForce { get; }
        public TimeInForceType TimeInForceType { get; }
        [JsonRequired, JsonProperty("order_status")]
        public string OrderStatus { get; }
        public OrderStatusType OrderStatusType { get; }
        [JsonRequired, JsonProperty("last_exec_time")]
        public string LastExecTime { get; }
        [JsonRequired, JsonProperty("last_exec_price")]
        public string LastExecPrice { get; }
        [JsonRequired, JsonProperty("leaves_qty")]
        public decimal LeavesQty { get; }
        [JsonRequired, JsonProperty("cum_exec_qty")]
        public decimal CumExecQty { get; }
        [JsonRequired, JsonProperty("cum_exec_value")]
        public decimal CumExecValue { get; }
        [JsonRequired, JsonProperty("cum_exec_fee")]
        public decimal CumExecFee { get; }
        [JsonRequired, JsonProperty("reject_reason")]
        public string RejectReason { get; }
        [JsonRequired, JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [CanBeNull, JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }
        [CanBeNull, JsonProperty("update_at")]
        public DateTime? UpdatedAt { get; }
    }
}
