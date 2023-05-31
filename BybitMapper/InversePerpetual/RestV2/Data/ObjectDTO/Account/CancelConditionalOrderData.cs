using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{

    public class CancelConditionalOrderData
    {
        // string userId, string stopOrderStatus, string symbol, string side, string orderType,
        // decimal price, decimal qty, string timeInForce, string stopOrderType, string triggerPrice,
        // decimal basePrice, string orderLinkId, DateTime? createdAt, DateTime? updatedAt, decimal stopPx,
        [JsonConstructor]
        public CancelConditionalOrderData( string stopOrderId)
        {
            // UserId = userId;
            // StopOrderStatus = stopOrderStatus;
            // StopOrderStatusType = StopOrderStatus.ToEnum<StopOrderStatusType>();
            // Symbol = symbol;
            // Side = side;
            // OrderSide = Side.ToEnum<OrderSideType>();
            // OrderType = orderType;
            // OrderTypeEnum = OrderType.ToEnum<OrderType>();
            // Price = price;
            // Qty = qty;
            // TimeInForce = timeInForce;
            // TimeInForceType = TimeInForce.ToEnum<TimeInForceType>();
            // StopOrderType = stopOrderType;
            // TriggerPrice = triggerPrice;
            // TriggerPriceType = TriggerPrice.ToEnum<TriggerPriceType>();
            // BasePrice = basePrice;
            // OrderLinkId = orderLinkId;
            // CreatedAt = createdAt;
            // UpdatedAt = updatedAt;
            // StopPx = stopPx;
            StopOrderId = stopOrderId;
        }
        //
        // [JsonProperty("user_id")]
        // public string UserId { get; }
        // [JsonProperty("stop_order_status")]
        // public string StopOrderStatus { get; }
        // public StopOrderStatusType StopOrderStatusType { get; }
        // [JsonProperty("symbol")]
        // public string Symbol { get; }
        // [JsonProperty("side")]
        // public string Side { get; }
        // public OrderSideType OrderSide { get; }
        // [JsonProperty("order_type")]
        // public string OrderType { get; }
        // public OrderType OrderTypeEnum { get; }
        // [JsonProperty("price")]
        // public decimal Price { get; }
        // [JsonProperty("qty")]
        // public decimal Qty { get; }
        // [JsonProperty("time_in_force")]
        // public string TimeInForce { get; }
        // public TimeInForceType TimeInForceType { get; }
        // [JsonProperty("stop_order_type")]
        // public string StopOrderType { get; }
        // [JsonProperty("trigger_by")]
        // public string TriggerPrice { get; }
        // public TriggerPriceType TriggerPriceType { get; }
        // [JsonProperty("base_price")]
        // public decimal BasePrice { get; }
        // [JsonProperty("order_link_id")]
        // public string OrderLinkId { get; }
        // [JsonProperty("created_at")]
        // public DateTime? CreatedAt { get; }
        // [JsonProperty("updated_at")]
        // public DateTime? UpdatedAt { get; }
        // [JsonProperty("stop_px")]
        // public decimal StopPx { get; }
        [JsonProperty("stop_order_id")]
        public string StopOrderId { get; }

    }

}
