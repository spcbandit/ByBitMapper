using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.UserStreams.Data.Enum
{
    public enum PositionType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Liq")]
        Liq,
        [EnumMember(Value = "Adl")]
        Adl,
    }
}
