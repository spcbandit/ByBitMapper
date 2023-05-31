using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class GetRiskLimitData
    {
        [JsonConstructor]
        public GetRiskLimitData(string id, string coin, decimal maintainMargin, decimal startingMargin, IReadOnlyList<string> section, decimal isLowwestRisk, DateTime? createdAt, DateTime? updateAt)
        {
            Id = id;
            Coin = coin;
            MaintainMargin = maintainMargin;
            StartingMargin = startingMargin;
            Section = section;
            IsLowwestRisk = isLowwestRisk;
            CreatedAt = createdAt;
            UpdateAt = updateAt;
        }

        [JsonRequired, JsonProperty("id")]
        public string Id { get; }
        [JsonRequired, JsonProperty("coin")]
        public string Coin { get; }
        [JsonRequired, JsonProperty("maintain_margin")]
        public decimal MaintainMargin { get; }
        [JsonRequired, JsonProperty("starting_margin")]
        public decimal StartingMargin { get; }
        [JsonRequired, JsonProperty("section")]
        public IReadOnlyList<string> Section { get; }
        [JsonRequired, JsonProperty("is_lowest_risk")]
        public decimal IsLowwestRisk { get; }
        [CanBeNull, JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }
        [CanBeNull, JsonProperty("updated_at")]
        public DateTime? UpdateAt { get; }
    }
}
