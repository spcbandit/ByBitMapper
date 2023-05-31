using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
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
