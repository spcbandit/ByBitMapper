using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    // public sealed class PlaceConditionalOrderData
    // {
    //     [JsonConstructor]
    //     public PlaceConditionalOrderData(string userId, string symbol, string side, string orderType, decimal price, 
    //         decimal qty, string timeInForce, string stopOrderType, string triggerBy, decimal basePrice,
    //         string orderStatus, ExtFieldsConditionalData extFields, decimal leavesQty, decimal leavesValue, string rejectReason, decimal crossSeq, DateTime? createdAt, DateTime? updatedAt, decimal stopPx, string stopOrderId)
    //     {
    //         UserId = userId;
    //         Symbol = symbol;
    //         Side = side;
    //         SideType = Side.ToEnum<OrderSideType>();
    //         OrderType = orderType;
    //         OrderTypeEnum = OrderType.ToEnum<OrderType>();
    //         Price = price;
    //         Qty = qty;
    //         TimeInForce = timeInForce;
    //         TimeInForceType = TimeInForce.ToEnum<TimeInForceType>();
    //         StopOrderType = stopOrderType;
    //         TriggerBy = triggerBy;
    //         TriggerByType = TriggerBy.ToEnum<TriggerPriceType>();
    //         BasePrice = basePrice;
    //         OrderStatus = orderStatus;
    //         OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
    //         ExtFields = extFields;
    //         LeavesQty = leavesQty;
    //         LeavesValue = leavesValue;
    //         RejectReason = rejectReason;
    //         CrossSeq = crossSeq;
    //         CreatedAt = createdAt;
    //         UpdatedAt = updatedAt;
    //         StopPx = stopPx;
    //         StopOrderId = stopOrderId;
    //     }
    //
    //     [JsonRequired, JsonProperty("user_id")]
    //     public string UserId { get; }
    //     [JsonRequired, JsonProperty("symbol")]
    //     public string Symbol { get; }
    //     [JsonRequired, JsonProperty("side")]
    //     public string Side { get; }
    //     public OrderSideType SideType { get; }
    //     [JsonRequired, JsonProperty("order_type")]
    //     public string OrderType { get; }
    //     public OrderType OrderTypeEnum { get; }
    //     [JsonRequired, JsonProperty("price")]
    //     public decimal Price { get; }
    //     [JsonRequired, JsonProperty("qty")]
    //     public decimal Qty { get; }
    //     [JsonRequired, JsonProperty("time_in_force")]
    //     public string TimeInForce { get; }
    //     public TimeInForceType TimeInForceType { get; }
    //     [JsonRequired, JsonProperty("stop_order_type")]
    //     public string StopOrderType { get; }
    //     [JsonRequired, JsonProperty("trigger_by")]
    //     public string TriggerBy { get; }
    //     public TriggerPriceType TriggerByType { get; }
    //     [JsonRequired, JsonProperty("base_price")]
    //     public decimal BasePrice { get; }
    //     [JsonRequired, JsonProperty("order_status")]
    //     public string OrderStatus { get; }
    //     public OrderStatusType OrderStatusType { get; }
    //     [JsonRequired, JsonProperty("ext_fields")]
    //     public ExtFieldsConditionalData ExtFields { get; }
    //     [JsonRequired, JsonProperty("leaves_qty")]
    //     public decimal LeavesQty { get; }
    //     [JsonRequired, JsonProperty("leaves_value")]
    //     public decimal LeavesValue { get; }
    //     [JsonRequired, JsonProperty("reject_reason")]
    //     public string RejectReason { get; }
    //     [JsonRequired, JsonProperty("cross_req")]
    //     public decimal CrossSeq { get; }
    //     [CanBeNull, JsonProperty("created_at")]
    //     public DateTime? CreatedAt { get; }
    //     [CanBeNull, JsonProperty("updated_at")]
    //     public DateTime? UpdatedAt { get; }
    //     [JsonRequired, JsonProperty("stop_px")]
    //     public decimal StopPx { get; }
    //     [JsonRequired, JsonProperty("stop_order_id")]
    //     public string StopOrderId { get; }
    // }
}
