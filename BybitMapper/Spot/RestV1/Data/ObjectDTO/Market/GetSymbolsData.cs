using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Data.ObjectDTO.Market
{
    public class GetSymbolsData
    {
        [JsonConstructor]
        public GetSymbolsData(string name, string alias, string baseCurrency, string quoteCurrency, decimal? basePrecision, decimal? quotePrecision, decimal? minTradeQuantity, decimal? minTradeAmount, decimal? minPricePrecision, decimal? maxTradeQuantity, decimal? maxTradeAmount, int category)
        {
            Name = name;
            Alias = alias;
            BaseCurrency = baseCurrency;
            QuoteCurrency = quoteCurrency;
            BasePrecision = basePrecision;
            QuotePrecision = quotePrecision;
            MinTradeQuantity = minTradeQuantity;
            MinTradeAmount = minTradeAmount;
            MinPricePrecision = minPricePrecision;
            MaxTradeQuantity = maxTradeQuantity;
            MaxTradeAmount = maxTradeAmount;
            Category = category;
        }

        [JsonProperty("name")]
        public string Name { get; }
        [JsonProperty("alias")]
        public string Alias { get; }
        [JsonProperty("baseCurrency")]
        public string BaseCurrency { get; }
        [JsonProperty("quoteCurrency")]
        public string QuoteCurrency { get; }
        [JsonProperty("basePrecision")]
        public decimal? BasePrecision { get; }
        [JsonProperty("quotePrecision")]
        public decimal? QuotePrecision { get; }
        [JsonProperty("minTradeQuantity")]
        public decimal? MinTradeQuantity { get; }
        [JsonProperty("minTradeAmount")]
        public decimal? MinTradeAmount { get; }
        [JsonProperty("minPricePrecision")]
        public decimal? MinPricePrecision { get; }
        [JsonProperty("maxTradeQuantity")]
        public decimal? MaxTradeQuantity { get; }
        [JsonProperty("maxTradeAmount")]
        public decimal? MaxTradeAmount { get; }
        [JsonProperty("category")]
        public int Category { get; }
    }
}
