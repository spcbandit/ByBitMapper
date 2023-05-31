using System.Collections.Generic;
using BybitMapper.Spot.MarketStreamsV3.Data;
using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Events
{
    /// <summary>
    /// Респонс подписки на инструменты СПОТ
    /// </summary>
    public class TickerInfoEvent : BaseEvent
    {
        [JsonConstructor]
        public TickerInfoEvent(string topic, string type, string tradingPair, TickerInfoData data, long timestamp) :
            base(topic, type, timestamp)
        {
            Data = data;
        }

        [JsonProperty("data")]
        public TickerInfoData Data { get; }
    }
}
