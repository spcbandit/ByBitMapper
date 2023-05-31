using System;
using System.Collections.Generic;

using JetBrains.Annotations;
using Newtonsoft.Json;

using BybitMapper.InversePerpetual.UserStreams.Data;

// https://bybit-exchange.github.io/docs/futuresV2/inverse/#t-websocketstoporder

namespace BybitMapper.InversePerpetual.UserStreams.Events
{
    public sealed class StopOrderEvent
    {
        [JsonConstructor]
        public StopOrderEvent(UserEventType topic, IReadOnlyList<StopOrderData> data)
        {
            Topic = topic;
            Data = data;
        }

        [JsonProperty("topic")]
        public UserEventType Topic { get; }

        [JsonProperty("data")]
        public IReadOnlyList<StopOrderData> Data { get; }
    }
}
