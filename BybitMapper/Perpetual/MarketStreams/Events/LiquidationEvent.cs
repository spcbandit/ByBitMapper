using BybitMapper.Perpetual.MarketStreams.Data.Object;

using JetBrains.Annotations;
using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.MarketStreams.Events
{
    /// <summary>
    /// USDT Perpetual MarketStreams Формат полного ответа на запрос LiquidationEvent
    /// </summary>
    public sealed class LiquidationEvent
    {
        [JsonConstructor]
        public LiquidationEvent(string topic, IReadOnlyList<LiquidationData> data)
        {
            Topic = topic;
            Data = data;
        }

        [JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("data")]
        public IReadOnlyList<LiquidationData> Data { get; }
    }
}
