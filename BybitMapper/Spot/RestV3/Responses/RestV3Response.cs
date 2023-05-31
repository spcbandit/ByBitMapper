using BybitMapper.Spot.RestV3.Data.ObjectDTO.Account;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses
{
    public class RestV3Response
    {
        [JsonConstructor]
        public RestV3Response(int? retCode, string retMessage, [CanBeNull] object retExtInfo, [CanBeNull] object retExtMap, [CanBeNull] long time)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            RetExtMap = retExtMap;
            RetExtInfo = retExtInfo;
            Time = time;
        }

        [JsonProperty("retCode")]
        public int? RetCode { get; }
        [JsonProperty("retMsg")]
        public string RetMessage { get; }
        [CanBeNull, JsonProperty("retExtInfo")] 
        public object RetExtInfo { get; }
        [CanBeNull, JsonProperty("retExtMap")]
        public object RetExtMap { get; }
        [CanBeNull, JsonProperty("time")]
        public long? Time { get; }
    }

}
