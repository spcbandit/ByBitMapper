using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Account.Account
{
    //https://bybit-exchange.github.io/docs/usdc/perpetual/#t-usdcaccountinfo

    public class WalletInfoData
    {
        [JsonConstructor]
        public WalletInfoData(decimal walletBalance, decimal accountMM, decimal bonus,
            decimal accountIM, decimal? totalSessionRPL, decimal equity, decimal? totalRPL, 
            decimal marginBalance, decimal availableBalance, decimal? totalSessionUPL)
        {
            WalletBalance = walletBalance;
            AccountMM = accountMM;
            Bonus = bonus;
            AccountIM = accountIM; 
            TotalSessionRPL = totalSessionRPL;
            Equity = equity;
            TotalRPL = totalRPL;
            MarginBalance = marginBalance;
            AvailableBalance = availableBalance;
            TotalSessionUPL = totalSessionUPL;
        }

        [JsonProperty("walletBalance")]
        public decimal WalletBalance { get; }

        [JsonProperty("accountMM")]
        public decimal AccountMM { get; }

        [JsonProperty("bonus")]
        public decimal Bonus { get; }

        [JsonProperty("accountIM")]
        public decimal AccountIM { get; }

        [JsonProperty("totalSessionRPL")]
        public decimal? TotalSessionRPL { get; }

        [JsonProperty("equity")]
        public decimal Equity { get; }

        [JsonProperty("totalRPL")]
        public decimal? TotalRPL { get; }

        [JsonProperty("marginBalance")]
        public decimal MarginBalance { get; }

        [JsonProperty("availableBalance")]
        public decimal AvailableBalance { get; }

        [JsonProperty("totalSessionUPL")]
        public decimal? TotalSessionUPL { get; }
    }
}
