using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class OrderEvent
    {
        [JsonConstructor]
        public OrderEvent(string id, string topic, string creationTime, OrderEventData data)
        {
            Id = id;
            Topic = topic;
            CreationTime = creationTime;
            Data = data;
        }
        [JsonRequired, JsonProperty("id")]
        public string Id { get; set; }
        [JsonRequired, JsonProperty("topic")]
        public string Topic { get; set; }
        [JsonRequired, JsonProperty("creationTime")]
        public string CreationTime { get; set; }
        [JsonRequired, JsonProperty("data")]
        public OrderEventData Data { get; set; }

    }
}