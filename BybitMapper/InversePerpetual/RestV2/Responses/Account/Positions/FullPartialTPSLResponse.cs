using BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account;
using Newtonsoft.Json;

namespace BybitMapper.InversePerpetual.RestV2.Responses.Account.Positions
{
    public class FullPartialTPSLResponse
    {
        [JsonProperty("ret_code")]
        public int? RetCode { get; set; }

        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        [JsonProperty("ext_code")]
        public string ExtCode { get; set; }

        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        [JsonProperty("result")]
        public FullPartialTPSLPositionData Result { get; set; }

        [JsonProperty("time_now")]
        public string TimeNow { get; set; }

        [JsonProperty("rate_limit_status")]
        public int? RateLimitStatus { get; set; }

        [JsonProperty("rate_limit_reset_ms")]
        public long? RateLimitResetMs { get; set; }

        [JsonProperty("rate_limit")]
        public int? RateLimit { get; set; }
    }
}