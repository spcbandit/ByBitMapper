using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Funding;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Responses.Account.Funding
{
    /// <summary>
    /// USDT Perpetual класс для парсинга response PredictedFundingRateMyFundingFee
    /// </summary>
    public sealed class PredictedFundingRateMyFundingFeeResponse
    {
        [JsonConstructor]
        public PredictedFundingRateMyFundingFeeResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp,
            double rateLimitStatus, double rateLimitResetMs, double rateLimit, PredictedFundingRateMyFundingFeeData result)
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
        public PredictedFundingRateMyFundingFeeData Result { get; }
    }
}
