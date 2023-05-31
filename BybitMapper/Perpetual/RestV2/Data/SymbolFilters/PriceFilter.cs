using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.SymbolFilters
{
    /// <summary>
    /// min_price / max_price / tick_size
    /// </summary>
    public sealed class PriceFilter
    {
        [JsonConstructor]
        public PriceFilter(decimal minPrice, decimal maxPrice, decimal tickSize)
        {
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            TickSize = tickSize;
        }

        [JsonProperty("min_price")]
        public decimal MinPrice { get; }
        [JsonProperty("max_price")]
        public decimal MaxPrice { get; }
        [JsonProperty("tick_size")]
        public decimal TickSize { get; }
    }
}
