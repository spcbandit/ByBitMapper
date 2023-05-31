using System.Collections.Generic;
using BybitMapper.Handlers;
using BybitMapper.Spot.RestV3.Data.ObjectDTO.Market;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Market
{
    public class LatestInformationSymbolResponse : RestV3Response
    {
        [JsonConstructor]
        public LatestInformationSymbolResponse(int? retCode, string retMessage, object retExtInfo, object retExtMap, LatestInformationSymbolResult result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
            Result = result;
        }

        [JsonProperty("result")]
        public LatestInformationSymbolResult Result { get; }
    }
    public class LatestInformationSymbolResult
    {
        [JsonProperty("list")]
        public IReadOnlyList<LatestInformationSymbolData> List { get; private set; }
    }
}
