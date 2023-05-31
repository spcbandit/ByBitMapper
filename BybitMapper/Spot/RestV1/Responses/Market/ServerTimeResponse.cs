using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Responses.Market
{
    public class ServerTimeResponse
    {
        [JsonConstructor] 
        public ServerTimeResponse(int? retCode, string retMessage, int? extCode, object extInfo, ServerTimeData result)
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
        public int? ExtCode { get; }
        [JsonProperty("ext_info")]
        public object ExtInfo { get; }
        [JsonProperty("result")]
        public ServerTimeData Result { get; }
    }
    public class ServerTimeData
    {
        [JsonConstructor]
        public ServerTimeData(ulong serverTime)
        {
            ServerTime = serverTime;
        }

        [JsonProperty("serverTime")]
        public ulong ServerTime { get; }
        public long ServerTimeLong { get { return (long)ServerTime; } }
    }
}
