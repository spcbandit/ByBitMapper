using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Market
{
    /// <summary>
    /// респонс время биржи
    /// </summary>
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
        public int RetCode { get; set; }
        [JsonProperty("ret_msg")]
        public string RetMessage { get; set; }
        [JsonProperty("ext_code")]
        public string ExtCode { get; set; }
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }
        [JsonProperty("time_now")]
        public double Timestamp { get; set; }
        [JsonProperty("result")]
        public object Result { get; set; }
    }
}
