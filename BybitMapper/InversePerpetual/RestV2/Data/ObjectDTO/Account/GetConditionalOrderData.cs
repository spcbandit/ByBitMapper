using System;
using System.Collections.Generic;

using JetBrains.Annotations;
using Newtonsoft.Json;

using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    // https://bybit-exchange.github.io/docs/futuresV2/inverse/#t-getcond

    public class GetDataConditionalOrderData
    {
        [JsonConstructor]
        public GetDataConditionalOrderData(string userId, string symbol, string side, 
            string orderType, decimal? price, decimal? qty, string timeInForce, 
            string remark, decimal? leavesQty, decimal? leavesValue, decimal? stopPx, 
            string rejectReason, string stopOrderId, string orderLinkId, string triggerBy,
            decimal? basePrice, DateTime? createdAt, DateTime? updatedAt, string tpTriggerBy,
            string slTriggerBy, decimal? takeProfit, decimal? stopLoss, string stopOrderType, string stopOrderStatus)
        {
            UserId = userId;
            Symbol = symbol;
            Side = side;
            SideType = side.ToEnum<OrderSideType>();
            OrderType = orderType;
            OrderTypeEnum = orderType.ToEnum<OrderType>();
            Price = price;
            Qty = qty;
            TimeInForce = timeInForce;
            TimeInForceType = timeInForce.ToEnum<TimeInForceType>();
            Remark = remark;
            LeavesQty = leavesQty;
            LeavesValue = leavesValue;
            StopPx = stopPx;
            RejectReason = rejectReason;
            StopOrderId = stopOrderId;
            OrderLinkId = orderLinkId;
            TriggerBy = triggerBy;
            TriggerByType = TriggerBy.ToEnum<TriggerPriceType>();
            BasePrice = basePrice;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            TpTriggerBy = tpTriggerBy;
            TpTriggerByType = TpTriggerBy.ToEnum<TriggerPriceType>();
            SlTriggerBy = slTriggerBy;
            SlTriggerByType = SlTriggerBy.ToEnum<TriggerPriceType>();
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            StopOrderType = stopOrderType;
            StopOrderTypeEnum = StopOrderType.ToEnum<StopOrderType>();
            StopOrderStatus = stopOrderStatus;
            StopOrderStatusEnum = StopOrderStatus.ToEnum<StopOrderStatusType>();
        }

        [JsonProperty("user_id")]
        public string UserId { get; }

        [JsonProperty("symbol")]
        public string Symbol { get; }
        
        [JsonProperty("stop_order_type")]
        public string StopOrderType { get; }
        public StopOrderType StopOrderTypeEnum { get; set; }
        [JsonProperty("stop_order_status")]
        public string StopOrderStatus { get; }
        public StopOrderStatusType StopOrderStatusEnum { get; set; }

        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType? SideType { get; }

        [JsonProperty("order_type")]
        public string OrderType { get; }
        public OrderType? OrderTypeEnum { get; }

        [JsonProperty("price")]
        public decimal? Price { get; }
        [JsonProperty("qty")]
        public decimal? Qty { get; }

        [JsonProperty("time_in_force")]
        public string TimeInForce { get; }
        public TimeInForceType? TimeInForceType { get; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("leaves_qty")]
        public decimal? LeavesQty { get; set; }

        [JsonProperty("leaves_value")]
        public decimal? LeavesValue { get; set; }

        [JsonProperty("stop_px")]
        public decimal? StopPx { get; }

        [JsonProperty("reject_reason")]
        public string RejectReason { get; set; }

        [JsonProperty("stop_order_id")]
        public string StopOrderId { get; }

        [JsonProperty("order_link_id")]
        public string OrderLinkId { get; }

        [JsonProperty("trigger_by")]
        public string TriggerBy { get; }

        public TriggerPriceType? TriggerByType { get; }

        [JsonProperty("base_price")]
        public decimal? BasePrice { get; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; }

        [JsonProperty("tp_trigger_by")]
        public string TpTriggerBy { get; set; }

        public TriggerPriceType? TpTriggerByType { get; }

        [JsonProperty("sl_trigger_by")]
        public string SlTriggerBy { get; set; }

        public TriggerPriceType? SlTriggerByType { get; }

        [JsonProperty("take_profit")]
        public decimal? TakeProfit { get; set; }

        [JsonProperty("stop_loss")]
        public decimal? StopLoss { get; set; }
    }
    public sealed class GetConditionalOrderData
    {
        [JsonConstructor]
        public GetConditionalOrderData(int currentPage, int lastPage, IReadOnlyList<GetDataConditionalOrderData> data)
        {
            CurrentPage = currentPage;
            LastPage = lastPage;
            Data = data;
        }

        [CanBeNull, JsonProperty("current_page")]
        public int CurrentPage { get; }
        [CanBeNull, JsonProperty("last_page")]
        public int LastPage { get; }
        [JsonProperty("data")]
        public IReadOnlyList<GetDataConditionalOrderData> Data { get; }
    }
}
