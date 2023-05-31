using BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects;

using JetBrains.Annotations;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Events
{
    public sealed class PDefaultEvent
    {
        /// <summary>
        /// Формат полного ответа на запрос
        /// </summary>
        /// <param name="success"></param>
        /// <param name="retMsg"></param>
        /// <param name="connId"></param>
        /// <param name="request"></param>
        /// <param name="topic"></param>
        /// <param name="type"></param>
        /// <param name="action"></param>
        /// <param name="data"></param>
        /// <param name="crossSeq"></param>
        /// <param name="timestampE6"></param>
        [JsonConstructor]
        public PDefaultEvent(bool? success, string retMsg, string connId, DefaultRequest request,
            string topic, DataEventType? type, ActionType? action, object data, string crossSeq, long? timestampE6)
        {
            Success = success;
            RetMsg = retMsg;
            ConnId = connId;
            Request = request;
            Topic = topic;
            Type = type;
            Action = action;
            Data = data;
            CrossSeq = crossSeq;
            TimestampE6 = timestampE6;
        }

        [CanBeNull, JsonProperty("success")]
        public bool? Success { get; set; }
        [CanBeNull, JsonProperty("ret_msg")]
        public string RetMsg { get; set; }
        [CanBeNull, JsonProperty("conn_id")]
        public string ConnId { get; set; }
        [CanBeNull, JsonProperty("request")]
        public DefaultRequest Request { get; set; }
        [JsonProperty("topic")]
        public string Topic { get; set; }
        [CanBeNull, JsonProperty("type")]
        public DataEventType? Type { get; set; }
        [CanBeNull, JsonProperty("action")]
        public ActionType? Action { get; set; }
        [CanBeNull, JsonProperty("data")]
        public object Data { get; set; }
        [CanBeNull, JsonProperty("cross_seq")]
        public string CrossSeq { get; set; }
        [CanBeNull, JsonProperty("timestamp_e6")]
        public long? TimestampE6 { get; set; }

        /// <summary>
        /// Тип отправляемого запроса Trade/OrderBook25/OrderBook200/trade/position/execution/order
        /// </summary>
        public EventPerpetualType? PerpetualEventType
        {
            get
            {
                #region [Публичные методы]
                if (Topic?.Contains("orderBookL2_25") == true)
                { return EventPerpetualType.OrderBook25; }
                else if (Topic?.Contains("orderBook_200") == true)
                { return EventPerpetualType.OrderBook200; }
                else if (Topic?.Contains("trade") == true)
                { return EventPerpetualType.Trade; }
                else if (Topic?.Contains("instrument_info") == true)
                { return EventPerpetualType.InstrumentInfo; }
                #endregion
                #region [Приватные методы]
                if (Topic?.Contains("position") == true)
                { return EventPerpetualType.Positions; }
                if (Topic?.Contains("trade") == true)
                { return EventPerpetualType.Execution; }
                if (Topic?.Contains("order") == true)
                { return EventPerpetualType.Order; }
                #endregion
                return EventPerpetualType.None;
            }
        }
    }
}
