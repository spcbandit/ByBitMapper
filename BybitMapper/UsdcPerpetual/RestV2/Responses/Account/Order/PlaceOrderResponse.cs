using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    /// <summary>
    /// Респонс выставление ордера
    /// </summary>
    public sealed class PlaceOrderResponse
    {
        [JsonConstructor]
        public PlaceOrderResponse(int retCode, string retMsg, PlaceOrderData result)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            Result = result;
        }   

        [JsonProperty("retCode")]
        public int RetCode { get; }
        [JsonProperty("retMsg")]
        public string RetMsg { get; }

        [JsonProperty("result")]
        public PlaceOrderData Result { get; }
    }
}