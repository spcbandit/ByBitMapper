using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.RiskLimit
{
    public sealed class SetRiskLimitData
    {
        [JsonConstructor]
        public SetRiskLimitData(long riskId)
        {
            RiskId = riskId;
        }

        [JsonProperty("risk_id")]
        public long RiskId { get; }
    }
}
