using Newtonsoft.Json;

using System.Collections.Generic;

using BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Market;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Market
{
    public class QueryKlineResponse
    {
        [JsonConstructor]
        public QueryKlineResponse(int retCode, string retMsg, IReadOnlyList<QueryKlineData> result)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            Result = result;
        }
        [JsonRequired,JsonProperty("retCode")]
        public int RetCode { get; }
        [JsonRequired, JsonProperty("retMsg")]
        public string RetMsg { get; }

        [JsonRequired, JsonProperty("result")]
        public IReadOnlyList<QueryKlineData> Result { get; }
    }
}