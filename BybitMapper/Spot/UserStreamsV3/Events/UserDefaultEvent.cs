using BybitMapper.Spot.UserStreamsV3.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.UserStreamsV3.Events
{
    public class UserDefaultEvent
    {
        [JsonConstructor]
        public UserDefaultEvent(string eventtype)
        {
            Eventtype = eventtype;
        }
        [CanBeNull, JsonProperty("e")]
        public string Eventtype { get; }
        [CanBeNull, JsonProperty("E")]
        public string Event { get; }


        public EventType? WSEventType
        {
            get
            {
                if (Eventtype?.Contains("order") == true)
                { return EventType.Order; }
                else if (Eventtype?.Contains("ticketInfo") == true)
                { return EventType.TicketInfo; }
                return EventType.None;
            }
        }
    }
}
