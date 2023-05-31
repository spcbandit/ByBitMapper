using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum
{
    public enum DataEventType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "snapshot")]
        Snapshot,
        [EnumMember(Value = "delta")]
        Delta,
        [EnumMember(Value = "AUTH_RESP")]
        AuthResp, 
        [EnumMember(Value = "COMMAND_RESP")]
        CommandResp
    }
}
