using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.SymbolFilters
{
    public sealed class LotSizeFilter
    {
        [JsonConstructor]
        public LotSizeFilter(decimal maxTradingQty, decimal minTradingQty, decimal qtyStep)
        {
            MaxTradingQty = maxTradingQty;
            MinTradingQty = minTradingQty;
            QtyStep = qtyStep;
        }

        [JsonRequired, JsonProperty("max_trading_qty")]
        public decimal MaxTradingQty { get; }
        [JsonRequired, JsonProperty("min_trading_qty")]
        public decimal MinTradingQty { get; }
        [JsonRequired, JsonProperty("qty_step")]
        public decimal QtyStep { get; }
    }
}
