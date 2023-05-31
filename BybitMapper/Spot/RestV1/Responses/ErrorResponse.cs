using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Responses
{
    public class ErrorResponse
    {
        [JsonConstructor]
        public ErrorResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, double rateLimitStatus, double rateLimitResetMs, double rateLimit, object result)
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

    }
}
