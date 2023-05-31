using BybitMapper.Perpetual.UserStreams.Data.Enum;
using BybitMapper.Perpetual.UserStreams.Data.Object;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.UserStreams.Events
{
    /// <summary>
    /// WebSocket USDT Perpetual/Private Position response
    /// </summary>
    public sealed class PositionPerpetualEvent
    {
        [JsonConstructor]
        public PositionPerpetualEvent(UserEventType topic, ActionType? action, IReadOnlyList<PositionPerpetualEventData> data)
        {
            Topic = topic;
            Action = action;
            Data = data;
        }

        [JsonProperty("topic")]
        public UserEventType Topic { get; }
        [JsonProperty("action")]
        public ActionType? Action { get; }
        [JsonRequired, JsonProperty("data")]
        public IReadOnlyList<PositionPerpetualEventData> Data { get; }
    }
}
