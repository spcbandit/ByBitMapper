using BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Account.Account;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Account
{
    public sealed class WalletInfoResponse
    {
        [JsonConstructor]
        public WalletInfoResponse(int retCode, string retMsg, WalletInfoData result)
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
        public WalletInfoData Result { get; set; }
    }
}
