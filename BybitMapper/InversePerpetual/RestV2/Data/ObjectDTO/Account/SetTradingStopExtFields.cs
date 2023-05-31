using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public class SetTradingStopExtFields
    {
        [JsonProperty("trailing_active")]
        public string TrailingActive { get; set; }

        [JsonProperty("sl_trigger_by")]
        public string SlTriggerBy { get; set; }
        public TriggerPriceType? SlTriggerByEnum
        {
            get { return SlTriggerBy?.ToEnum<TriggerPriceType>(); }
        }

        [JsonProperty("tp_trigger_by")]
        public string TpTriggerBy { get; set; }
        public TriggerPriceType? TpTriggerByEnum
        {
            get { return TpTriggerBy?.ToEnum<TriggerPriceType>(); }
        }
        [JsonProperty("v")]
        public int? V { get; set; }

        [JsonProperty("mm")]
        public int? Mm { get; set; }
    }
}