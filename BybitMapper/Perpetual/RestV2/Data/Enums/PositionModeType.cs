using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    public enum PositionModeType
    {
        [EnumMember(Value = "MergedSingle")]
        OneWay,
        [EnumMember(Value = "BothSide")]
        Hedge
    }
}