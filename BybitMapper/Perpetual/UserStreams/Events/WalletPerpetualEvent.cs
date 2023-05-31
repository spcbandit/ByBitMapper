using BybitMapper.Perpetual.UserStreams.Data.Enum;
using BybitMapper.Perpetual.UserStreams.Data.Object;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.UserStreams.Events
{
    /// <summary>
    /// WebSocket USDT Perpetual/Private Wallet response 
    /// </summary>
    public sealed class WalletPerpetualEvent
    {
        [JsonConstructor]
        public WalletPerpetualEvent(UserEventType topic, ActionType? action, IReadOnlyList<WalletPerpetualData> data)
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
        public IReadOnlyList<WalletPerpetualData> Data { get; }
    }
}
