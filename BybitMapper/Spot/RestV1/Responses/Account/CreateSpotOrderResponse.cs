using BybitMapper.Spot.RestV1.Data.ObjectDTO.Account;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Responses.Account
{
    public class CreateSpotOrderResponse
    {
        [JsonConstructor]
        public CreateSpotOrderResponse(int? retCode, string retMessage, string extCode, object extInfo, CreateSpotOrderResult result)
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
        public CreateSpotOrderResult Result { get; }
    }
}
