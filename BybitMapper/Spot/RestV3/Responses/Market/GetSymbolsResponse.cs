using System.Collections.Generic;
using BybitMapper.Spot.RestV3.Data.ObjectDTO.Market;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Market
{
    public class GetSymbolsResponse : RestV3Response
    {
        [JsonConstructor]
        public GetSymbolsResponse(int? retCode, string retMessage, object retExtInfo, object retExtMap, SymbolsListResult result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
          
            Result = result;
        }

        [JsonProperty("result")]
        public SymbolsListResult Result { get; }
    }


    public class SymbolsListResult
    {
        [JsonProperty("list")]
        public IReadOnlyList<GetSymbolsData> List { get; private set; }
    }
}
