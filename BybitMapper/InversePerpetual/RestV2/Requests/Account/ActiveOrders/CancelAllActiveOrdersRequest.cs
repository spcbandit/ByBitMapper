using BybitMapper.Extensions;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ActiveOrders
{
    public class CancelAllActiveOrdersRequest : KeyedRequestPayload
    {
        public CancelAllActiveOrdersRequest([NotNull]string symbol)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }
        public string Symbol { get; }
        internal override string EndPoint => "/v2/private/order/cancelAll";
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
