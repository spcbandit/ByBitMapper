using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class ReplaceActiveOrderData
    {
        [JsonConstructor]
        public ReplaceActiveOrderData(string orderId)
        {
            OrderId = orderId;
        }

        [JsonRequired, JsonProperty("order_id")]
        public string OrderId { get; }
    }
}
