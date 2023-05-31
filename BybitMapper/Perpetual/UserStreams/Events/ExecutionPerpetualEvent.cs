using BybitMapper.Perpetual.UserStreams.Data.Enum;
using BybitMapper.Perpetual.UserStreams.Data.Object;
using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.UserStreams.Events
{
    /// <summary>
    /// WebSocket USDT Perpetual/Private Execution response
    /// </summary>
    public sealed class ExecutionPerpetualEvent
    {
        [JsonConstructor]
        public ExecutionPerpetualEvent(UserEventType topic, ActionType? action, IReadOnlyList<ExecutionEventData> data)
        {
            Topic = topic;
            Action = action;
            Data = data;
        }

        [JsonProperty("topic")]
        public UserEventType Topic { get; }
        [JsonProperty("action")]
        public ActionType? Action { get; }
        [JsonProperty("data")]
        public IReadOnlyList<ExecutionEventData> Data { get; }
    }
}
