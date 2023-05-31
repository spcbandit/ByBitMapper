﻿using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ActiveOrders;

using Newtonsoft.Json;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Responses.Account.ActiveOrders
{
    /// <summary>
    /// USDT Perpetual класс для парсинга response QueryActiveOrder
    /// </summary>
    public sealed class QueryActiveOrderResponse
    {
        [JsonConstructor]
        public QueryActiveOrderResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp,
            double rateLimitStatus, double rateLimitResetMs, double rateLimit, IReadOnlyList<PlaceActiveOrderData> result)
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
        //одинаковый ответ с PlaceActiveOrder
        public IReadOnlyList<PlaceActiveOrderData> Result { get; }
    }
}
