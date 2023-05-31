using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Responses.Market
{
    /// <summary>
    /// USDT Perpetual Респонс : Получить последние сделки
    /// </summary>
    public sealed class PublicTradingRecordsResponce
    {
        [JsonConstructor]
        public PublicTradingRecordsResponce(int retCode, string retMessage, string extCode, string extInfo, double timestamp, IReadOnlyList<PublicTradingRecordsData> result)
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
        public IReadOnlyList<PublicTradingRecordsData> Result { get; }
    }
}
