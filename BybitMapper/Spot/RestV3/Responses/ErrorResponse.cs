using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses
{
    public class ErrorResponse
    {
        [JsonConstructor]
        public ErrorResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, double rateLimitStatus, double rateLimitResetMs, double rateLimit, object result, string retMsg, object retExtInfo, long? time)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Timestamp = timestamp;
            RateLimitStatus = rateLimitStatus;
            RateLimitResetMs = rateLimitResetMs;
            RateLimit = rateLimit;
            Result = result;
            RetMsg = retMsg;
            RetExtInfo = retExtInfo;
            Time = time;
        }


        [CanBeNull, JsonProperty("ret_code")]
        public int RetCode { get; }
        [CanBeNull, JsonProperty("ret_msg")]
        public string RetMessage { get; }
        [CanBeNull, JsonProperty("ext_code")]
        public string ExtCode { get; }
        [CanBeNull, JsonProperty("ext_info")]
        public string ExtInfo { get; }
        [CanBeNull, JsonProperty("time_now")]
        public double Timestamp { get; }
        [CanBeNull, JsonProperty("rate_limit_status")]
        public double RateLimitStatus { get; }
        [CanBeNull, JsonProperty("rate_limit_reset_ms")]
        public double RateLimitResetMs { get; }
        [CanBeNull, JsonProperty("rate_limit")]
        public double RateLimit { get; }
        [CanBeNull, JsonProperty("result")]
        public object Result { get; }
        [CanBeNull, JsonProperty("ret_msg_resp")]
        public string RetMsg { get; }
        [CanBeNull, JsonProperty("ret_ext_info")]
        public object RetExtInfo { get; }
        [CanBeNull, JsonProperty("time")]
        public long? Time { get; }
    }
}
