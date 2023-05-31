using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.SymbolFilters
{
    /// <summary>
    /// max_trading_qty / min_trading_qty / qty_step
    /// </summary>
    public sealed class LotSizeFilter
    {
        [JsonConstructor]
        public LotSizeFilter(decimal maxTradingQty, decimal minTradingQty, decimal qtyStep)
        {
            MaxTradingQty = maxTradingQty;
            MinTradingQty = minTradingQty;
            QtyStep = qtyStep;
        }

        [JsonProperty("max_trading_qty")]
        public decimal MaxTradingQty { get; }
        [JsonProperty("min_trading_qty")]
        public decimal MinTradingQty { get; }
        [JsonProperty("qty_step")]
        public decimal QtyStep { get; }
    }
}
