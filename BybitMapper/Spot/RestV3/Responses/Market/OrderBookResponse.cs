using BybitMapper.Spot.RestV3.Data.ObjectDTO.Market;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Market
{
    public class OrderBookResponse : RestV3Response
    {
        [JsonConstructor]
        public OrderBookResponse(int? retCode, string retMessage, object retExtInfo, object retExtMap, OrderBookResultData result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
            Result = result;
        }

        [JsonProperty("result")]
        public OrderBookResultData Result { get; }
    }
}
