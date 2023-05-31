using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Responses.Account.Position
{
    /// <summary>
    /// USDT Perpetual класс для парсинга response 
    /// Одинаковые респонсы:
    /// SetAutoAddMargiResponse
    /// Cross/IsolatedMarginSwitch
    /// SetLeverage
    /// SetTradingStop
    /// </summary>
    public sealed class SetAutoAddMarginResponse
    {
        [JsonConstructor]
        public SetAutoAddMarginResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp,
            double rateLimitStatus, double rateLimitResetMs, double rateLimit, string result)
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
        [JsonProperty("rate_limit_status")]
        public double RateLimitStatus { get; }
        [JsonProperty("rate_limit_reset_ms")]
        public double RateLimitResetMs { get; }
        [JsonProperty("rate_limit")]
        public double RateLimit { get; }
        [JsonProperty("result")]
        public string Result { get; }
    }
}
