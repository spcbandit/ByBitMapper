using BybitMapper.Extensions;
using BybitMapper.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Requests.Account
{
    public class CancelSpotOrderRequest : KeyedRequestPayload
    {

        public string OrderId { get; set; }
        public string OrderLinkId { get; set; }

        internal override string EndPoint => "/spot/v1/order";
        internal override RequestMethod Method => RequestMethod.DELETE;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("orderId", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("orderLinkId", OrderLinkId);
                
                return res;
            }
        }
    }
}
