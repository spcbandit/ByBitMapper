using BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account;
using JetBrains.Annotations;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Responses.Account.Positions
{
    public sealed class UserTradeResponse
    {
        [JsonConstructor]
        public UserTradeResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, double rateLimitStatus, double rateLimitResetMs, double rateLimit, UserTradePreData result)
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

        [JsonRequired, JsonProperty("ret_code")]
        public int RetCode { get; }
        [JsonRequired, JsonProperty("ret_msg")]
        public string RetMessage { get; }
        [JsonRequired, JsonProperty("ext_code")]
        public string ExtCode { get; }
        [JsonRequired, JsonProperty("ext_info")]
        public string ExtInfo { get; }
        [JsonRequired, JsonProperty("time_now")]
        public double Timestamp { get; }
        [JsonRequired, JsonProperty("rate_limit_status")]
        public double RateLimitStatus { get; }
        [JsonRequired, JsonProperty("rate_limit_reset_ms")]
        public double RateLimitResetMs { get; }
        [JsonRequired, JsonProperty("rate_limit")]
        public double RateLimit { get; }
        [JsonRequired, JsonProperty("result")]
        public UserTradePreData Result { get; }
    }
    public class UserTradePreData
    {
        [JsonConstructor]
        public UserTradePreData(string order_id, IReadOnlyList<UserTradeData> trade_list)
        {
            MainOrderId = order_id;
            MainTradeList = trade_list;
        }

        [CanBeNull, JsonProperty("order_id")]
        public string MainOrderId { get; }
        [CanBeNull, JsonProperty("trade_list")]
        public IReadOnlyList<UserTradeData> MainTradeList { get; }
    }
}
