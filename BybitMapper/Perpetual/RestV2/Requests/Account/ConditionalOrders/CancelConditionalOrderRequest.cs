using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;


namespace BybitMapper.Perpetual.RestV2.Requests.Account.ConditionalOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста CancelConditionalOrder
    /// </summary>
    public sealed class CancelConditionalOrderRequest : KeyedRequestPayload
    {
        public CancelConditionalOrderRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string OrderId { get; set; }
        public string OrderLinkId { get; set; }
        public string Symbol { get; set; }

        internal override string EndPoint => "/private/linear/stop-order/cancel";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("stop_order_id", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                
                return res;
            }
        }
    }
}
