using JetBrains.Annotations;

using System.Runtime.Serialization;


namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Статус позиции. В АПИ НЕТ ЧЕТКО ПРОПИСАННЫХ ТИПОВ
    /// </summary>
    public enum PositionStatusType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "NORMAL"), UsedImplicitly]
        Normal,
        [EnumMember(Value = "Liq"), UsedImplicitly]
        Liq,
        [EnumMember(Value = "Adl"), UsedImplicitly]
        Adl
    }
}
