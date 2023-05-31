using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Responses.Market
{
    /// <summary>
    /// USDT Perpetual Респонс : Query mark price kline (like Query Kline but for mark price).
    /// </summary>
    public sealed class QueryMarkPriceKlineResponse
    {
        [JsonConstructor]
        public QueryMarkPriceKlineResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, IReadOnlyList<QueryMarkPriceKlineData> result)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Timestamp = timestamp;
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
        [JsonProperty("result")]
        public IReadOnlyList<QueryMarkPriceKlineData> Result { get; }
    }
}
