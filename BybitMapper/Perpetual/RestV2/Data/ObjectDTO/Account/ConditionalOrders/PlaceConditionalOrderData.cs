using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ConditionalOrders
{
    public sealed class PlaceConditionalOrderData
    {
        [JsonConstructor]
        public PlaceConditionalOrderData(string orderId, string userId, string symbol, string side, string type, decimal price, 
            decimal qty, string timeInForce, TimeInForceType timeInForceType, string orderStatus, OrderStatusType orderStatusType, 
            decimal basePrice, string triggeBy, decimal triggerPrice, string orderLinkId, bool reduceOnly, bool closeOnTrigger, 
            DateTime? createdTime, DateTime? updatedTime, string tpTriggerBy, string slTriggerBy)
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
            TimeInForceType = timeInForceType;
            OrderStatus = orderStatus;
            OrderStatusType = orderStatusType;
            BasePrice = basePrice;
            TriggeBy = triggeBy;
            TriggeByType = TriggeBy.ToEnum<TriggerPriceType>();
            TriggerPrice = triggerPrice;
            OrderLinkId = orderLinkId;
            ReduceOnly = reduceOnly;
            CloseOnTrigger = closeOnTrigger;
            CreatedTime = createdTime;
            UpdatedTime = updatedTime;
            TpTriggerBy = tpTriggerBy;
            TriggeByType1 = TpTriggerBy.ToEnum<TriggerPriceType>();
            SlTriggerBy = slTriggerBy;
            TriggeByType2 = SlTriggerBy.ToEnum<TriggerPriceType>();
        }

        [JsonProperty("stop_order_id")]
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
        [JsonProperty("base_price")]
        public decimal BasePrice { get; }
        [JsonProperty("trigger_by")]
        public string TriggeBy { get; }
        public TriggerPriceType TriggeByType { get; }

        [JsonProperty("trigger_price")]
        public decimal TriggerPrice { get; }
        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [JsonProperty("reduce_only")]
        public bool ReduceOnly { get; }
        [JsonProperty("close_on_trigger")]
        public bool CloseOnTrigger { get; }
        [JsonProperty("created_time")]
        public DateTime? CreatedTime { get; }
        [JsonProperty("updated_time")]
        public DateTime? UpdatedTime { get; }
        [JsonProperty("tp_trigger_by")]
        public string TpTriggerBy { get; }
        public TriggerPriceType TriggeByType1 { get; }
        [JsonProperty("sl_trigger_by")]
        public string SlTriggerBy { get; }
        public TriggerPriceType TriggeByType2 { get; }
    }
}
