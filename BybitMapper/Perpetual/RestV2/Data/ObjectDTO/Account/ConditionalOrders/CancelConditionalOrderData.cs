using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ConditionalOrders
{
    public sealed class CancelConditionalOrderData
    {
        [JsonConstructor]
        public CancelConditionalOrderData(string orderId)
        {
            OrderId = orderId;
        }

        [JsonProperty("stop_order_id")]
        public string OrderId { get; }
    }
}
