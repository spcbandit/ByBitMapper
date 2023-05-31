using System;
using System.Collections.Generic;

using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ConditionalOrders
{
    // https://bybit-exchange.github.io/docs/futuresV2/inverse/#t-getcond

    public class GetConditionalOrdersRequest : KeyedRequestPayload
    {
        public GetConditionalOrdersRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; }

        public StopOrderStatusType? StopOrderType { get; set; }

        public DirectionExchangeType? Direction { get; set; }

        public int? Limit { get; set; }

        public string Cursor { get; }

        internal override string EndPoint => "/v2/private/stop-order/list";

        internal override RequestMethod Method => RequestMethod.GET;

        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnumIfNotNull("stop_order_status", StopOrderType);
                res.AddEnumIfNotNull("direction", Direction);
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddStringIfNotEmptyOrWhiteSpace("cursor", Cursor);

                return res;
            }
        }
    }
}
