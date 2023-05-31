using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    public sealed class QueryUnfilledData
    {
        [JsonConstructor]
        public QueryUnfilledData(string orderId, string orderLinkId, string symbol, OrderType orderType, SideType side,
            string qty, string price, TimeInForceType timeInForce, string cumExecQty, string cumExecValue, string cumExecFee,
            string orderIM, OrderStatusType orderStatus, string takeProfit, string stopLoss, string tpTriggerBy,
            string slTriggerBy, string lastExecPrice, string basePrice, string triggerPrice, string triggerBy,
            bool reduceOnly, string stopOrderType, string closeOnTrigger, int createdAt)
        {
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            Symbol = symbol;
            OrderType = orderType;
            Side = side;
            Qty = qty;
            Price = price;
            TimeInForce = timeInForce;
            CumExecQty = cumExecQty;
            CumExecValue = cumExecValue;
            CumExecFee = cumExecFee;
            OrderIM = orderIM;
            OrderStatus = orderStatus;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            TpTriggerBy = tpTriggerBy;
            SlTriggerBy = slTriggerBy;
            LastExecPrice = lastExecPrice;
            BasePrice = basePrice;
            TriggerPrice = triggerPrice;
            TriggerBy = triggerBy;
            ReduceOnly = reduceOnly;
            StopOrderType = stopOrderType;
            CloseOnTrigger = closeOnTrigger;
            CreatedAt = createdAt;
        }
        
        [JsonRequired, JsonProperty("")]
        public string OrderId { get; }
        [JsonRequired, JsonProperty("")]
        public string OrderLinkId { get; }
        [JsonRequired, JsonProperty("")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("")]
        public OrderType OrderType { get; }
        [JsonRequired, JsonProperty("")]
        public SideType Side { get; }
        
        [JsonRequired, JsonProperty("qty")]
        public string Qty { get; }
        [JsonRequired, JsonProperty("price")]
        public string Price { get; }
        [JsonRequired, JsonProperty("timeInForce")]
        public TimeInForceType TimeInForce { get; }
        [JsonRequired, JsonProperty("cumExecQty")]
        public string CumExecQty { get; }
        [JsonRequired, JsonProperty("cumExecValue")]
        public string CumExecValue { get; }
        [JsonRequired, JsonProperty("cumExecFee")]
        public string CumExecFee { get; }
        [JsonRequired, JsonProperty("orderIM")]
        public string OrderIM { get; }
        [JsonRequired, JsonProperty("orderStatus")]
        public OrderStatusType OrderStatus { get; }
        [JsonRequired, JsonProperty("takeProfit")]
        public string TakeProfit { get; }
        [JsonRequired, JsonProperty("stopLoss")]
        public string StopLoss { get; }  
        [JsonRequired, JsonProperty("tpTriggerBy")]
        public string TpTriggerBy { get; }
        [JsonRequired, JsonProperty("slTriggerBy")]
        public string SlTriggerBy { get; }
        [JsonRequired, JsonProperty("lastExecPrice")]
        public string LastExecPrice { get; }
        [JsonRequired, JsonProperty("basePrice")]
        public string BasePrice { get; }
        [JsonRequired, JsonProperty("triggerPrice")]
        public string TriggerPrice { get; }
        [JsonRequired, JsonProperty("triggerBy")]
        public string TriggerBy { get; }
        [JsonRequired, JsonProperty("reduceOnly")]
        public bool ReduceOnly { get; }
        [JsonRequired, JsonProperty("stopOrderType")]
        public string StopOrderType { get; }
        [JsonRequired, JsonProperty("closeOnTrigger")]
        public string CloseOnTrigger { get; }
        [JsonRequired, JsonProperty("createdAt")]
        public int CreatedAt { get; }



        
    }
}