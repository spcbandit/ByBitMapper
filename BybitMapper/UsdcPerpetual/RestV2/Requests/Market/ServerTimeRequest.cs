using BybitMapper.Requests;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Market
{
    /// <summary>
    /// Запрос на время биржи
    /// </summary>
    public class ServerTimeRequest : RequestPayload
    {
        internal override string EndPoint => "/v2/public/time";

        internal override RequestMethod Method => RequestMethod.GET;
    }
}
