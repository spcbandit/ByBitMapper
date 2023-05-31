using BybitMapper.Perpetual.MarketStreams.Data.Enums;
using BybitMapper.Perpetual.MarketStreams.Data.Object;

using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Perpetual.MarketStreams.Events
{
    /// <summary>
    /// USDT Perpetual MarketStreams Формат полного ответа на запрос PDefaultEvent
    /// </summary>
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
        public bool? Success { get; }
        [CanBeNull, JsonProperty("ret_msg")]
        public string RetMsg { get; }
        [CanBeNull, JsonProperty("conn_id")]
        public string ConnId { get; }
        [CanBeNull, JsonProperty("request")]
        public DefaultRequest Request { get; }
        [JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("type")]
        public DataEventType? Type { get; }
        [CanBeNull, JsonProperty("action")]
        public ActionType? Action { get; }
        [CanBeNull, JsonProperty("data")]
        public object Data { get; }
        [CanBeNull, JsonProperty("cross_seq")]
        public string CrossSeq { get; }
        [CanBeNull, JsonProperty("timestamp_e6")]
        public long? TimestampE6 { get; }

        /// <summary>
        /// Тип отправляемого запроса Trade/Kline/OrderBook25/OrderBook200/InstrumentInfo/Liquidation
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
                else if (Topic?.Contains("candle") == true)
                { return EventPerpetualType.Kline; }
                else if (Topic?.Contains("liquidation") == true)
                { return EventPerpetualType.Liquidation; }
                #endregion
                #region [Приватные методы]
                if (Topic?.Contains("position") == true)
                { return EventPerpetualType.Position; }
                if (Topic?.Contains("execution") == true)
                { return EventPerpetualType.Execution; }
                if (Topic?.Contains("stop_order") == true)
                { return EventPerpetualType.StopOrder; }
                if (Topic?.Contains("order") == true)
                { return EventPerpetualType.Order; }
                if (Topic?.Contains("wallet") == true)
                { return EventPerpetualType.Wallet; }
                #endregion
                return EventPerpetualType.None;
            }
        }
    }
}
