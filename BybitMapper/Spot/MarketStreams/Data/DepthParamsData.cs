using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams.Data
{
    public class DepthParamsData
    {
        [JsonConstructor]
        public DepthParamsData(string realtimeInterval, bool binary)
        {
            RealtimeInterval = realtimeInterval;
            Binary = binary;
        }

        [JsonProperty("realtimeInterval")]
        public string RealtimeInterval { get; }
        [JsonProperty("binary")]
        public bool Binary { get; }
    }
}
