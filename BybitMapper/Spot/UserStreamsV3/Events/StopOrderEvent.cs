using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BybitMapper.Extensions;
using BybitMapper.Spot.UserStreamsV3.Enums;
using Newtonsoft.Json;

namespace BybitMapper.Spot.UserStreamsV3.Events
{
    public class StopOrderEvent : BaseEvent
    {

        public StopOrderEvent(string type, string topic, string ts, IReadOnlyList<StopOrderData> data) :
            base(type, topic, ts)
        {
            Data = data;
        }

        [JsonProperty("data")]
        public IReadOnlyList<StopOrderData> Data { get; }
    }

    public class StopOrderData
    {
        [JsonConstructor]
        public StopOrderData(string eventType, long eventTime, string tradingPair, string userGeneratedOrderId,
            string side, string order, string timeInForce, decimal quantity, decimal price, string orderStatus, string orderId,
           string orderCreateTime, string orderTriggerTime, string orderUpdateTime, string marketPriceOnPlace, string newOrderId)
        {
            EventType = eventType;
            EventTime = eventTime;
            TradingPair = tradingPair;
            UserGeneratedOrderId = userGeneratedOrderId;
            Side = side;
            SideType = Side.ToEnum<SideType>();
            Order = order;
            OrderEnum = Order.ToEnum<OrderType>();
            TimeInForce = timeInForce;
            TimeInForceEnum = TimeInForce.ToEnum<TimeInForceType>();
            Quantity = quantity;
            Price = price;
            OrderStatus = orderStatus;
            OrderStatusEnum = OrderStatus.ToEnum<OrderStatus>();
            OrderId = orderId;
            OrderCreateTime = orderCreateTime;
            OrderTriggerTime = orderTriggerTime;
            OrderUpdateTime = orderUpdateTime;
            MarketPriceOnPlace = marketPriceOnPlace;
            NewOrderId = newOrderId;
        }

        [JsonProperty("e")]
        public string EventType { get; set; }
        [JsonProperty("E")]
        public long EventTime { get; }
        [JsonProperty("s")]
        public string TradingPair { get; }
        [JsonProperty("c")]
        public string UserGeneratedOrderId { get; }
        [JsonProperty("S")]
        public string Side { get; }
        public SideType SideType { get; }
        [JsonProperty("o")]
        public string Order { get; }
        public OrderType OrderEnum { get; }
        [JsonProperty("f")]
        public string TimeInForce { get; }
        public TimeInForceType TimeInForceEnum { get; }
        [JsonProperty("q")]
        public decimal Quantity { get; set; }
        [JsonProperty("p")]
        public decimal Price { get; set; }
        [JsonProperty("X")]
        public string OrderStatus { get; set; }
        public OrderStatus OrderStatusEnum { get; set; }
        [JsonProperty("i")]
        public string OrderId { get; set; }
        [JsonProperty("T")]
        public string OrderCreateTime { get; set; }
        [JsonProperty("t")]
        public string OrderTriggerTime { get; set; }
        [JsonProperty("C")]
        public string OrderUpdateTime { get; set; }
        [JsonProperty("qp")]
        public string MarketPriceOnPlace { get; set; }
        [JsonProperty("eo")]
        public string NewOrderId { get; }
      
        public DateTime? Time
        {
            get
            {
                return (long.Parse(OrderCreateTime)).ToDateTimeFromUnixTimeMilliseconds();
            }
        }
    }
}
