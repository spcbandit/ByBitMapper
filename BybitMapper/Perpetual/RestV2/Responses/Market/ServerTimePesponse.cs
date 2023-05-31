using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Responses.Market
{
    public sealed class ServerTimeResponse
    {
        [JsonConstructor]
        public ServerTimeResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, object result)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Timestamp = timestamp;
            Result = result;
        }

        [JsonProperty("ret_code")]
        public int RetCode { get; }
        [JsonProperty("ret_msg")]
        public string RetMessage { get; }
        [JsonProperty("ext_code")]
        public string ExtCode { get; }
        [JsonProperty("ext_info")]
        public string ExtInfo { get; }
        [JsonProperty("time_now")]
        public double Timestamp { get; }
        [JsonProperty("result")]
        public object Result { get; }
    }
}
