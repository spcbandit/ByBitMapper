using BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Market;

using Newtonsoft.Json;

using System.Collections.Generic;


namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Market
{
    public sealed class OrderBookResponse
    {
        [JsonConstructor]
        public OrderBookResponse(int retCode, string retMsg, IReadOnlyList<OrderBookData> result)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            Result = result;
        }

        [JsonRequired, JsonProperty("retCode")]
        public int RetCode { get; set; }
        [JsonRequired, JsonProperty("retMsg")]
        public string RetMsg { get; set; }

        [JsonRequired, JsonProperty("result")]
        public IReadOnlyList<OrderBookData> Result { get; set; }
    }
}