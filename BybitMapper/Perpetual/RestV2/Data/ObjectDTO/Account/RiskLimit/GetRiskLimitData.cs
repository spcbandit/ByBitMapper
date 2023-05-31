using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.RiskLimit
{
    public sealed class GetRiskLimitData
    {
        [JsonConstructor]
        public GetRiskLimitData(long id, string symbol, long limit, decimal maintainMargin, decimal startingMargin, 
            IReadOnlyList<int> section, int isLowestRisk, DateTime createdAt, DateTime updatedAt, decimal maxLeverage)
        {
            Id = id;
            Symbol = symbol;
            Limit = limit;
            MaintainMargin = maintainMargin;
            StartingMargin = startingMargin;
            Section = section;
            IsLowestRisk = isLowestRisk;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            MaxLeverage = maxLeverage;
        }

        [JsonProperty("id")]
        public long Id { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("limit")]
        public long Limit { get; }
        [JsonProperty("maintain_margin")]
        public decimal MaintainMargin { get; }
        [JsonProperty("starting_margin")]
        public decimal StartingMargin { get; }
        [JsonProperty("section")]
        public IReadOnlyList<int> Section { get; }
        [JsonProperty("is_lowest_risk")]
        public int IsLowestRisk { get; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; }
        [JsonProperty("max_leverage")]
        public decimal MaxLeverage { get; }
    }
}
