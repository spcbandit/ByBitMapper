using BybitMapper.InversePerpetual.UserStreams.Data;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.UserStreams.Events
{
    public sealed class OrderEvent
    {
        /// <summary>
        /// Приходит только при выставлении
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="action"></param>
        /// <param name="data"></param>
        [JsonConstructor]
        public OrderEvent(UserEventType topic, ActionType? action, IReadOnlyList<OrderData> data)
        {
            Topic = topic;
            Action = action;
            Data = data;
        }

        [JsonRequired, JsonProperty("topic")]
        public UserEventType Topic { get; }
        [CanBeNull, JsonProperty("action")]
        public ActionType? Action { get; }
        [JsonRequired, JsonProperty("data")]
        public IReadOnlyList<OrderData> Data { get; }
    }
}
