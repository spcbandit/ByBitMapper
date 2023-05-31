using JetBrains.Annotations;

using System.Runtime.Serialization;


namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    /// <summary>
    /// AddedLiquidity || RemovedLiquidity
    /// </summary>
    public enum LiquidityType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "AddedLiquidity"), UsedImplicitly]
        AddedLiquidity,
        [EnumMember(Value = "RemovedLiquidity"), UsedImplicitly]
        RemovedLiquidity
    }
}
