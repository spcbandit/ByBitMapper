using System;
using Newtonsoft.Json;

using BybitMapper.Extensions;

using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

namespace BybitMapper.InversePerpetual.UserStreams.Data
{
	public sealed class PlaceConditionalOrderData
	{
		[JsonConstructor]
        public PlaceConditionalOrderData(string userId, string symbol, string side, string order, decimal price, 
			decimal qty, string timeInForce, string remark, decimal leavesQty, decimal leavesValue, decimal stopPrice, 
			string rejectReason, string stopOrderId, string orderLinkId, string triggerBy, decimal basePrice, 
			DateTime? createdAt, DateTime? updatedAt, string tpTriggerBy, string slTriggerBy, 
			decimal takeProfit, decimal stopLoss)
		{
			UserId = userId;
			Symbol = symbol;
			Side = side;
			SideType = side.ToEnum<OrderSideType>();
			Order = order;
			OrderType = order.ToEnum<OrderType>();
			Price = price;
			Qty = qty;
			TimeInForce = timeInForce;
			TimeInForceType = timeInForce.ToEnum<TimeInForceType>();
			Remark = remark;
			LeavesQty = leavesQty;
			LeavesValue = leavesValue;
			StopPrice = stopPrice;
			RejectReason = rejectReason;
			StopOrderId = stopOrderId;
			OrderLinkId = orderLinkId;
			TriggerBy = triggerBy;
			TriggerByType = triggerBy.ToEnum<TriggerPriceType>();
			BasePrice = basePrice;
			CreatedAt = createdAt;
			UpdatedAt = updatedAt;
			TpTriggerBy = tpTriggerBy;
			SlTriggerBy = slTriggerBy;
			TakeProfit = takeProfit;
			StopLoss = stopLoss;
		}

		[JsonProperty("user_id")]
		public string UserId { get; }
		
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
		
		[JsonProperty("time_in_force")]
		public string TimeInForce { get; }
		
		public TimeInForceType TimeInForceType { get; }
		
		[JsonProperty("remark")]
		public string Remark { get; }
		
		[JsonProperty("leaves_qty")]		
		public decimal LeavesQty { get; }
		
		[JsonProperty("leaves_value")]		
		public decimal LeavesValue { get; }
		
		[JsonProperty("stop_px")]		
		public decimal StopPrice { get; }
		
		[JsonProperty("reject_reason")]
		public string RejectReason { get; }
		
		[JsonProperty("stop_order_id")]
		public string StopOrderId { get; }
		
		[JsonProperty("order_link_id")]
		public string OrderLinkId { get; }
		
		[JsonProperty("trigger_by")]
		public string TriggerBy { get; }
		
		public TriggerPriceType TriggerByType { get; }
		
		[JsonProperty("base_price")]
		public decimal BasePrice { get; }
		
		[JsonProperty("created_at")]
		public DateTime? CreatedAt { get; }
		
		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt { get; }
		
		[JsonProperty("tp_trigger_by")]
		public string TpTriggerBy { get; }
		
		[JsonProperty("sl_trigger_by")]
		public string SlTriggerBy { get; }
		
		[JsonProperty("take_profit")]
		public decimal TakeProfit { get; }
		
		[JsonProperty("stop_loss")]
		public decimal StopLoss { get; }
	}
}

