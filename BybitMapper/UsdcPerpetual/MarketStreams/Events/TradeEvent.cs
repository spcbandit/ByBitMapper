using System.Collections.Generic;

using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class TradeEvent
    {
        [JsonConstructor]
        public TradeEvent(string topic, IReadOnlyList<TradeEventData> data)
        {
            Topic = topic;
            Data = data;
        }
        [CanBeNull, JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("data")]
        public IReadOnlyList<TradeEventData> Data { get; }
    }
}