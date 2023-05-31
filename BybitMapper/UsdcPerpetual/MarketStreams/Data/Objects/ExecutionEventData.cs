using System.Collections.Generic;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class ExecutionEventData
    {
        [JsonConstructor]
        public ExecutionEventData(IReadOnlyList<ExecutionEventResultData> result, string version, string baseLine)
        {
            Result = result;
            Version = version;
            BaseLine = baseLine;
        }
        [JsonProperty("result")]
        public IReadOnlyList<ExecutionEventResultData> Result { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("baseLine")]
        public string BaseLine { get; set; }

    }
}