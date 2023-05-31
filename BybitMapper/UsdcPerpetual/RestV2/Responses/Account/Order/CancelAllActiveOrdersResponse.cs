using System;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
	/// <summary>
    /// Респонс отмена всех активных ордеров.
    /// </summary>
	public sealed class CancelAllActiveOrdersResponse
	{
		[JsonConstructor]
        public CancelAllActiveOrdersResponse(int retCode, string retMsg, CancelOrderData result)
        {
            RetCode = retCode;
            RetMsg = retMsg;
        }

        [JsonProperty("retCode")]
        public int RetCode { get; set; }
        [JsonProperty("retMsg")]
        public string RetMsg { get; set; }
	}
}

