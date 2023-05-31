using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.RiskLimit;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Responses.Account.RiskLimit
{
    /// <summary>
    /// USDT Perpetual класс для парсинга response GetRiskLimit
    /// </summary>
    public sealed class GetRiskLimitResponse
    {
        [JsonConstructor]
        public GetRiskLimitResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp,
            IReadOnlyList<GetRiskLimitData> result)
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
        public IReadOnlyList<GetRiskLimitData> Result { get; }
    }
}
