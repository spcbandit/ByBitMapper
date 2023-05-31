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
    public class CancelAllConditionalOrdersRequest : KeyedRequestPayload
    {
        public CancelAllConditionalOrdersRequest([NotNull] string symbol)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can be null!", symbol);
            Symbol = symbol;
        }

        public string Symbol { get; }
        internal override string EndPoint => "/v2/private/stop-order/cancelAll";

        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                return res;
            }
        }
    }
}
