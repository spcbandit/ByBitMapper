using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Responses.Market
{
    /// <summary>
    /// USDT Perpetual Респонс : Ликвидированные заказы, диапазон запросов - данные за последние семь дней
    /// </summary>
    public sealed class LiquidatedOrdersResponse
    {
        [JsonConstructor]
        public LiquidatedOrdersResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, IReadOnlyList<LiquidatedOrdersData> result)
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
        public IReadOnlyList<LiquidatedOrdersData> Result { get; }
    }
}
