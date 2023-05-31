using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;

namespace BybitMapper.Perpetual.UserStreams.Data.Object
{
    /// <summary>
    /// WebSocket USDT Perpetual/Private Order response data
    /// </summary>
    public sealed class OrderPerpetualData
    {
        [JsonConstructor]
        public OrderPerpetualData(string orderId, string orderLinkId, string symbol, string side, string order, decimal price, decimal qty, 
            decimal leavesQty, decimal lastExecPrice, decimal cumExecQty, decimal cumExecValue, decimal cumExecFee, string timeInForce, 
            string orderStatus, decimal takeProfit, decimal stopLoss, decimal trailingStop, bool resuceOnly, bool closeOnTrigger, DateTime? createTime, 
            DateTime? updateTime)
        {
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Order = order;
            OrderType = Order.ToEnum<OrderType>();
            Price = price;
            Qty = qty;
            LeavesQty = leavesQty;
            LastExecPrice = lastExecPrice;
            CumExecQty = cumExecQty;
            CumExecValue = cumExecValue;
            CumExecFee = cumExecFee;
            TimeInForce = timeInForce;
            TimeInForceType = TimeInForce.ToEnum<TimeInForceType>();
            OrderStatus = orderStatus;
            OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            TrailingStop = trailingStop;
            ResuceOnly = resuceOnly;
            CloseOnTrigger = closeOnTrigger;
            CreateTime = createTime;
            UpdateTime = updateTime;
        }

        [JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
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
        [JsonProperty("leaves_qty")]
        public decimal LeavesQty { get; }
        [JsonProperty("last_exec_price")]
        public decimal LastExecPrice { get; }
        [JsonProperty("cum_exec_qty")]
        public decimal CumExecQty { get; }
        [JsonProperty("cum_exec_value")]
        public decimal CumExecValue { get; }
        [JsonProperty("cum_exec_fee")]
        public decimal CumExecFee { get; }
        [JsonProperty("time_in_force")]
        public string TimeInForce { get; }
        public TimeInForceType TimeInForceType { get; }
        [JsonProperty("order_status")]
        public string OrderStatus { get; }
        public OrderStatusType OrderStatusType { get; }

        [JsonProperty("take_profit")]
        public decimal TakeProfit { get; }
        [JsonProperty("stop_loss")]
        public decimal StopLoss { get; }
        [JsonProperty("trailing_stop")]
        public decimal TrailingStop { get; }
        [JsonProperty("reduce_only")]
        public bool ResuceOnly { get; }
        [JsonProperty("close_on_trigger")]
        public bool CloseOnTrigger { get; }
        [JsonProperty("create_time")]
        public DateTime? CreateTime { get; }
        [JsonProperty("update_time")]
        public DateTime? UpdateTime { get; }
    }
}
