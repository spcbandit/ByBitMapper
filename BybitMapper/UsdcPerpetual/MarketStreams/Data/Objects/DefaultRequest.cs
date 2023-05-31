using JetBrains.Annotations;
using Newtonsoft.Json;

using BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum;

using System.Collections.Generic;


namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class DefaultRequest
    {
        [JsonConstructor]
        public DefaultRequest(SubType resultSub, List<string> resultTopics)
        {
            ResultSub = resultSub;
            ResultTopics = resultTopics;
        }

        [CanBeNull, JsonProperty("op")]
        public SubType ResultSub { get; }
        [CanBeNull, JsonProperty("args")]
        public List<string> ResultTopics { get; }
    }
}
