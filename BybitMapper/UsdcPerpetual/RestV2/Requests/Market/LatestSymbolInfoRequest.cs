using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Market
{
    /// <summary>
    /// Реквест на получение инструмента
    /// </summary>
    public class LatestSymbolInfoRequest : RequestPayload
    {
        public LatestSymbolInfoRequest(string symbol)
        {
            Symbol = symbol;
        }
        public string Symbol { get; set; }

        internal override string EndPoint => "/perpetual/usdc/openapi/public/v1/tick";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.Add("symbol", Symbol);
                return res;
            }
        }
    }
}
