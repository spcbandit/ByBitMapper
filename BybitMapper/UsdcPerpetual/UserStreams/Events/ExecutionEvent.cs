using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class ExecutionEvent
    {
        [JsonConstructor]
        public ExecutionEvent(string id, string topic, long creationTime, DataData data)
        {
            Id = id;
            Topic = topic;
            CreationTime = creationTime;
            Data = data;
        }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("topic")]
        public string Topic { get; set; }
        [JsonProperty("creationTime")]
        public long CreationTime { get; set; }
        [JsonProperty("data")]
        public DataData Data { get; set; }

    }

    public sealed class DataData
    {
        [JsonConstructor]
        public DataData(IReadOnlyList<TradeHistoryData> data)
        {
            Result = data;
        }

        [JsonProperty("result")]
        public IReadOnlyList<TradeHistoryData> Result { get; set; }

    }
}