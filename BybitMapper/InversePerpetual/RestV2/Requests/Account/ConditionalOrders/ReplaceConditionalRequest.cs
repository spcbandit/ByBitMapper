using BybitMapper.Extensions;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ConditionalOrders
{
    public class ReplaceConditionalRequest : KeyedRequestPayload
    {
        public ReplaceConditionalRequest([NotNull]string symbol, string stopOrderId, string orderId, string orderLinkId, decimal? pRQty, decimal? pRPrice, decimal? pRTriggerPrice)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can be null!", symbol);
            StopOrderId = stopOrderId;
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            Symbol = symbol;
            PRQty = pRQty;
            PRPrice = pRPrice;
            PRTriggerPrice = pRTriggerPrice;
        }

        public string StopOrderId { get; }
        public string OrderId { get; }
        public string OrderLinkId { get; }
        public string Symbol { get; }
        public decimal? PRQty { get; }
        public decimal? PRPrice { get; }
        public decimal? PRTriggerPrice { get; }


        internal override string EndPoint => "/open-api/stop-order/replace";

        internal override RequestMethod Method => RequestMethod.POST;

        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("stop_order_id", StopOrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_id", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("p_r_qty", PRQty);
                res.AddDecimalIfNotNull("p_r_price", PRPrice);
                res.AddDecimalIfNotNull("p_r_trigger_price", PRTriggerPrice);


                return res;
            }
        }
    }
}
