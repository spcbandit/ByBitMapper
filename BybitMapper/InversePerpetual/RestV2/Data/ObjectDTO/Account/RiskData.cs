using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class RiskData
    {
        [JsonConstructor]
        public RiskData(string id, string coin, decimal limit, decimal maintainMargin, decimal startingMargin, IReadOnlyList<string> section, decimal isLowestRisk, DateTime? createdAt, DateTime? updatedAt)
        {
            Id = id;
            Coin = coin;
            Limit = limit;
            MaintainMargin = maintainMargin;
            StartingMargin = startingMargin;
            Section = section;
            IsLowestRisk = isLowestRisk;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        [JsonRequired, JsonProperty("id")]
        public string Id { get; }
        [JsonRequired, JsonProperty("coin")]
        public string Coin { get; }
        [JsonRequired, JsonProperty("limit")]
        public decimal Limit { get; }
        [JsonRequired, JsonProperty("maintain_margin")]
        public decimal MaintainMargin { get; }
        [JsonRequired, JsonProperty("starting_margin")]
        public decimal StartingMargin { get; }
        [JsonRequired, JsonProperty("section")]
        public IReadOnlyList<string> Section { get; }
        [JsonRequired, JsonProperty("is_lowest_risk")]
        public decimal IsLowestRisk { get; }
        [CanBeNull, JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }
        [CanBeNull, JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; }
    }
}
