using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ActiveOrders
{
    public sealed class PlaceActiveOrderData
    {
        [JsonConstructor]
        public PlaceActiveOrderData(string orderId, string userId, string symbol, string side, string type, decimal price, 
            decimal qty, string timeInForce, string orderStatus, string lastExecPrice, decimal cumExecQty, decimal cumExecValue, 
            decimal cumExecFee, bool reduceOnly, bool closeOnTrigger, string orderLinkId, DateTime? createdAt, DateTime? updatedAt)
        {
            OrderId = orderId;
            UserId = userId;
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
            LastExecPrice = lastExecPrice;
            CumExecQty = cumExecQty;
            CumExecValue = cumExecValue;
            CumExecFee = cumExecFee;
            ReduceOnly = reduceOnly;
            CloseOnTrigger = closeOnTrigger;
            OrderLinkId = orderLinkId;
            CreatedTime = createdAt;
            UpdatedTime = updatedAt;
        }

        [JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonProperty("user_id")]
        public string UserId { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
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
        [JsonProperty("last_exec_price")]
        public string LastExecPrice { get; }
        [JsonProperty("cum_exec_qty")]
        public decimal CumExecQty { get; }
        [JsonProperty("cum_exec_value")]
        public decimal CumExecValue { get; }
        [JsonProperty("cum_exec_fee")]
        public decimal CumExecFee { get; }
        [JsonProperty("reduce_only")]
        public bool ReduceOnly { get; }
        [JsonProperty("close_on_trigger")]
        public bool CloseOnTrigger { get; }
        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [JsonProperty("created_time")]
        public DateTime? CreatedTime { get; }
        [JsonProperty("updated_time")]
        public DateTime? UpdatedTime { get; }
    }
}
