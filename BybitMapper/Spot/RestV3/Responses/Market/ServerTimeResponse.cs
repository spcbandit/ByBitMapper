using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Market
{
    public class ServerTimeResponse : RestV3Response
    {
        [JsonConstructor]
        public ServerTimeResponse(int? retCode, string retMessage, object retExtInfo, object retExtMap, ServerTimeData result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
            Result = result;
        }

        [JsonProperty("result")]
        public ServerTimeData Result { get; }
    }
    public class ServerTimeData
    {
        [JsonConstructor]
        public ServerTimeData(ulong serverTime)
        {
            ServerTime = serverTime;
        }

        [JsonProperty("serverTime")]
        public ulong ServerTime { get; }
        public long ServerTimeLong { get { return (long)ServerTime; } }
    }
}
