using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public class ExtFieldsData
    {
        [JsonConstructor]
        public ExtFieldsData(bool? closeOnTrigger, string origOrderType, decimal? priopXReqPrice, string opFrom, string remark, decimal? oReqNum, string xReqType)
        {
            CloseOnTrigger = closeOnTrigger;
            OrigOrderType = origOrderType;
            PriopXReqPrice = priopXReqPrice;
            OpFrom = opFrom;
            Remark = remark;
            OReqNum = oReqNum;
            XReqType = xReqType;
        }

        [CanBeNull, JsonProperty("close_on_trigger")]
        public bool? CloseOnTrigger { get; }
        [CanBeNull, JsonProperty("orig_order_type")]
        public string OrigOrderType { get; }
        [CanBeNull, JsonProperty("prior_x_req_price")]
        public decimal? PriopXReqPrice { get; }
        [CanBeNull, JsonProperty("op_from")]
        public string OpFrom { get; }
        [CanBeNull, JsonProperty("remark")]
        public string Remark { get; }
        [CanBeNull, JsonProperty("o_req_num")]
        public decimal? OReqNum { get; }
        [CanBeNull, JsonProperty("xreq_type")]
        public string XReqType { get; }
    }
}
