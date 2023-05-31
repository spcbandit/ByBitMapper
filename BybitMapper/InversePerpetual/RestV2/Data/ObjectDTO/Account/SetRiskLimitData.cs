using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
   public sealed class SetRiskLimitData
    {
        [JsonConstructor]
        public SetRiskLimitData(PositionRiskLimitData position, RiskData risk)
        {
            Position = position;
            Risk = risk;
        }

        [JsonRequired, JsonProperty("position")]
        public PositionRiskLimitData Position { get; }
        [JsonRequired, JsonProperty("risk")]
        public RiskData Risk { get; }
    }
}
