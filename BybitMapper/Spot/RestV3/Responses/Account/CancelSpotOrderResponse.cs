using BybitMapper.Spot.RestV3.Data.ObjectDTO.Account;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Account
{
    public class CancelSpotOrderResponse : RestV3Response
    {
        [JsonConstructor]
        public CancelSpotOrderResponse(int? retCode, string retMessage, object retExtInfo, object retExtMap, CancelSpotOrderResult result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
            Result = result;
        }

        [JsonProperty("result")]
        public CancelSpotOrderResult Result { get; }
    }
}
