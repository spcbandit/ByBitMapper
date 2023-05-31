using Newtonsoft.Json;

using System.Collections.Generic;
using BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Market;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Market
{
    public sealed class ContractInfoResponce
    {
        [JsonConstructor]
        public ContractInfoResponce(int retCode, string retMsg, IReadOnlyList<ContractInfoData> result)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            Result = result;
        }

        [JsonProperty("retCode")]
        public int RetCode { get; }
        [JsonProperty("retMsg")]
        public string RetMsg { get; }

        [JsonProperty("result")]
        public IReadOnlyList<ContractInfoData> Result { get; }
    }
}