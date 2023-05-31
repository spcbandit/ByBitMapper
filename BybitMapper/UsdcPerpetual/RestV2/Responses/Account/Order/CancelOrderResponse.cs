using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    /// <summary>
    /// Респонс отмена ордера
    /// </summary>
    public sealed class CancelOrderResponse
    {
        [JsonConstructor]
        public CancelOrderResponse(int retCode, string retMsg, CancelOrderData result)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            Result = result;
        }
        
        [JsonProperty("retCode")]
        public int RetCode { get; set; }
        [JsonProperty("retMsg")]
        public string RetMsg { get; set; }

        [JsonProperty("result")]
        public CancelOrderData Result { get; set; }
    }
}