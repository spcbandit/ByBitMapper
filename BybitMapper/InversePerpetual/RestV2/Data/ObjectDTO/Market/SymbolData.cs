using BybitMapper.InversePerpetual.RestV2.Data.SymbolFilters;

using Newtonsoft.Json;


namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class SymbolData
    {
        [JsonConstructor]
        public SymbolData(string name, string baseCurrency, string quoteCurrency, decimal priceScale, decimal takerFee, decimal makerFee, PriceFilter priceFilter, LotSizeFilter lotSizeFilter)
        {
            Name = name;
            BaseCurrency = baseCurrency;
            QuoteCurrency = quoteCurrency;
            PriceScale = priceScale;
            TakerFee = takerFee;
            MakerFee = makerFee;
            PriceFilter = priceFilter;
            LotSizeFilter = lotSizeFilter;
        }

        [JsonRequired, JsonProperty("name")]
        public string Name { get; }
        [JsonRequired, JsonProperty("base_currency")]
        public string BaseCurrency { get; }
        [JsonRequired, JsonProperty("quote_currency")]
        public string QuoteCurrency { get; }
        [JsonRequired, JsonProperty("price_scale")]
        public decimal PriceScale { get; }
        [JsonRequired, JsonProperty("taker_fee")]
        public decimal TakerFee { get; }
        [JsonRequired, JsonProperty("maker_fee")]
        public decimal MakerFee { get; }
        [JsonRequired, JsonProperty("price_filter")]
        public PriceFilter PriceFilter { get; }
        [JsonRequired, JsonProperty("lot_size_filter")]
        public LotSizeFilter LotSizeFilter { get; }
    }
}
