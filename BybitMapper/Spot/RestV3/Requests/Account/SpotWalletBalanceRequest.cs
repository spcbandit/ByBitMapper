using BybitMapper.Requests;

namespace BybitMapper.Spot.RestV3.Requests.Account
{
    public class SpotWalletBalanceRequest : KeyedRequestPayload
    {
        internal override string EndPoint => "/spot/v3/private/account";
        internal override RequestMethod Method => RequestMethod.GET;
    }
}
