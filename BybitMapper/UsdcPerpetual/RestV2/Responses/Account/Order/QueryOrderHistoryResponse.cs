using System.Collections.Generic;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    /// <summary>
    /// QueryOrderHistoryResponse
    /// </summary>
    public sealed class QueryOrderHistoryResponse
    {
        [JsonConstructor]
        public QueryOrderHistoryResponse(ResultData result, string retCode, string retMsg)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            Result = result;
        }
        [JsonProperty("result")]
        public ResultData Result { get; set; }

        [JsonProperty("retCode")]
        public string RetCode { get; set; }
        [ JsonProperty("retMsg")]
        public string RetMsg { get; set; }
    }

    public sealed class ResultData
    {
        public ResultData(string cursor, int resultTotalSize, IReadOnlyList<QueryOrderHistoryData> dataList)
        {
            Cursor = cursor;
            ResultTotalSize = resultTotalSize;
            DataList = dataList;
        }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
        [JsonProperty("resultTotalSize")]
        public int ResultTotalSize { get; set; }
        [JsonProperty("datalist")]
        public IReadOnlyList<QueryOrderHistoryData> DataList { get; set; }
    }
}