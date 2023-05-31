using BybitMapper.Handlers;
using BybitMapper.Spot.RestV1.Data.ObjectDTO.Market;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BybitMapper.Spot.RestV1.Responses.Market
{
    /// <summary>
    /// Респонс инструмента
    /// </summary>
    public sealed class LatestInformationSymbolResponse
    {
        [JsonConstructor]
        public LatestInformationSymbolResponse(int retCode, string retMessage, string extCode, object extInfo, object result)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Data = result;
        }

        [JsonProperty("ret_code")]
        public int RetCode { get; set; }
        [JsonProperty("ret_msg")]
        public string RetMessage { get; set; }
        [JsonProperty("ext_code")]
        public string ExtCode { get; set; }
        [JsonProperty("ext_info")]
        public object ExtInfo { get; set; }
        [JsonProperty("result")]
        public object Data { get; set; }

        public IReadOnlyList<LatestInformationSymboltData> DataList { get { return new BaseJsonHandler<LatestInformationSymboltData>().HandleSnapshot(Data.ToString()); } }
        public LatestInformationSymboltData DataObject { get { return new BaseJsonHandler<LatestInformationSymboltData>().HandleSingle(Data.ToString()); } }
    }
}
