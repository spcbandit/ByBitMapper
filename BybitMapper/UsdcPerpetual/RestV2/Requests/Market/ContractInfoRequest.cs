using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Market
{
    /// <summary>
    /// Contract Info
    /// </summary>
    public sealed class ContractInfoRequest : RequestPayload
    {
        public ContractInfoRequest()
        {
        }
        public string Symbol { get; set; }  
        public string Direction { get; set; }
        public int? Limit { get; set; }

        internal override string EndPoint => "/perpetual/usdc/openapi/public/v1/symbols";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("direction", Direction);
                res.AddSimpleStructIfNotNull("limit", Limit);
                return res;
            }
        }

    }
}