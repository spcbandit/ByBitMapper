using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    /// <summary>
    /// QueryUnfilledResponse
    /// </summary>
    public sealed class QueryUnfilledResponse
    {
        [JsonConstructor]
        public QueryUnfilledResponse(ResultData result, string retCode,
            string retMsg)
        {
            Result = result;
            RetCode = retCode;
            RetMsg = retMsg;
        }
        [JsonProperty("result")]
        public ResultData Result { get; set; }

        [JsonProperty("retCode")]
        public string RetCode { get; set; }
        [JsonProperty("retMsg")]
        public string RetMsg { get; set; }

    }
}