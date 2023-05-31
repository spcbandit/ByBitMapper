using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.SymbolFilters
{
    /// <summary>
    /// min_leverage / max_leverage / leverage_step
    /// </summary>
    public sealed class LeverageFilter
    {
        [JsonConstructor]
        public LeverageFilter(decimal maxLeverage, decimal minLeverage, decimal stepLeverage)
        {
            MaxLeverage = maxLeverage;
            MinLeverage = minLeverage;
            StepLeverage = stepLeverage;
        }

        [JsonProperty("min_leverage")]
        public decimal MaxLeverage { get; }
        [JsonProperty("max_leverage")]
        public decimal MinLeverage { get; }
        [JsonProperty("leverage_step")]
        public decimal StepLeverage { get; }
    }
}
