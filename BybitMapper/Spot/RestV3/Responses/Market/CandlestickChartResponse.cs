using System.Collections.Generic;
using BybitMapper.Spot.RestV3.Data.ObjectDTO.Market;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Market
{
    public class CandlestickChartResponse : RestV3Response
    {
        [JsonConstructor]
        public CandlestickChartResponse(int? retCode, string retMessage, object retExtInfo, object retExtMap, double timestamp, CandleListResult result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
            Result = result;
        }

        [JsonProperty("result")]
        public CandleListResult Result { get; }
    }

    public class CandleListResult
    {
        [JsonProperty("list")]
        public IReadOnlyList<Candle> List { get; private set; }
    }

}
