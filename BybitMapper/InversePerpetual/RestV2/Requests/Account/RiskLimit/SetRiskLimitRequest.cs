using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.RiskLimit
{
    public class SetRiskLimitRequest : KeyedRequestPayload
    {
        public SetRiskLimitRequest(string symbol, int riskId)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
            RiskId = riskId;
        }

        public string Symbol { get; }
        public int RiskId { get; }
        internal override string EndPoint => "/open-api/wallet/risk-limit";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddSimpleStruct("risk_id", RiskId);
                return res;
            }
        }
    }
}
