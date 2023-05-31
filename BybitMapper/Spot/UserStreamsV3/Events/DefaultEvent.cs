using BybitMapper.Spot.UserStreamsV3.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.UserStreamsV3.Events
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
                if (Topic?.Contains("stopOrder") == true)
                { return EventType.StopOrder; }
                else if (Topic?.Contains("order") == true)
                { return EventType.Order; }
                else if (Topic?.Contains("ticketInfo") == true)
                { return EventType.TicketInfo; }
                else if (Topic?.Contains("outboundAccountInfo") == true)
                { return EventType.OutboundAccountInfo; }
                return EventType.None;
            }
        }
    }
}
