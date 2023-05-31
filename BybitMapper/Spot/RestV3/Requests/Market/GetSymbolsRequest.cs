using BybitMapper.Requests;

namespace BybitMapper.Spot.RestV3.Requests.Market
{
    public class GetSymbolsRequest : RequestPayload
    {
        internal override string EndPoint => "/spot/v3/public/symbols";

        internal override RequestMethod Method => RequestMethod.GET;
    }
}
