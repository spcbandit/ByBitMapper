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
    public sealed class ExecutionEvent
    {
        /// <summary>
        /// Приходят только после исполнения ордера
        /// </summary>
        /// <param name="topic"></param> 
        /// <param name="action"></param>
        /// <param name="data"></param>
        [JsonConstructor]
        public ExecutionEvent(UserEventType topic, ActionType? action, IReadOnlyList<ExecutionData> data)
        {
            Topic = topic;
            Action = action;
            Data = data;
        }

        [JsonProperty("topic")]
        public UserEventType Topic { get; }
        [CanBeNull, JsonProperty("action")]
        public ActionType? Action { get; }
        [JsonProperty("data")]
        public IReadOnlyList<ExecutionData> Data { get; }
    }
}
