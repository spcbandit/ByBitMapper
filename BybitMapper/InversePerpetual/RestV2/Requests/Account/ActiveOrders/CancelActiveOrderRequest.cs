using BybitMapper.Extensions;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ActiveOrders
{
    public class CancelActiveOrderRequest : KeyedRequestPayload
    {
        public CancelActiveOrderRequest([NotNull] string symbol,[CanBeNull] string orderId,[CanBeNull] string orderLinkId)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);

            Symbol = symbol;
            OrderId = orderId;
            OrderLinkId = orderLinkId;
        }

        public string Symbol { get; }
        public string OrderId { get; }
        public string OrderLinkId { get; }
        internal override string EndPoint => "/v2/private/order/cancel";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("order_id", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);

                return res;
            }
        }
    }
}
