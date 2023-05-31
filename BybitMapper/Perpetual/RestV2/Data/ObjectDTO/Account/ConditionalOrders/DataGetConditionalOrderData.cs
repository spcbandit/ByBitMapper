using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ConditionalOrders
{
    public sealed class DataGetConditionalOrderData
    {
        [JsonConstructor]
        public DataGetConditionalOrderData(string orderId, string userId, string symbol, 
            string side, string type, decimal price,
             decimal qty, string timeInForce,  string orderStatus, 
             decimal basePrice, string triggeBy, decimal triggerPrice, string orderLinkId, bool reduceOnly, bool closeOnTrigger,
             DateTime? createdTime, DateTime? updatedTime, string tpTriggerBy, string slTriggerBy, decimal takeProfit, decimal stopLoss)
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
            TPTriggeByType = TpTriggerBy.ToEnum<TriggerPriceType>();
            SlTriggerBy = slTriggerBy;
            SLTriggeByType = SlTriggerBy.ToEnum<TriggerPriceType>();
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
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
        public TriggerPriceType TPTriggeByType { get; }
        [JsonProperty("sl_trigger_by")]
        public string SlTriggerBy { get; }
        public TriggerPriceType SLTriggeByType { get; }

        [JsonProperty("take_profit")]
        public decimal TakeProfit { get; }
        [JsonProperty("stop_loss")]
        public decimal StopLoss { get; }
    }
}
