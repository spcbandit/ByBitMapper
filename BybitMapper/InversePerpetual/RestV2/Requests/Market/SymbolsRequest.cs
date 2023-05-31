using BybitMapper.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Market
{
    public class SymbolsRequest : RequestPayload
    {
        internal override string EndPoint => "/v2/public/symbols";

        internal override RequestMethod Method => RequestMethod.GET;
    }
}
