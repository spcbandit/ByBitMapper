using BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO;
using BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Responses.Market
{
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

        [JsonRequired, JsonProperty("result")]
        public IReadOnlyList<OrderBookData> Result { get; }
    }
}
