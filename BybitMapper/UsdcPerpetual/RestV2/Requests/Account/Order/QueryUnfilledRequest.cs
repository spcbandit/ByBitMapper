using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Order
{
    /// <summary>
    /// Ревкест Query Unfilled/Partially Filled Orders
    /// </summary>
    public sealed class QueryUnfilledRequest : UsdcKeyedRequestPayload
    {
        public QueryUnfilledRequest(CategoryType category)
        {
            Category = category;
        }
        
        public CategoryType Category { get; set; }
        public string Symbol { get; set; }
        public string OrderId { get; set; }
        public string OrderLinkId { get; set; }
        public OrderFilterType? OrderFilter { get; set; }
        public string Direction { get; set; }
        public int? Limit { get; set; }
        public string Cursor { get; set; }
        
        internal override string EndPoint => "/option/usdc/openapi/private/v1/query-active-orders";
        internal override RequestMethod Method => RequestMethod.POST;

        internal override object Body
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddEnum("category", Category);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("orderId", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("orderLinkId", OrderLinkId);
                res.AddEnumIfNotNull("orderFilter", OrderFilter);
                res.AddStringIfNotEmptyOrWhiteSpace("direction", Direction);
                res.AddDecimalIfNotNull("limit", Limit);
                res.AddStringIfNotEmptyOrWhiteSpace("cursor", Cursor);

                return res;
            }
        }

    }
}