using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.ActiveOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста QueryActiveOrder
    /// </summary>
    public sealed class QueryActiveOrderRequest : KeyedRequestPayload
    {
        public QueryActiveOrderRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string OrderId { get; set; }
        public string OrderLinkId { get; set; }
        public string Symbol { get; set; }

        internal override string EndPoint => "/private/linear/order/search";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("order_id", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);

                return res;
            }
        }
    }
}
