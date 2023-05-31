using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ActiveOrders
{
    public sealed class CancelActiveOrderData
    {
        [JsonConstructor]
        public CancelActiveOrderData(string orderId)
        {
            OrderId = orderId;
        }

        [JsonProperty("order_id")]
        public string OrderId { get; }
    }
}
