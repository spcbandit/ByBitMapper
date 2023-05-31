using BybitMapper.Spot.MarketStreamsV3.Data;
using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Events
{
    public class DepthEvent : BaseEvent
    {
        [JsonConstructor]
        public DepthEvent(string topic, string type, DepthData data, long timestamp) :
            base(topic, type, timestamp)
        {
            Data = data;
        }

        [JsonProperty("data")]
        public DepthData Data { get; }
    }
}
