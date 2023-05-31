using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class LastFundingRateData
    {
        [JsonConstructor]
        public LastFundingRateData(string symbol, decimal fundingRate, long fundingRateTimestamp)
        {
            Symbol = symbol;
            FundingRate = fundingRate;
            FundingRateTimestamp = fundingRateTimestamp;
        }

        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("funding_rate")]
        public decimal FundingRate { get; }
        [JsonRequired, JsonProperty("funding_rate_timestamp")]
        public long FundingRateTimestamp { get; }
    }
}
