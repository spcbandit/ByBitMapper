using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;

namespace BybitMapper.Perpetual.UserStreams.Data.Object
{
    /// <summary>
    /// WebSocket USDT Perpetual/Private StopOrder response data
    /// </summary>
    public sealed class StopOrderPerpetualData
    {
        [JsonConstructor]
        public StopOrderPerpetualData(string stopOrderId, string orderLinkId, string userId, string symbol, string side, string order, 
            decimal price, decimal qty, string timeInForce, string orderStatus, string stopOrderType, string triggerBy, decimal triggerPrice, 
            bool resuceOnly, bool closeOnTrigger, DateTime createTime, DateTime updateTime, string positionIdx)
        {
            StopOrderId = stopOrderId;
            OrderLinkId = orderLinkId;
            UserId = userId;
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Order = order;
            OrderType = Order.ToEnum<OrderType>();
            Price = price;
            Qty = qty;
            TimeInForce = timeInForce;
            TimeInForceType = TimeInForce.ToEnum<TimeInForceType>();
            OrderStatus = orderStatus;
            OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
            StopOrderType = stopOrderType;
            StopOrderTypeEnum = StopOrderType.ToEnum<StopOrderType>();
            TriggerBy = triggerBy;
            TriggerByType = TriggerBy.ToEnum<TriggerPriceType>();
            TriggerPrice = triggerPrice;
            ResuceOnly = resuceOnly;
            CloseOnTrigger = closeOnTrigger;
            CreateTime = createTime;
            UpdateTime = updateTime;
            PositionIdx = positionIdx;
        }

        [JsonProperty("stop_order_id")]
        public string StopOrderId { get; }
        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [JsonProperty("user_id")]
        public string UserId { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonProperty("order_type")]
        public string Order { get; }
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
        [JsonProperty("stop_order_type")]
        public string StopOrderType { get; }

        public StopOrderType StopOrderTypeEnum { get; }

        [JsonProperty("trigger_by")]
        public string TriggerBy { get; }
        [JsonProperty("position_idx")]
        public string PositionIdx { get; }
        public TriggerPriceType TriggerByType { get; }
        [JsonProperty("trigger_price")]
        public decimal TriggerPrice { get; }
        [JsonProperty("reduce_only")]
        public bool ResuceOnly { get; }
        [JsonProperty("close_on_trigger")]
        public bool CloseOnTrigger { get; }
        [JsonProperty("create_time")]
        public DateTime CreateTime { get; }
        [JsonProperty("update_time")]
        public DateTime UpdateTime { get; }
    }
}
