using BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Responses.Market
{
    /// <summary>
    /// USDT Perpetual Респонс : книга заказов размером 50
    /// </summary>
    public sealed class OrderBookResponse
    {
        [JsonConstructor]
        public OrderBookResponse(int retCode, string retMessage, string extCode, string extInfo, IReadOnlyList<OrderBookData> result, double timestamp)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Result = result;
            Timestamp = timestamp;
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
        public IReadOnlyList<OrderBookData> Result { get; }
    }
}
