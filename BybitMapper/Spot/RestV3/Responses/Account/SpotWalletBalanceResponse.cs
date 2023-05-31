using System.Collections.Generic;
using BybitMapper.Spot.RestV3.Data.ObjectDTO.Account;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Account
{
    public class SpotWalletBalanceResponse : RestV3Response
    {
        [JsonConstructor]
        public SpotWalletBalanceResponse(int? retCode, string retMessage, object retExtMap, object retExtInfo, BalancesResult balancesResult, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
            BalancesResult = balancesResult;
        }

        [JsonProperty("result")]
        public BalancesResult BalancesResult { get; }
    }

    public class BalancesResult
    {
        [JsonConstructor]
        public BalancesResult(IReadOnlyList<BalancesData> balancesData)
        {
            BalancesData = balancesData;
        }

        [JsonProperty("balances")]
        public IReadOnlyList<BalancesData> BalancesData { get; set; }
    }
}
