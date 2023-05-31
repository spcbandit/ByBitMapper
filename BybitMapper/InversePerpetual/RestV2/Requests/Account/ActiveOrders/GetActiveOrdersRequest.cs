using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ActiveOrders
{
    public class GetActiveOrdersRequest : KeyedRequestPayload
    {
        public GetActiveOrdersRequest(string symbol, DirectionExchangeType? direction, string cursor, int? limit, List<OrderStatusType> orderStatus)
        {
            Symbol = symbol;
            Direction = direction;
            Cursor = cursor;
            Limit = limit;
            OrderStatus = orderStatus;
        }


        //public string OrderId { get; }
        //public string OrderLinkId { get; }
        public string Symbol { get; }
        public DirectionExchangeType? Direction { get; }
        public string Cursor { get; }
        //public OrderSortType? OrderSort { get; }
        //public int? Page { get; }
        public int? Limit { get; }
        public List<OrderStatusType> OrderStatus { get; }

        internal override string EndPoint => "/v2/private/order/list";// "/open-api/order/list";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("cursor", Cursor);
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddEnumIfNotNull("direction", Direction);
                if (OrderStatus != null)
                {
                    res.AddListEnums("order_status", OrderStatus);
                }
                return res;
            }
        }
    }
}
