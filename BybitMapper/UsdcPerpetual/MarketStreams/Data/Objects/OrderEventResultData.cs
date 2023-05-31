using BybitMapper.Extensions;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using BybitMapper.UsdcPerpetual.UserStreams.Data;
using Newtonsoft.Json;
using StopOrderTypeEnum = BybitMapper.UsdcPerpetual.UserStreams.Data.StopOrderTypeEnum;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class OrderEventResultData
    {
        [JsonConstructor]
        public OrderEventResultData(string orderId, string orderLinkId, long createdAt, long updatedAt, string symbol, string orderStatus, string side, 
            decimal price, decimal qty, decimal cumExecQty, decimal leavesQty, decimal orderIm, decimal? realisedPnl, string order, int reduceOnly, 
            string timeInForce, decimal? cumExecFee, decimal? orderPnl, decimal? basePrice, decimal? cumExecValue, bool closeOnTrigger, string triggerBy, 
            decimal takeProfit, decimal stopLoss, string tpTriggerBy,string slTriggerBy, decimal? triggerPrice, string stopOrderType, string cancelType)
        {
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Symbol = symbol;
            OrderStatus = orderStatus;
            OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
            Side = side;
            SideType = Side.ToEnum<SideType>();
            Price = price;
            Qty = qty;
            CumExecQty = cumExecQty;
            LeavesQty = leavesQty;
            OrderIm = orderIm;
            RealisedPnl = realisedPnl;
            Order = order;
            OrderType = Order.ToEnum<OrderType>();
            ReduceOnly = reduceOnly;
            TimeInForce = timeInForce;
            CumExecFee = cumExecFee;
            OrderPnl = orderPnl;
            BasePrice = basePrice;
            CumExecValue = cumExecValue;
            CloseOnTrigger = closeOnTrigger;
            TriggerBy = triggerBy;
            TriggerByType = TriggerBy.ToEnum<TriggerByType>();
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            TpTriggerBy = tpTriggerBy;
            TpTriggerByType = TpTriggerBy.ToEnum<TriggerByType>();
            SlTriggerBy = slTriggerBy;
            SlTriggerByType = SlTriggerBy.ToEnum<TriggerByType>();
            TriggerPrice = triggerPrice;
            StopOrderType = stopOrderType;
            StopOrderTypeEnum = StopOrderType.ToEnum<StopOrderTypeEnum>();
            CancelType = cancelType;
        }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }
        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; set; }
        [JsonProperty("createdAt")]
        public long CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public long UpdatedAt { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }
        public OrderStatusType OrderStatusType { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        public SideType SideType { get; set; }
        [JsonProperty("price")]
        public decimal Price { get;  set;}
        [JsonProperty("qty")]
        public decimal Qty { get;  set;}
        [JsonProperty("cumExecQty")]
        public decimal CumExecQty { get;  set;}
        [JsonProperty("leavesQty")]
        public decimal LeavesQty { get;  set;}
        [JsonProperty("orderIm")]
        public decimal OrderIm { get;  set;}
        [JsonProperty("realisedPnl")]
        public decimal? RealisedPnl { get;  set;}
        [JsonProperty("orderType")]
        public string Order { get;  set;}
        public OrderType OrderType { get; set; }
        [JsonProperty("reduceOnly")]
        public int ReduceOnly { get;  set;}
        [JsonProperty("timeInForce")]
        public string TimeInForce { get;  set;}
        [JsonProperty("cumExecFee")]
        public decimal? CumExecFee { get;  set;}
        [JsonProperty("orderPnl")]
        public decimal? OrderPnl { get;  set;}
        [JsonProperty("basePrice")]
        public decimal? BasePrice { get;  set;}
        [JsonProperty("cumExecValue")]
        public decimal? CumExecValue { get;  set;}
        [JsonProperty("closeOnTrigger")]
        public bool CloseOnTrigger { get;  set;}
        [JsonProperty("triggerBy")]
        public string TriggerBy { get;  set;}
        public TriggerByType TriggerByType { get; set; }
        [JsonProperty("takeProfit")]
        public decimal TakeProfit { get;  set;}
        [JsonProperty("stopLoss")]
        public decimal StopLoss { get;  set;}
        [JsonProperty("tpTriggerBy")]
        public string TpTriggerBy { get;  set;}
        public TriggerByType TpTriggerByType { get; set; }
        [JsonProperty("slTriggerBy")]
        public string SlTriggerBy { get;  set;}
        public TriggerByType SlTriggerByType { get; set; }
        [JsonProperty("triggerPrice")]
        public decimal? TriggerPrice { get;  set;}
        [JsonProperty("stopOrderType")]
        public string StopOrderType { get;  set;}
        public StopOrderTypeEnum StopOrderTypeEnum { get; set; }
        [ JsonProperty("cancelType")]
        public string CancelType { get;  set;}

    }
}