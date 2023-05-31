using BybitMapper.Requests;

namespace BybitMapper.Spot.RestV1.Requests.Account
{
    public class SpotWalletBalanceRequest : KeyedRequestPayload
    {
        internal override string EndPoint => "/spot/v1/account";
        internal override RequestMethod Method => RequestMethod.GET;
    }
}
