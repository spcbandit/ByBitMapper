using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Requests;

namespace BybitMapper.Spot.RestV3.Requests.Market
{
    public class LatestInformationSymbolRequest : RequestPayload
    {
        public LatestInformationSymbolRequest()
        {
        }
        /// <summary>
        /// Инструмент
        /// </summary>
        public string Symbol { get; set; }

        internal override string EndPoint => "/spot/v3/public/quote/ticker/24hr";

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
