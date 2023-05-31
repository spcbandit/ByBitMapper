using BybitMapper.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Requests.Market
{
    public class GetSymbolsRequest : RequestPayload
    {
        internal override string EndPoint => "/spot/v1/symbols";

        internal override RequestMethod Method => RequestMethod.GET;
    }
}
