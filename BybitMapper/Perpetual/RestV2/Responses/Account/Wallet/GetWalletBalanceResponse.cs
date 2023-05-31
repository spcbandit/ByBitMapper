﻿using System.Collections.Generic;

using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Wallet;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Responses.Account.Wallet
{
    /// <summary>
    /// USDT Perpetual класс для парсинга response GetWalletBalance
    /// https://bybit-exchange.github.io/docs/futuresV2/inverse/#t-balance
    /// </summary>
    public sealed class GetWalletBalanceResponse
    {
        [JsonConstructor]
        public GetWalletBalanceResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, double rateLimitStatus, double rateLimitResetMs, double rateLimit, IReadOnlyDictionary<string, CoinBalance> coinInfo)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Timestamp = timestamp;
            RateLimitStatus = rateLimitStatus;
            RateLimitResetMs = rateLimitResetMs;
            RateLimit = rateLimit;
            CoinInfo = coinInfo;
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
        public IReadOnlyDictionary<string, CoinBalance> CoinInfo { get; } 
    }
}
