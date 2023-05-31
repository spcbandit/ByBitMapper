using System.Collections.Generic;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    /// <summary>
    /// Респонс история трейдов
    /// </summary>
    public sealed class TradeHistoryResponse
    {
        [JsonConstructor]
        public TradeHistoryResponse(string retCode, string retMsg, ResultTradeData result)
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
        public ResultTradeData Result { get; set; }
    }

    public sealed class ResultTradeData
    {
        public ResultTradeData(string cursor, int resultTotalSize, IReadOnlyList<TradeHistoryData> dataList)
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
        public IReadOnlyList<TradeHistoryData> DataList { get; set; }
    }
}