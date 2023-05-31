using BybitMapper.Handlers;
using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position;
using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Responses.Account.Position
{
    /// <summary>
    /// USDT Perpetual класс для парсинга response  MyPosition
    /// </summary>
    public sealed class MyPositionResponse
    {
        [JsonConstructor]
        public MyPositionResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp,
            double rateLimitStatus, double rateLimitResetMs, double rateLimit, object result)
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
        public object Result { get; }
        public IReadOnlyList<MyPositionData> ResultObject { get { return new BaseJsonHandler<MyPositionData>().HandleSnapshot(Result.ToString()); } }
        public IReadOnlyList<DataObjectPosition> ResultArray { get { return new BaseJsonHandler<DataObjectPosition>().HandleSnapshot(Result.ToString()); } }
    }
    public class DataObjectPosition
    {
        [JsonConstructor]
        public DataObjectPosition(MyPositionData data)
        {
            Data = data;
        }

        [JsonProperty("data")]
        public MyPositionData Data { get; }
    }
}
