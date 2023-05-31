using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.ActiveOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста CancelAllActiveOrders
    /// </summary>
    public sealed class CancelAllActiveOrdersRequest : KeyedRequestPayload
    {
        public CancelAllActiveOrdersRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; set; }

        internal override string EndPoint => "/private/linear/order/cancel-all";
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
