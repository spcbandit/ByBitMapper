using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Funding
{
    public class MyLastFundingFeeRequest : KeyedRequestPayload
    {
        public MyLastFundingFeeRequest(string symbol)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }
        public string Symbol { get; }
        internal override string EndPoint => "/open-api/funding/prev-funding";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                return res;
            }
        }
    }
}
