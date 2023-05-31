using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.ActiveOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста GetActiveOrder
    /// </summary>
    public sealed class GetActiveOrderRequest : KeyedRequestPayload
    {
        public GetActiveOrderRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string OrderId { get; set; }
        public string OrderLinkId { get; set; }
        public string Order { get; set; }
        public string Symbol { get; set; }
        public int? Page { get; set; }
        public int? Limit { get; set; }
        public List<OrderStatusType> OrderStatus { get; set; }

        internal override string EndPoint => "/private/linear/order/list";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("order_id", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("order", Order);
                res.AddSimpleStructIfNotNull("page", Page);
                res.AddSimpleStructIfNotNull("limit", Limit);
                if (OrderStatus != null)
                {
                    res.AddListEnums("order_status", OrderStatus);
                }
                return res;
            }
        }
    }
}
