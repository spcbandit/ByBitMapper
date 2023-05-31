using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Wallet
{
    public sealed class CoinBalance
    {
        [JsonConstructor]
        public CoinBalance(decimal equity, decimal availableBalnce, decimal usedMargin, decimal orderMargin, decimal positionMargin, decimal occClosingFee, decimal occFundingFee, decimal walletBalance, decimal realisedPnl, decimal unrealisedPnl, decimal cumRealisedPnl, decimal givenCash, decimal serviceCash)
        {
            Equity = equity;
            AvailableBalnce = availableBalnce;
            UsedMargin = usedMargin;
            OrderMargin = orderMargin;
            PositionMargin = positionMargin;
            OccClosingFee = occClosingFee;
            OccFundingFee = occFundingFee;
            WalletBalance = walletBalance;
            RealisedPnl = realisedPnl;
            UnrealisedPnl = unrealisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            GivenCash = givenCash;
            ServiceCash = serviceCash;
        }

        [JsonProperty("equity")]
        public decimal Equity { get; }
        [JsonProperty("available_balance")]
        public decimal AvailableBalnce { get; }
        [JsonProperty("used_margin")]
        public decimal UsedMargin { get; }
        [JsonProperty("order_margin")]
        public decimal OrderMargin { get; }
        [JsonProperty("position_margin")]
        public decimal PositionMargin { get; }
        [JsonProperty("occ_closing_fee")]
        public decimal OccClosingFee { get; }
        [JsonProperty("occ_funding_fee")]
        public decimal OccFundingFee { get; }
        [JsonProperty("wallet_balance")]
        public decimal WalletBalance { get; }
        [JsonProperty("realised_pnl")]
        public decimal RealisedPnl { get; }
        [JsonProperty("unrealised_pnl")]
        public decimal UnrealisedPnl { get; }
        [JsonProperty("cum_realised_pnl")]
        public decimal CumRealisedPnl { get; }
        [JsonProperty("given_cash")]
        public decimal GivenCash { get; }
        [JsonProperty("service_cash")]
        public decimal ServiceCash { get; }
    }
}
