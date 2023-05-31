using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Prev || Next
    /// </summary>
    public enum DirectionExchangeType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "Prev")]
        Prev,
        [EnumMember(Value = "Next")]
        Next
    }
}
