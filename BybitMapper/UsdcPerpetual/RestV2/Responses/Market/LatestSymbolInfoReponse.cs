using BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Market;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Market
{
    /// <summary>
    /// Получение информации об инструменте USDC
    /// </summary>
    public sealed class LatestSymbolInfoReponse
    {
        [JsonConstructor]
        public LatestSymbolInfoReponse(int retCode, string retMsg, LatestSymbolInfoData result)
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
        public LatestSymbolInfoData Result { get; set; }
    }
}
