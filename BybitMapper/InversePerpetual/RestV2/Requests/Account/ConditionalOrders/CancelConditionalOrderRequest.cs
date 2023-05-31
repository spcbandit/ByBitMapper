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
    public class CancelConditionalOrderRequest : KeyedRequestPayload
    {
        public CancelConditionalOrderRequest([NotNull] string symbol)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }

        public string Symbol { get; }
        public string StopOrderId { get; set; }
        public string OrderLinkId { get; set; }

        internal override string EndPoint => "/v2/private/stop-order/cancel";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("stop_order_id", StopOrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                return res;
            }
        }
    }
}
