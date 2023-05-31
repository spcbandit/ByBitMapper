using Newtonsoft.Json;

using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using BybitMapper.Extensions;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    /// <summary>
    /// Информация о выставленном ордере
    /// </summary>
    public sealed class PlaceOrderData
    {
        [JsonConstructor]
        public PlaceOrderData(string orderId, string orderLinkId, string symbol, decimal orderPrice, decimal orderQty, string orderType, string side, 
            bool mmp, string iv, string timeInForce, string orderStatus, long createdAt, decimal basePrice, decimal triggerPrice, decimal takeProfit, 
            decimal stopLoss, string slTriggerBy, string tpTriggerBy)
        {
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            Symbol = symbol;
            OrderPrice = orderPrice;
            OrderQty = orderQty;
            Order = orderType;
            OrderType = Order.ToEnum<OrderType>();
            Side = side;
            SideType = Side.ToEnum<SideType>();
            Mmp = mmp;
            Iv = iv;
            TimeInForce = timeInForce;
            TimeInForceType = TimeInForce.ToEnum<TimeInForceType>();
            OrderStatus = orderStatus;
            OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
            CreatedAt = createdAt;
            BasePrice = basePrice;
            TriggerPrice = triggerPrice;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            SlTriggerBy = slTriggerBy;
            SlTriggerByType = SlTriggerBy.ToEnum<TriggerByType>();
            TpTriggerBy = tpTriggerBy;
            TpTriggerByType = TpTriggerBy.ToEnum<TriggerByType>();
        }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }
        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("orderPrice")]
        public decimal OrderPrice { get; set; }
        [JsonProperty("orderQty")]
        public decimal OrderQty { get; set; }
        [JsonProperty("orderType")]
        public string Order { get; set; }
        public OrderType OrderType { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        public SideType SideType { get; set; }
        [JsonProperty("mmp")]
        public bool Mmp { get; set; }
        [JsonProperty("iv")]
        public string Iv { get; set; }
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }
        public TimeInForceType TimeInForceType { get; set; }
        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }
        public OrderStatusType OrderStatusType { get; set; }
        [JsonProperty("createdAt")]
        public long CreatedAt { get; set; }
        [JsonProperty("basePrice")]
        public decimal BasePrice { get; set; }
        [JsonProperty("triggerPrice")]
        public decimal TriggerPrice { get; set; }
        [JsonProperty("takeProfit")]
        public decimal TakeProfit { get; set; }
        [JsonProperty("stopLoss")]
        public decimal StopLoss { get; set; }
        [JsonProperty("slTriggerBy")]
        public string SlTriggerBy { get; set; }
        public TriggerByType SlTriggerByType { get; set; }
        [JsonProperty("tpTriggerBy")]
        public string TpTriggerBy { get; set; }
        public TriggerByType TpTriggerByType { get; set; }
    }
}