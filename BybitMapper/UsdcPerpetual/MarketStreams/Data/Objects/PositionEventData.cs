using System.Collections.Generic;
using BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Account.Positions;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class PositionEventData
    {
        [JsonConstructor]
        public PositionEventData(IReadOnlyList<QueryMyPositionsData> result, string version, string baseLine,
            string dataType)
        {
            Result = result;
            Version = version;
            BaseLine = baseLine;
            DataType = dataType;
        }
        [JsonRequired, JsonProperty("result")]
        public IReadOnlyList<QueryMyPositionsData> Result { get; set; }
        [JsonRequired, JsonProperty("version")]
        public string Version { get; set; }
        [JsonRequired, JsonProperty("baseLine")]
        public string BaseLine { get; set; }
        [JsonRequired, JsonProperty("dataType")]
        public string DataType { get; set; }

    }
}