using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Events
{
    public class BaseEvent
    {
        [JsonConstructor]
        public BaseEvent(string topic, string type, long ts)
        {
            Topic = topic;
            Type = type;
            Timestamp = ts;
        }
        [CanBeNull, JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("type")]
        public string Type { get; }
        [CanBeNull, JsonProperty("ts")]
        public long Timestamp { get; }
    }
}
