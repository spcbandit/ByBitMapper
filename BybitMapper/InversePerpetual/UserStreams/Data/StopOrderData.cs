using System;
using System.Collections.Generic;

using JetBrains.Annotations;
using Newtonsoft.Json;

using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

// https://bybit-exchange.github.io/docs/futuresV2/inverse/#t-websocketstoporder

namespace BybitMapper.InversePerpetual.UserStreams.Data
{
    public sealed class StopOrderData
    {
        [JsonConstructor]
        public StopOrderData(string orderId, string orderLinkId, string userId, string symbol, 
            string side, string orderType, decimal? price, decimal? qty, string timeInForceType, 
            string createType, string cancelType, string orderStatus, string stopOrderType,
            string triggerBy, decimal? triggerPrice, bool closeOnTrigger, DateTime? timestamp,
            decimal? takeProfit, decimal? stopLoss)
        {
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            UserId = userId;
            Symbol = symbol;
            Side = side;
            SideType = side.ToEnum<OrderSideType>();
            OrderType = orderType;
            OrderTypeEnum = orderType.ToEnum<OrderType>();
            Price = price;
            Qty = qty;
            TimeInForceType = timeInForceType;
            TimeInForce = timeInForceType.ToEnum<TimeInForceType>();
            CreateType = createType;
            CancelType = cancelType;
            OrderStatus = orderStatus;
            OrderStatusType = orderStatus.ToEnum<StopOrderStatusType>();
            StopOrderType = stopOrderType;
            StopOrderTypeEnum = stopOrderType.ToEnum<StopOrderType>();
            TriggerBy = triggerBy;
            TriggerByEnum = triggerBy.ToEnum<TriggerPriceType>();
            TriggerPrice = triggerPrice;
            CloseOnTrigger = closeOnTrigger;
            Timestamp = timestamp;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
        }

        [JsonProperty("order_id")]
        public string OrderId { get; }

        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; }

        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }

        [JsonProperty("order_type")]
        public string OrderType { get; }
        public OrderType OrderTypeEnum { get; }

        [JsonProperty("price")]
        public decimal? Price { get; }

        [JsonProperty("qty")]
        public decimal? Qty { get; }

        [JsonProperty("time_in_force")]
        public string TimeInForceType { get; }
        public TimeInForceType TimeInForce { get; }

        [JsonProperty("create_type")]
        public string CreateType { get; }

        [JsonProperty("cancel_type")]
        public string CancelType { get; }

        [JsonProperty("order_status")]
        public string OrderStatus { get; }
        public StopOrderStatusType OrderStatusType { get; }

        [JsonProperty("stop_order_type")]
        public string StopOrderType { get; }
        public StopOrderType StopOrderTypeEnum { get; }

        [JsonProperty("trigger_by")]
        public string TriggerBy { get; }
        public TriggerPriceType TriggerByEnum { get; }

        [JsonProperty("trigger_price")]
        public decimal? TriggerPrice { get; }

        [JsonProperty("close_on_trigger")]
        public bool CloseOnTrigger { get; }

        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; }

        [JsonProperty("take_profit")]
        public decimal? TakeProfit { get; }

        [JsonProperty("stop_loss")]
        public decimal? StopLoss { get; }
    }
}
