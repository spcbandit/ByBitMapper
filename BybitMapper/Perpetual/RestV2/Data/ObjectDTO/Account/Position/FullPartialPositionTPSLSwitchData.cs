using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position
{
    public sealed class FullPartialPositionTPSLSwitchData
    {
        [JsonConstructor]
        public FullPartialPositionTPSLSwitchData(string isIsolated)
        {
            IsIsolated = isIsolated;
            TpSlModeType = IsIsolated.ToEnum<TpSlModeType>();
        }

        [JsonProperty("tpslMode")] /*tp_sl_mode*/
        public string IsIsolated { get; }
        public TpSlModeType TpSlModeType { get; }
    }
}
