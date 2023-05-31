using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.SymbolFilters
{
    public sealed class PriceFilter
    {
        [JsonConstructor]
        public PriceFilter(decimal minPrice, decimal maxPrice, decimal tickSize)
        {
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            TickSize = tickSize;
        }

        [JsonRequired, JsonProperty("min_price")]
        public decimal MinPrice { get; }
        [JsonRequired, JsonProperty("max_price")]
        public decimal MaxPrice { get; }
        [JsonRequired, JsonProperty("tick_size")]
        public decimal TickSize { get; }
    }
}
