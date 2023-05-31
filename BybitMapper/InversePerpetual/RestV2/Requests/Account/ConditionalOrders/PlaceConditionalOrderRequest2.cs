using System;
using System.Collections.Generic;

using JetBrains.Annotations;

using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

using BybitMapper.Extensions;
using BybitMapper.Requests;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ConditionalOrders
{
	public class PlaceConditionalOrderRequest : KeyedRequestPayload
	{
		public PlaceConditionalOrderRequest(OrderSideType side, [NotNull] string symbol, OrderType orderType, decimal qty, 
			decimal basePrice, decimal stopPrice, TimeInForceType timeInForce)
		{
			if(symbol == null)
				throw new ArgumentException("Symbol can not be null!", symbol);
			
			Side = side;
			Symbol = symbol;
			OrderType = orderType;
			Qty = qty;
			BasePrice = basePrice;
			StopPrice = stopPrice;
			TimeInForce = timeInForce;
		}

		public OrderSideType Side { get; set; }

		public string Symbol { get;set; }

		public OrderType OrderType { get;set; }

		public decimal Qty { get;set; }

		[CanBeNull]
		public decimal? Price { get;set; }

		public decimal BasePrice { get;set; }

		public decimal StopPrice { get;set; }

		public TimeInForceType TimeInForce { get;set; }

		[CanBeNull]
		public TriggerPriceType? TriggerPriceType { get;set; }

		[CanBeNull]
		public bool? CloseOnTrigger { get;set; }

		[CanBeNull]
		public string OrderLinkId { get;set; }

		[CanBeNull]
		public decimal? TakeProfit { get;set; }

		[CanBeNull]
		public decimal? StopLoss { get;set; }

		[CanBeNull]
		public TriggerPriceType? TakeProfitTriggerType { get;set; }

		[CanBeNull]
		public TriggerPriceType? StopLossTriggerType { get;set; }

		internal override string EndPoint => "/v2/private/stop-order/create";

		internal override RequestMethod Method => RequestMethod.POST;

		internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                
				res.AddEnum("side", Side);
				res.Add("symbol", Symbol);
				res.AddEnum("order_type", OrderType);
				res.AddDecimal("qty", Qty);
				res.AddDecimalIfNotNull("price", Price);
				res.AddDecimal("base_price", BasePrice);
                res.AddDecimal("stop_px", StopPrice);
				res.AddEnum("time_in_force", TimeInForce);
				res.AddEnumIfNotNull("trigger_by", TriggerPriceType);
				res.AddBooleanIfNotNull("close_on_trigger", CloseOnTrigger);
				res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
				res.AddDecimalIfNotNull("take_profit", TakeProfit);
				res.AddDecimalIfNotNull("stop_loss", StopLoss);
				res.AddEnumIfNotNull("tp_trigger_by", TakeProfitTriggerType);
				res.AddEnumIfNotNull("sl_trigger_by", StopLossTriggerType);

                return res;
            }
        }
	}
}
