using BybitMapper.Extensions;
using BybitMapper.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Requests.Account
{
    public class TradeHistoryRequest : KeyedRequestPayload
    {
        public string Symbol { get; set; }        
        public int? Limit { get; set; } = 500;
        public long? FromId { get; set; }
        public long? ToId { get; set; }


        internal override string EndPoint => "/spot/v1/myTrades";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);                
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddSimpleStructIfNotNull("fromTicketId", FromId);
                res.AddSimpleStructIfNotNull("toTicketId", ToId);

                return res;
            }
        }
    }
}
