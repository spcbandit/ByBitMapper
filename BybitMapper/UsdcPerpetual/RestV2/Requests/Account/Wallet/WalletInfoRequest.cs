using BybitMapper.Requests;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Wallet
{
    /// <summary>
    /// Информация о кошельке
    /// </summary>
    public sealed class WalletInfoRequest : UsdcKeyedRequestPayload
    {
        public WalletInfoRequest()
        {
        }
        internal override string EndPoint => "/option/usdc/openapi/private/v1/query-wallet-balance";
        internal override RequestMethod Method => RequestMethod.POST;
    }
}
