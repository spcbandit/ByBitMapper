using BybitMapper.Handlers;
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
    public sealed class SymbolInfoResponse
    {
        [JsonConstructor]
        public SymbolInfoResponse(int retCode, string retMessage, string extCode, string extInfo, double timestamp, IReadOnlyList<SymbolInfoData> result)
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
        public IReadOnlyList<SymbolInfoData> Data { get; set; }
    }
}
