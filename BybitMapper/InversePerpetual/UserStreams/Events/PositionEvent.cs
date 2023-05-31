using BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account;
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
    public sealed class PositionEvent
    {
        /// <summary>
        /// При подписке приходят пустые позиции по BTC
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="action"></param>
        /// <param name="data"></param>
        [JsonConstructor]
        public PositionEvent(UserEventType topic, ActionType? action, IReadOnlyList<PositionRiskLimitData> data)
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
        public IReadOnlyList<PositionRiskLimitData> Data { get; }
    }
}
