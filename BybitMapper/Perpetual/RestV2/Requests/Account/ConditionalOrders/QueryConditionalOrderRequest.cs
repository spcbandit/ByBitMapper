using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.ConditionalOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста QueryConditionalOrder
    /// </summary>
    public sealed class QueryConditionalOrderRequest : KeyedRequestPayload
    {
        public QueryConditionalOrderRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string StopOrderId { get; set; }
        public string OrderLinkId { get; set; }
        public string Symbol { get; set; }

        internal override string EndPoint => "/private/linear/stop-order/search";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("stop_order_id", StopOrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);

                return res;
            }
        }
    }
}
