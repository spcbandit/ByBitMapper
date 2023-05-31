using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class ExtFieldsConditionalData
    {
        [JsonConstructor]
        public ExtFieldsConditionalData(string stopOrderType, string triggerPriceType, decimal basePrice, string extendDirection, decimal triggerPrice, string opForm, string remark, string oReqNum)
        {
            StopOrderType = stopOrderType;
            TriggerPriceType = triggerPriceType;
            TriggerPriceTypeEnum = TriggerPriceType.ToEnum<TriggerPriceType>();
            BasePrice = basePrice;
            ExtendDirection = extendDirection;
            TriggerPrice = triggerPrice;
            OpForm = opForm;
            Remark = remark;
            OReqNum = oReqNum;
        }

        [JsonProperty("stop_order_type")]
        public string StopOrderType { get; }
        [JsonProperty("trigger_by")]
        public string TriggerPriceType { get; }
        public TriggerPriceType TriggerPriceTypeEnum { get; }
        [JsonProperty("base_price")]
        public decimal BasePrice { get; }
        [JsonProperty("expected_direction")]
        public string ExtendDirection { get; }
        [JsonProperty("trigger_price")]
        public decimal TriggerPrice { get; }
        [JsonProperty("op_from")]
        public string OpForm { get; }
        [JsonProperty("remark")]
        public string Remark { get; }
        [JsonProperty("o_req_num")]
        public string OReqNum { get; }
    }
}
