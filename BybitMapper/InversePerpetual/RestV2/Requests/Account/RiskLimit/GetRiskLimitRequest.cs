using BybitMapper.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.RiskLimit
{
    public class GetRiskLimitRequest : KeyedRequestPayload
    {
        internal override string EndPoint => "/open-api/wallet/risk-limit/list";
        internal override RequestMethod Method => RequestMethod.GET;
    }
}
