using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ConditionalOrders
{
    // public class PlaceConditionalOrderRequest : KeyedRequestPayload
    // {
    //     public PlaceConditionalOrderRequest(OrderSideType side,[NotNull] string symbol, OrderType orderType, decimal qty, decimal? price, decimal basePrice, decimal stopPriceTrigger, TimeInForceType timeInForce, TriggerPriceType? triggerPrice, bool? closeOnTrigger, string orderLinkId)
    //     {
    //         Side = side;
    //         Symbol = symbol;
    //         OrderType = orderType;
    //         Qty = qty;
    //         Price = price;
    //         BasePrice = basePrice;
    //         StopPriceTrigger = stopPriceTrigger;
    //         TimeInForce = timeInForce;
    //         TriggerPrice = triggerPrice;
    //         CloseOnTrigger = closeOnTrigger;
    //         OrderLinkId = orderLinkId;
    //     }
    //
    //     public OrderSideType Side { get; }
    //     public string Symbol { get; }
    //     public OrderType OrderType { get; }
    //     public decimal Qty { get; }
    //     [CanBeNull]
    //     public decimal? Price { get; }
    //     public decimal BasePrice { get; }
    //     public decimal StopPriceTrigger { get; }
    //     public TimeInForceType TimeInForce { get; }
    //     [CanBeNull]
    //     public TriggerPriceType? TriggerPrice { get; }
    //     [CanBeNull]
    //     public bool? CloseOnTrigger { get; }
    //     [CanBeNull]
    //     public string OrderLinkId { get; }
    //
    //     internal override string EndPoint => "/open-api/stop-order/create";
    //     internal override RequestMethod Method => RequestMethod.POST;
    //     internal override IDictionary<string, string> Properties
    //     {
    //         get 
    //         {
    //             var res = new Dictionary<string, string>();
    //             return res;
    //         }
    //     }
    // }
}
