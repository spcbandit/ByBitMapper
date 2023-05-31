using BybitMapper.InversePerpetual.MarketStreams.Data;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Events
{
    public sealed class KlineEvent
    {
        [JsonConstructor]
        public KlineEvent(string topic, DataEventType? type, ActionType? action, IReadOnlyList<KlineData> data, string crossSeq, long? timestampE6)
        {
            Topic = topic;
            Type = type;
            Action = action;
            Data = data;
            CrossSeq = crossSeq;
            TimestampE6 = timestampE6;
        }

        [JsonRequired, JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("type")]
        public DataEventType? Type { get; }
        [CanBeNull, JsonProperty("action")]
        public ActionType? Action { get; }
        [CanBeNull, JsonProperty("data")]
        public IReadOnlyList<KlineData> Data { get; }
        [CanBeNull, JsonProperty("cross_seq")]
        public string CrossSeq { get; }
        [CanBeNull, JsonProperty("timestamp_e6")]
        public long? TimestampE6 { get; }
    }
}
