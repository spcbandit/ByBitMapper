using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    /// <summary>
    /// ����ͨ���� �����
    /// </summary>
    public class CancelOrderData
    {
        [JsonConstructor]
        public CancelOrderData(string orderId)
        {
            OrderId = orderId;
        }
        
        [JsonProperty("orderId")]
        public string OrderId { get; }
    }
}