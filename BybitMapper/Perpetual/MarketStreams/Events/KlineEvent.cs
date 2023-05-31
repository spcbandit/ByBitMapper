using BybitMapper.Perpetual.MarketStreams.Data.Object;

using JetBrains.Annotations;
using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.MarketStreams.Events
{
    /// <summary>
    /// USDT Perpetual MarketStreams Формат полного ответа на запрос KlineEvent
    /// </summary>
    public sealed class KlineEvent
    {
        [JsonConstructor]
        public KlineEvent(string topic, IReadOnlyList<KlineDate> data, long timestampE6)
        {
            Topic = topic;
            Data = data;
            TimestampE6 = timestampE6;
        }

        [JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("data")]
        public IReadOnlyList<KlineDate> Data { get; }
        [CanBeNull, JsonProperty("timestamp_e6")]
        public long TimestampE6 { get; }
    }
}
