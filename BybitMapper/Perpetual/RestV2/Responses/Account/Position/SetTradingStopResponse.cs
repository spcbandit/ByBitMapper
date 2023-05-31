using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Responses.Account.Position
{
    public class SetTradingStopResponse
    {
        [JsonProperty("ret_code")]
        public int? RetCode { get; set; }
        [JsonProperty("ret_msg")]
        public string RetMessage { get; set; }
        [JsonProperty("ext_code")]
        public string ExtCode { get; set; }
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }
        [JsonProperty("time_now")]
        public double? Timestamp { get; set; }
        [JsonProperty("rate_limit_status")]
        public double? RateLimitStatus { get; set; }
        [JsonProperty("rate_limit_reset_ms")]
        public double? RateLimitResetMs { get; set; }
        [JsonProperty("rate_limit")]
        public double? RateLimit { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}