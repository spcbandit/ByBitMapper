using BybitMapper.Perpetual.RestV2.Data.SymbolFilters;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class QuerySymbolData
    {
        [JsonConstructor]
        public QuerySymbolData(string name, string alias, string status, string baseCurrency, string quoteCurrency, decimal priceScale, decimal takerFee, decimal makerFee, LeverageFilter leverageFilter, PriceFilter priceFilter, LotSizeFilter lotSizeFilter)
        {
            Name = name;
            Alias = alias;
            Status = status;
            BaseCurrency = baseCurrency;
            QuoteCurrency = quoteCurrency;
            PriceScale = priceScale;
            TakerFee = takerFee;
            MakerFee = makerFee;
            LeverageFilter = leverageFilter;
            PriceFilter = priceFilter;
            LotSizeFilter = lotSizeFilter;
        }

        [JsonProperty("name")]
        public string Name { get; }
        [JsonProperty("alias")]
        public string Alias { get; }
        [JsonProperty("status")]
        public string Status { get; }
        [JsonProperty("base_currency")]
        public string BaseCurrency { get; }
        [JsonProperty("quote_currency")]
        public string QuoteCurrency { get; }
        [JsonProperty("price_scale")]
        public decimal PriceScale { get; }
        [JsonProperty("taker_fee")]
        public decimal TakerFee { get; }
        [JsonProperty("maker_fee")]
        public decimal MakerFee { get; }
        [JsonProperty("leverage_filter")]
        public LeverageFilter LeverageFilter { get; }
        [JsonProperty("price_filter")]
        public PriceFilter PriceFilter { get; }
        [JsonProperty("lot_size_filter")]
        public LotSizeFilter LotSizeFilter { get; }

    }
}
