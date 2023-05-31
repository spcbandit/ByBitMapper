using Newtonsoft.Json;

using BybitMapper.InversePerpetual.UserStreams.Data;

namespace BybitMapper.InversePerpetual.RestV2.Responses.Account.ConditionalOrders
{
	public sealed class PlaceConditionalOrderResponse
	{
        [JsonConstructor]
        public PlaceConditionalOrderResponse(int retCode, string retMsg, string extCode, string extInfo, PlaceConditionalOrderData result, double timeNow, int rateLimitStatus, long rateLimitResetMs, int rateLimit)
		{
            RetCode = retCode;
            RetMsg = retMsg;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Result = result;
            TimeNow = timeNow;
            RateLimitStatus = rateLimitStatus;
            RateLimit = rateLimit;
		}

		[JsonProperty("ret_code")]
        public int RetCode { get; }

        [JsonProperty("ret_msg")]
        public string RetMsg { get; }

        [JsonProperty("ext_code")]
        public string ExtCode { get; }

        [JsonProperty("ext_info")]
        public string ExtInfo { get; }

        [JsonProperty("result")]
        public PlaceConditionalOrderData Result { get; }

        [JsonProperty("time_now")]
        public double TimeNow { get; }

        [JsonProperty("rate_limit_status")]
        public int RateLimitStatus { get; }

        [JsonProperty("rate_limit_reset_ms")]
        public long RateLimitResetMs { get; }

        [JsonProperty("rate_limit")]
        public int RateLimit { get; }
	}
}
