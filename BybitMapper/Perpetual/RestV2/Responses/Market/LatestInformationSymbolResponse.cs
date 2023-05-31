using BybitMapper.Handlers;
using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Responses.Market
{
    /// <summary>
    /// USDT Perpetual Респонс : Последняя информация о symbol
    /// </summary>
    public sealed class LatestInformationSymbolResponse
    {
        [JsonConstructor]
        public LatestInformationSymbolResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, IReadOnlyList<LatestInformationSymbolData> result)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Timestamp = timestamp;
            Data = result;
        }

        [JsonProperty("ret_code")]
        public int RetCode { get; set; }
        [JsonProperty("ret_msg")]
        public string RetMessage { get; set; }
        [JsonProperty("ext_code")]
        public string ExtCode { get; set; }
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }
        [JsonProperty("time_now")]
        public double Timestamp { get; set; }

        [JsonProperty("result")]
        public IReadOnlyList<LatestInformationSymbolData> Data { get; set; }
    }
}
