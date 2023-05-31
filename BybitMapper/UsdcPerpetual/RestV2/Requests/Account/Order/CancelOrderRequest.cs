using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Order
{
    /// <summary>
    /// Реквест отмена ордера
    /// </summary>
    public sealed class CancelOrderRequest : UsdcKeyedRequestPayload
    {
        public CancelOrderRequest(string symbol, OrderFilterType orderFilter)
        {
            Symbol = symbol;
            OrderFilter = orderFilter;
        }
        public string Symbol { get; set; }
        public OrderFilterType OrderFilter { get; set; }
        public string OrderId { get; set; }
        public string OrderLinkId { get; set; }

        internal override string EndPoint => "/perpetual/usdc/openapi/private/v1/cancel-order";
        internal override RequestMethod Method => RequestMethod.POST;

        internal override object Body
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("orderFilter", OrderFilter);
                res.AddStringIfNotEmptyOrWhiteSpace("orderId", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("orderLinkId", OrderLinkId);

                return res;
            }
        }
    }
}