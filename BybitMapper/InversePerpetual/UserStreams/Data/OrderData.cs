using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.UserStreams.Data
{
    public sealed class OrderData
    {
        [JsonConstructor]
        public OrderData(string orderId, string orderLinkId, string symbol, string side, string orderType, decimal price, decimal qty,
            string timeInForceType, string createType, string cancelType, string orderStatus,
            decimal leavesQty, decimal cumExecQty, decimal cumExecValue, decimal cumExecFee, DateTime? timestamp,
            decimal takeProfit, decimal stopLoss, decimal trailingStop, decimal trailingActive, decimal lastExecPrice)
        {
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            OrderType = orderType;
            OrderTypeEnum = OrderType.ToEnum<OrderType>();
            Price = price;
            Qty = qty;
            TimeInForceType = timeInForceType;
            TimeInForce = TimeInForceType.ToEnum<TimeInForceType>();
            CreateType = createType;
            CancelType = cancelType;
            OrderStatus = orderStatus;
            OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
            LeavesQty = leavesQty;
            CumExecQty = cumExecQty;
            CumExecValue = cumExecValue;
            CumExecFee = cumExecFee;
            Timestamp = timestamp;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            TrailingStop = trailingStop;
            TrailingActive = trailingActive;
            LastExecPrice = lastExecPrice;
        }

        [JsonRequired, JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonRequired, JsonProperty("order_link_id")]
        public string OrderLinkId { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonRequired, JsonProperty("order_type")]
        public string OrderType { get; }
        public OrderType OrderTypeEnum { get; }
        [JsonRequired, JsonProperty("price")]
        public decimal Price { get; }
        [JsonRequired, JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonRequired, JsonProperty("time_in_force")]
        public string TimeInForceType { get; }
        public TimeInForceType TimeInForce { get; }
        [JsonRequired, JsonProperty("create_type")]
        public string CreateType { get; }
        [JsonRequired, JsonProperty("cancel_type")]
        public string CancelType { get; }
        [JsonRequired, JsonProperty("order_status")]
        public string OrderStatus { get; }
        public OrderStatusType OrderStatusType { get; }
        [JsonRequired, JsonProperty("leaves_qty")]
        public decimal LeavesQty { get; }
        [JsonRequired, JsonProperty("cum_exec_qty")]
        public decimal CumExecQty { get; }
        [JsonRequired, JsonProperty("cum_exec_value")]
        public decimal CumExecValue { get; }
        [JsonRequired, JsonProperty("cum_exec_fee")]
        public decimal CumExecFee { get; }
        [JsonRequired, JsonProperty("timestamp")]
        public DateTime? Timestamp { get; }
        [JsonRequired, JsonProperty("take_profit")]
        public decimal TakeProfit { get; }
        [JsonRequired, JsonProperty("stop_loss")]
        public decimal StopLoss { get; }
        [JsonRequired, JsonProperty("trailing_stop")]
        public decimal TrailingStop { get; }
        [CanBeNull, JsonProperty("trailing_active")]
        public decimal TrailingActive { get; }
        [JsonRequired, JsonProperty("last_exec_price")]
        public decimal LastExecPrice { get; }
    }
}
