using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.ConditionalOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста GetConditionalOrder
    /// </summary>
    public sealed class GetConditionalOrderRequest : KeyedRequestPayload
    {
        public GetConditionalOrderRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string StopOrderId { get; set; }
        public string OrderLinkId { get; set; }
        public string Symbol { get; set; }
        public OrderStatusType? StopOrderStatus { get; set; }
        public SortOrdersType? Order { get; set; }
        public int? Page { get; set; }
        public int? Limit { get; set; }

        internal override string EndPoint => "/private/linear/stop-order/list";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("stop_order_id", StopOrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnumIfNotNull("stop_order_status", StopOrderStatus);
                res.AddEnumIfNotNull("order", Order);
                res.AddDecimalIfNotNull("page", Page);
                res.AddDecimalIfNotNull("limit", Limit);

                return res;
            }
        }
    }
}
