using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position
{
    public sealed class AddReduceMarginData
    {
        [JsonConstructor]
        public AddReduceMarginData(PositionListResultData positionListResult, decimal wallet_balance, decimal availableBalance)
        {
            PositionListResult = positionListResult;
            Wallet_balance = wallet_balance;
            AvailableBalance = availableBalance;
        }

        [JsonProperty("PositionListResult")]
        public PositionListResultData PositionListResult { get; }
        [JsonProperty("WalletBalance")]
        public decimal Wallet_balance { get; }
        [JsonProperty("available_balance")]
        public decimal AvailableBalance { get; }
    }
}
