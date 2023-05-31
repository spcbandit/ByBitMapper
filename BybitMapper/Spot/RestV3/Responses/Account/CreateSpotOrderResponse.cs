using BybitMapper.Spot.RestV3.Data.ObjectDTO.Account;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Account
{
    public class CreateSpotOrderResponse : RestV3Response
    {
        [JsonConstructor]
        public CreateSpotOrderResponse(int? retCode, string retMessage, object retExtMap, object retExtInfo, CreateSpotOrderResult result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
            Result = result;
        }

        [JsonProperty("result")]
        public CreateSpotOrderResult Result { get; }
    }
}
