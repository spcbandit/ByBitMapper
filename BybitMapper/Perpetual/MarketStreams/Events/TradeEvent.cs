using BybitMapper.Perpetual.MarketStreams.Data.Object;

using JetBrains.Annotations;
using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.MarketStreams.Events
{
    /// <summary>
    /// USDT Perpetual MarketStreams Формат полного ответа на запрос TradeEvent
    /// </summary>
    public sealed class TradeEvent
    {
        [JsonConstructor]
        public TradeEvent(string topic, IReadOnlyList<TradeDate> data)
        {
            Topic = topic;
            Data = data;
        }

        [JsonRequired, JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("data")]
        public IReadOnlyList<TradeDate> Data { get; }
    }
}
