using BybitMapper.Spot.UserStreams.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.UserStreams.Events
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
                if (Eventtype?.Contains("executionReport") == true)
                { return EventType.ExecutionReport; }
                else if (Eventtype?.Contains("ticketInfo") == true)
                { return EventType.TicketInfo; }
                return EventType.None;
            }
        }
    }
}
