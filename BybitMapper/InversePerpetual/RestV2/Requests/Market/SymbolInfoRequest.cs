using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Market
{
    public sealed class SymbolInfoRequest : RequestPayload
    {
        public SymbolInfoRequest()
        {
        }
        public string Symbol { get; set; }
        internal override string EndPoint => "/v2/public/tickers";
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
