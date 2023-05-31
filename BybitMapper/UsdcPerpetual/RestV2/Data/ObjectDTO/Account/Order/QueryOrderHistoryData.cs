using BybitMapper.Extensions;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    /// <summary>
    /// �������� �������
    /// </summary>
    public sealed class QueryOrderHistoryData
    {
        [JsonConstructor]
        public QueryOrderHistoryData(string symbol, string order, string orderLinkId, string orderId, string cancelType, string stopOrderType, 
            string orderStatus, decimal? takeProfit, long createdAt, decimal? orderPnl, decimal? price, string tpTriggerBy, 
            string timeInForce, long updatedAt, [CanBeNull] decimal? basePrice, decimal? realisedPnl, string side, decimal? triggerPrice, decimal? cumExecFee, 
            decimal? leavesQty, string cashFlow, string slTriggerBy, string iv, string closeOnTrigger, decimal? cumExecQty, int? reduceOnly, 
            decimal qty, decimal? stopLoss, string triggerBy, decimal? orderIM)
        {
            Symbol = symbol;
            Order = order;
            OrderType = Order.ToEnum<OrderType>();
            OrderLinkId = orderLinkId;
            OrderId = orderId;
            CancelType = cancelType;
            StopOrderType = stopOrderType;
            StopOrderTypeEnum = StopOrderType.ToEnum<StopOrderTypeEnum>();
            OrderStatus = orderStatus;
            OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
            TakeProfit = takeProfit;
            CreatedAt = createdAt;
            OrderPnl = orderPnl;
            Price = price;
            TpTriggerBy = tpTriggerBy;
            TpTriggerByType = TpTriggerBy.ToEnum<TriggerByType>();
            TimeInForce = timeInForce;
            TimeInForceType = TimeInForce.ToEnum<TimeInForceType>();
            UpdatedAt = updatedAt;
            BasePrice = basePrice;
            RealisedPnl = realisedPnl;
            Side = side;
            SideType = Side.ToEnum<SideType>();
            TriggerPrice = triggerPrice;
            CumExecFee = cumExecFee;
            LeavesQty = leavesQty;
            CashFlow = cashFlow;
            SlTriggerBy = slTriggerBy;
            SlTriggerByType = SlTriggerBy.ToEnum<TriggerByType>();
            Iv = iv;
            CloseOnTrigger = closeOnTrigger;
            CloseOnTriggerType = CloseOnTrigger.ToEnum<TriggerByType>();
            CumExecQty = cumExecQty;
            ReduceOnly = reduceOnly;
            Qty = qty;
            StopLoss = stopLoss;
            TriggerBy = triggerBy;
            TriggerByType = TriggerBy.ToEnum<TriggerByType>();
            OrderIM = orderIM;
        }

        [CanBeNull, JsonProperty("symbol")]
        public string Symbol { get; set; }
        [CanBeNull, JsonProperty("orderType")]
        public string Order { get; set; }
        public OrderType OrderType { get; set; }
        [CanBeNull, JsonProperty("orderLinkId")]
        public string OrderLinkId { get; set; }
        [CanBeNull, JsonProperty("orderId")]
        public string OrderId { get; set; }
        [CanBeNull, JsonProperty("cancelType")]
        public string CancelType { get; set; }
        [CanBeNull, JsonProperty("stopOrderType")]
        public string StopOrderType { get; set; }
        public StopOrderTypeEnum StopOrderTypeEnum { get; set; }
        [CanBeNull, JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }
        public OrderStatusType OrderStatusType { get; set; }
        [CanBeNull, JsonProperty("takeProfit")]
        public decimal? TakeProfit { get; set; }
        [CanBeNull, JsonProperty("createdAt")]
        public long CreatedAt { get; set; }
        [CanBeNull, JsonProperty("orderPnl")]
        public decimal? OrderPnl { get; set; }
        [CanBeNull, JsonProperty("price")]
        public decimal? Price { get; set; }
        [CanBeNull, JsonProperty("tpTriggerBy")]
        public string TpTriggerBy { get; set; }
        public TriggerByType TpTriggerByType { get; set; }
        [CanBeNull, JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }
        public TimeInForceType TimeInForceType { get; set; }
        [CanBeNull, JsonProperty("updatedAt")]
        public long UpdatedAt { get; set; }
        [CanBeNull, JsonProperty("basePrice")]
        public decimal? BasePrice { get; set; }
        [CanBeNull, JsonProperty("realisedPnl")]
        public decimal? RealisedPnl { get; set; }
        [CanBeNull, JsonProperty("side")]
        public string Side { get; set; }
        public SideType SideType { get; set; }
        [CanBeNull, JsonProperty("triggerPrice")]
        public decimal? TriggerPrice { get; set; }
        [CanBeNull, JsonProperty("cumExecFee")]
        public decimal? CumExecFee { get; set; }
        [CanBeNull, JsonProperty("leavesQty")]
        public decimal? LeavesQty { get; set; }
        [CanBeNull, JsonProperty("cashFlow")]
        public string CashFlow { get; set; }
        [CanBeNull, JsonProperty("slTriggerBy")]
        public string SlTriggerBy { get; set; }
        public TriggerByType SlTriggerByType { get; set; }
        [CanBeNull, JsonProperty("iv")]
        public string Iv { get; set; }
        [CanBeNull, JsonProperty("closeOnTrigger")]
        public string CloseOnTrigger { get; set; }
        public TriggerByType CloseOnTriggerType { get; set; }
        [CanBeNull, JsonProperty("cumExecQty")]
        public decimal? CumExecQty { get; set; }
        [CanBeNull, JsonProperty("reduceOnly")]
        public int? ReduceOnly { get; set; }
        [CanBeNull, JsonProperty("qty")]
        public decimal Qty { get; set; }
        [CanBeNull, JsonProperty("stopLoss")]
        public decimal? StopLoss { get; set; }
        [CanBeNull, JsonProperty("triggerBy")]
        public string TriggerBy { get; set; }
        public TriggerByType TriggerByType { get; set; }
        [CanBeNull, JsonProperty("orderIM")]
        public decimal? OrderIM { get; set; }         
    }
}