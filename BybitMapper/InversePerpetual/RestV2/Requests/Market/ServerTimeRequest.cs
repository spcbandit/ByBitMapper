using BybitMapper.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Market
{
    public class ServerTimeRequest : RequestPayload
    {
        internal override string EndPoint => "/v2/public/time";

        internal override RequestMethod Method => RequestMethod.GET;
    }
}
