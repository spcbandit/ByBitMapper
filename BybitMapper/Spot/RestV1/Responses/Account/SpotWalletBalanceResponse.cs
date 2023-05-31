using System.Collections.Generic;

using Newtonsoft.Json;

using BybitMapper.Spot.RestV1.Data.ObjectDTO.Account;

namespace BybitMapper.Spot.RestV1.Responses.Account
{
    //https://bybit-exchange.github.io/docs/spot/v1/#t-wallet

    public class SpotWalletBalanceResponse
    {
        [JsonConstructor]
        public SpotWalletBalanceResponse(int? retCode, string retMessage, string extCode, object extInfo, BalacesResult balacesResult)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            BalacesResult = balacesResult;
        }

        [JsonProperty("ret_code")]
        public int? RetCode { get; }
        [JsonProperty("ret_msg")]
        public string RetMessage { get; }
        [JsonProperty("ext_code")]
        public string ExtCode { get; }
        [JsonProperty("ext_info")]
        public object ExtInfo { get; }
        [JsonProperty("result")]
        public BalacesResult BalacesResult { get; }
    }

    public class BalacesResult 
    {
        [JsonConstructor]
        public BalacesResult(IReadOnlyList<BalancesData> balancesData)
        {
            BalancesData = balancesData;
        }

        [JsonProperty("balances")]
        public IReadOnlyList<BalancesData> BalancesData { get; set; }
    }
}
