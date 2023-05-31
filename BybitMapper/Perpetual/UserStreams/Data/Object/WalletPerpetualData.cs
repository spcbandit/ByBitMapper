using Newtonsoft.Json;

namespace BybitMapper.Perpetual.UserStreams.Data.Object
{
    public sealed class WalletPerpetualData
    {
        /// <summary>
        /// WebSocket USDT Perpetual/Private Wallet response data
        /// </summary>
        [JsonConstructor]
        public WalletPerpetualData(decimal walletBalance, decimal availableBalance)
        {
            WalletBalance = walletBalance;
            AvailableBalance = availableBalance;
        }

        [JsonProperty("wallet_balance")]
        public decimal WalletBalance { get; }
        [JsonProperty("available_balance")]
        public decimal AvailableBalance { get; }
    }
}
