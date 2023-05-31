using BybitMapper.Spot.MarketStreams.Data;

using JetBrains.Annotations;

using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreams.Events
{
    /// <summary>
    /// Дефолтная подписка
    /// </summary>
    public class DefaultEvent
    {
        [JsonConstructor]
        public DefaultEvent(string topic, string auth)
        {
            Topic = topic;
            Auth = auth;
        }
        [CanBeNull, JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("auth")]
        public string Auth { get; }

        public EventType? WSEventType
        {
            get
            {
                if (Topic?.Contains("trade") == true)
                { return EventType.Trade; }
                if (Topic?.Contains("realtimes") == true)
                { return EventType.Realtimes; }
                else if (Topic?.Contains("diffDepth") == true)
                { return EventType.Depth; }
                return EventType.None;
            }
        }
    }
}
