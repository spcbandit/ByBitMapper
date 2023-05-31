using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Spot.RestV1.Requests.Market
{
    /// <summary>
    /// Запрос на получение инструмента
    /// </summary>
    public class LatestInformationSymbolRequest : RequestPayload
    {
        public LatestInformationSymbolRequest()
        {
        }

        public string Symbol { get; set; }

        internal override string EndPoint => "/spot/quote/v1/ticker/24hr";

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
