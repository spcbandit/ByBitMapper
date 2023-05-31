using System.Collections.Generic;
using BybitMapper.Spot.RestV3.Data.ObjectDTO.Account;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Account
{
    public class TradeHistoryResponse : RestV3Response
    {
        [JsonConstructor]
        public TradeHistoryResponse(int? retCode, string retMessage, object retExtInfo, object retExtMap, TradeHistoryListResult result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
            Result = result;
        }

        [JsonProperty("result")]
        public TradeHistoryListResult Result { get; }
    }

    public class TradeHistoryListResult
    {
        [JsonProperty("list")]
        public IReadOnlyList<TradeHistoryData> List { get; set; }
    }
}
