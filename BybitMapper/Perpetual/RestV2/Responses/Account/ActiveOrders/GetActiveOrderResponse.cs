using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ActiveOrders;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Responses.Account.ActiveOrders
{
    /// <summary>
    /// USDT Perpetual класс для парсинга response GetActiveOrder
    /// </summary>
    public sealed class GetActiveOrderResponse
    {
        [JsonConstructor]
        public GetActiveOrderResponse(int retCode, string retMessage, string extCode, double timestamp, 
            double rateLimitStatus, double rateLimitResetMs, double rateLimit, GetActiveOrderData result)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
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
        [JsonProperty("time_now")]
        public double Timestamp { get; }
        [JsonProperty("rate_limit_status")]
        public double RateLimitStatus { get; }
        [JsonProperty("rate_limit_reset_ms")]
        public double RateLimitResetMs { get; }
        [JsonProperty("rate_limit")]
        public double RateLimit { get; }
        [JsonProperty("result")]
        public GetActiveOrderData Result { get; }
    }
}
