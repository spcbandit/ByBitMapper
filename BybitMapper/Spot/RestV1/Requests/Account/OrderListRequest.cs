using BybitMapper.Extensions;
using BybitMapper.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Requests.Account
{
    public class OrderListRequest : KeyedRequestPayload
    {
        public string Symbol { get; set; }
        public string OrderId { get; set; }
        public int? Limit { get; set; } = 500;
        

        internal override string EndPoint => "/spot/v1/open-orders";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("orderId", OrderId);
                res.AddSimpleStructIfNotNull("limit", Limit); 

                return res;
            }
        }
    }
}
