using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class ReplaceConditionalData
    {
        [JsonConstructor]
        public ReplaceConditionalData(string stopOrderId)
        {
            StopOrderId = stopOrderId;
        }

        [JsonRequired, JsonProperty("stop_order_id")]
        public string StopOrderId { get; }
    }
}
