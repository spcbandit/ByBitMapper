using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class PredictedFundingData
    {
        [JsonConstructor]
        public PredictedFundingData(decimal predictedFundingRate, decimal predictedFundingFee)
        {
            PredictedFundingRate = predictedFundingRate;
            PredictedFundingFee = predictedFundingFee;
        }

        [JsonRequired, JsonProperty("predicted_funding_rate")]
        public decimal PredictedFundingRate { get; }
        [JsonRequired, JsonProperty("predicted_funding_fee")]
        public decimal PredictedFundingFee { get; }
    }
}
