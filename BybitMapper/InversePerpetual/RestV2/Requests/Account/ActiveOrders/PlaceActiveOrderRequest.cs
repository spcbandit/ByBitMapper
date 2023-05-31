using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ActiveOrders
{
    public class PlaceOrderRequest : KeyedRequestPayload
    {
        public PlaceOrderRequest(OrderSideType side,[NotNull] string symbol, OrderType orderType,
            decimal qty,[CanBeNull] decimal? price, TimeInForceType timeInForce,
           [CanBeNull] decimal? takeProfit, [CanBeNull] decimal? stopLoss, [CanBeNull] bool? reduceOnly,
           [CanBeNull] bool? closeOnTrigger, [CanBeNull] string orderLinkId)
        {
            Side = side;
            Symbol = symbol;
            OrderType = orderType;
            Qty = qty;
            Price = price;
            TimeInForce = timeInForce;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            ReduceOnly = reduceOnly;
            CloseOnTrigger = closeOnTrigger;
            OrderLinkId = orderLinkId;
        }

        public OrderSideType Side { get; }
        public string Symbol { get; }
        public OrderType OrderType { get; }
        public decimal Qty { get; }
        public decimal? Price { get; }
        public TimeInForceType TimeInForce { get; }
        public decimal? TakeProfit { get; }
        public decimal? StopLoss { get; }
        public bool? ReduceOnly { get; }
        public bool? CloseOnTrigger { get; }
        public string OrderLinkId { get; }
        public override IDictionary<string, string> Headers { get; set; }
        internal override string EndPoint => "/v2/private/order/create";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();

                res.AddEnum("side", Side);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("order_type", OrderType);
                res.AddDecimal("qty", Qty);
                res.AddDecimalIfNotNull("price", Price);
                res.AddEnum("time_in_force", TimeInForce);
                res.AddDecimalIfNotNull("take_profit", TakeProfit);
                res.AddDecimalIfNotNull("stop_loss", StopLoss);
                res.AddSimpleStructIfNotNull("reduce_only", ReduceOnly);
                res.AddSimpleStructIfNotNull("close_on_trigger", CloseOnTrigger);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);

                return res;
            }
        } 
    }
}
