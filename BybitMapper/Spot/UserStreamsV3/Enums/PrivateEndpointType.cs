using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.UserStreamsV3.Enums
{
    public enum PrivateEndpointType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "outboundAccountInfo"), UsedImplicitly]
        OutboundAccountInfo,
        [EnumMember(Value = "order"), UsedImplicitly]
        Order,
        [EnumMember(Value = "ticketInfo"), UsedImplicitly]
        TicketInfo,
        [EnumMember(Value = "stopOrder"), UsedImplicitly]
        StopOrder
    }
}
