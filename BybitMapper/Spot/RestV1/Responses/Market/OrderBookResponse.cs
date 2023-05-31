using BybitMapper.Spot.RestV1.Data.ObjectDTO.Market;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Responses.Market
{
    public class OrderBookResponse
    {
        [JsonConstructor]
        public OrderBookResponse(int? retCode, string retMessage, string extCode, object extInfo, OrderBookResultData result, double timestamp)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Result = result;
        }

        [JsonProperty("ret_code")]
        public int? RetCode { get; }
        [JsonProperty("ret_msg")]
        public string RetMessage { get; }
        [JsonProperty("ext_code")]
        public string ExtCode { get; }
        [JsonProperty("ext_info")]
        public object ExtInfo { get; }      
        [JsonProperty("result")]
        public OrderBookResultData Result { get;}

    }
}
