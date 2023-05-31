using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Funding
{
    public sealed class PredictedFundingRateMyFundingFeeData
    {
        [JsonConstructor]
        public PredictedFundingRateMyFundingFeeData(decimal rate, decimal fee)
        {
            Rate = rate;
            Fee = fee;
        }

        [JsonProperty("predicted_funding_rate")]
        public decimal Rate { get; }
        [JsonProperty("predicted_funding_fee")]
        public decimal Fee { get; }
    }
}
