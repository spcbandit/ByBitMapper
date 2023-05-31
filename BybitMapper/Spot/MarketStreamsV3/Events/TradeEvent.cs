using System.Collections.Generic;
using BybitMapper.Spot.MarketStreamsV3.Data;
using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Events
{
    public class TradeEvent : BaseEvent
    {
        [JsonConstructor]
        public TradeEvent(string topic, string type, TradeData data, long timestamp) :
            base(topic, type, timestamp)
        {
            Data = data;
        }

        [JsonProperty("data")]
        public TradeData Data { get; }
    }
}
