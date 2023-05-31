using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.RiskLimit
{
    /// <summary>
    /// USDT Perpetual формат реквеста GetRiskLimit
    /// </summary>
    public sealed class GetRiskLimitRequest : KeyedRequestPayload
    {
        public GetRiskLimitRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; set; }
        internal override string EndPoint => "/public/linear/risk-limit";
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
