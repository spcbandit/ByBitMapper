using BybitMapper.Extensions;
using BybitMapper.Spot.UserStreams.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.UserStreams.Events
{
    public class ExecutionReportEvent
    {
        [JsonConstructor]
        public ExecutionReportEvent(string eventType, long eventTime, string tradingPair, string userGeneratedOrderId, 
            string side, string order, string timeInForce, decimal quantity, decimal price, string orderStatus, string orderId,
            long orderIdOfTheOpponent, decimal lastFilledQuantity, decimal totalFilledQuantity, double lastTradedPrice, decimal tradingFee,
            string assetTypeInWhichFeeIsPaid, bool isNormal, bool isWorking, bool isLimitMaker, ulong orderCreationTime, decimal totalFilledValue,
            long accountId, string isClose, int leverage)
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
            OrderIdOfTheOpponent = orderIdOfTheOpponent;
            LastFilledQuantity = lastFilledQuantity;
            TotalFilledQuantity = totalFilledQuantity;
            LastTradedPrice = lastTradedPrice;
            TradingFee = tradingFee;
            AssetTypeInWhichFeeIsPaid = assetTypeInWhichFeeIsPaid;
            IsNormal = isNormal;
            IsWorking = isWorking;
            IsLimitMaker = isLimitMaker;
            OrderCreationTime = orderCreationTime;
            TotalFilledValue = totalFilledValue;
            AccountId = accountId;
            IsClose = isClose;
            Leverage = leverage;
        }

        [JsonProperty("e")]
        public string EventType { get; }
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
        public decimal Quantity { get; }
        [JsonProperty("p")]
        public decimal Price { get; }
        [JsonProperty("X")]
        public string OrderStatus { get; set; }
        public OrderStatus OrderStatusEnum { get; set; }
        [JsonProperty("i")]
        public string OrderId { get; set; }
        [JsonProperty("M")]
        public long OrderIdOfTheOpponent { get; set; }
        [JsonProperty("l")]
        public decimal LastFilledQuantity { get; set; }
        [JsonProperty("z")]
        public decimal TotalFilledQuantity { get; set; }
        [JsonProperty("L")]
        public double LastTradedPrice { get; set; }
        [JsonProperty("n")]
        public decimal TradingFee { get; }
        [JsonProperty("N")]
        public string AssetTypeInWhichFeeIsPaid { get; }
        [JsonProperty("u")]
        public bool IsNormal { get; }
        [JsonProperty("w")]
        public bool IsWorking { get; }
        [JsonProperty("m")]
        public bool IsLimitMaker { get; }
        [JsonProperty("O")]
        public ulong OrderCreationTime { get; }
        [JsonProperty("Z")]
        public decimal TotalFilledValue { get; }
        [JsonProperty("A")]
        public long AccountId { get; }
        [JsonProperty("C")]
        public string IsClose { get; }
        [JsonProperty("v")]
        public int Leverage { get; }
        public DateTime? Time
        {
            get
            {
                return ((long)OrderCreationTime).ToDateTimeFromUnixTimeMilliseconds();
            }
        }
    }
}
