using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public class FullPartialTPSLPositionData
    {
        [JsonProperty("tp_sl_mode")]
        public string TpSlMode { get; set; }
        public TPSLModeType? TpSlModeEnum
        {
            get { return TpSlMode?.ToEnum<TPSLModeType>(); }
        }
    }
}