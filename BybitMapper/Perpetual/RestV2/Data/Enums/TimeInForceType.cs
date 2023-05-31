using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    public enum TimeInForceType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "GoodTillCancel")]
        GoodTillCancel,
        [EnumMember(Value = "ImmediateOrCancel")]
        ImmediateOrCancel,
        [EnumMember(Value = "FillOrKill")]
        FillOrKill,
        [EnumMember(Value = "PostOnly")]
        PostOnly
    }
}
