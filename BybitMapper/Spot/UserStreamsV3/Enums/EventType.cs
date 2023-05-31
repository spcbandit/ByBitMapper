
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.UserStreamsV3.Enums
{
    public enum EventType
    {
        None,
        OutboundAccountInfo,
        Order,
        TicketInfo,
        StopOrder
    }
}
