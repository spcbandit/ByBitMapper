using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.UserStreamsV3.Events
{
    public class BaseEvent
    {
        [JsonConstructor]
        public BaseEvent(string topic, string type, string ts)
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
        public string Timestamp { get; }
    }
}
