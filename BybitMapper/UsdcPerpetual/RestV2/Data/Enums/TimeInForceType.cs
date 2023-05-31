using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    public enum TimeInForceType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "GoodTillCancel"), UsedImplicitly]
        GoodTillCancel,
        [EnumMember(Value = "ImmediateOrCancel"), UsedImplicitly]
        ImmediateOrCancel,
        [EnumMember(Value = "FillOrKill"), UsedImplicitly]
        FillOrKill,
        [EnumMember(Value = "PostOnly"), UsedImplicitly]
        PostOnly
    }
}