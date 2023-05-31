using BybitMapper.Requests;

namespace BybitMapper.Spot.RestV3.Requests.Market
{
    public class ServerTimeRequest : RequestPayload
    {
        internal override string EndPoint => "/spot/v3/public/server-time";

        internal override RequestMethod Method => RequestMethod.GET;
    }
}
