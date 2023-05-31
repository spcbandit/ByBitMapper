using System.Collections.Generic;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class OrderEventData
    {
        [JsonConstructor]
        public OrderEventData(IReadOnlyList<OrderEventResultData> result, string version, string baseLine,
            string dataType)
        {
            Result = result;
            Version = version;
            BaseLine = baseLine;
            DataType = dataType;
        }
        [JsonRequired, JsonProperty("result")]
        public IReadOnlyList<OrderEventResultData> Result { get; set; }
        [JsonRequired, JsonProperty("version")]
        public string Version { get; set; }
        [JsonRequired, JsonProperty("baseLine")]
        public string BaseLine { get; set; }
        [JsonRequired, JsonProperty("dataType")]
        public string DataType { get; set; }

    }
}