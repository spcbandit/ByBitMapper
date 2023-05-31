using System.Collections.Generic;

using BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Account.Positions;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Positions
{
    public sealed class QueryMyPositionsResponse
    {
        [JsonConstructor]
        public QueryMyPositionsResponse(string retCode, string retMsg, ResultPositionData result)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            Result = result;
        }
        [JsonProperty("retCode")]
        public string RetCode { get; set; }
        [JsonProperty("retMsg")]
        public string RetMsg { get; set; }
        [JsonProperty("result")]
        public ResultPositionData Result { get; set; }
    }

    public sealed class ResultPositionData
    {
        public ResultPositionData(string cursor, int resultTotalSize, IReadOnlyList<QueryMyPositionsData> dataList)
        {
            Cursor = cursor;
            ResultTotalSize = resultTotalSize;
            DataList = dataList;
        }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
        [JsonProperty("resultTotalSize")]
        public int ResultTotalSize { get; set; }
        [JsonProperty("dataList")]
        public IReadOnlyList<QueryMyPositionsData> DataList { get; set; }
    }
}
