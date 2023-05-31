using Newtonsoft.Json;
using System;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class GetLastFundingRateData
    {
        [JsonConstructor]
        public GetLastFundingRateData(string symbol, decimal fundingRate, DateTime fundingRateTimestamp)
        {
            Symbol = symbol;
            FundingRate = fundingRate;
            FundingRateTimestamp = fundingRateTimestamp;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("funding_rate")]
        public decimal FundingRate { get; }
        [JsonProperty("funding_rate_timestamp")]
        public DateTime? FundingRateTimestamp { get; }
    }
}
