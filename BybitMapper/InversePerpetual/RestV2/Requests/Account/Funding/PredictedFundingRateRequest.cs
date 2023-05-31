using BybitMapper.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Funding
{
    public class PredictedFundingRateRequest : KeyedRequestPayload
    {
        public string Symbol { get; }

        public PredictedFundingRateRequest(string symbol)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }

        internal override string EndPoint => "/open-api/funding/predicted-funding";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                return res;
            }
        }
    }
}
