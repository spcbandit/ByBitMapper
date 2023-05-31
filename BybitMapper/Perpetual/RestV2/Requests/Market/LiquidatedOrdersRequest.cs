using BybitMapper.Extensions;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Market
{
    /// <summary>
    /// USDT Perpetual Реквест : Ликвидированные заказы, диапазон запросов - данные за последние семь дней
    /// </summary>
    public sealed class LiquidatedOrdersRequest : RequestPayload
    {
        public LiquidatedOrdersRequest(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }

        public string Symbol { get; set; }
        public decimal? From { get; set; }
        public int? Limit { get; set; }
        public DateTime? StartTime
        {
            get => StartInMilliseconds?.ToDateTimeFromUnixTimeMilliseconds();
            set => StartInMilliseconds = value?.ToUnixTimeMilliseconds();
        }
        public DateTime? EndTime
        {
            get => EndInMilliseconds?.ToDateTimeFromUnixTimeMilliseconds();
            set => EndInMilliseconds = value?.ToUnixTimeMilliseconds();
        }

        private long? StartInMilliseconds { get; set; }
        private long? EndInMilliseconds { get; set; }

        /// <summary>
        /// Такая же ссылка как у InversePerpetual
        /// </summary>
        internal override string EndPoint => "/v2/public/liq-records";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("from", From);
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddSimpleStructIfNotNull("start_time", StartTime);
                res.AddSimpleStructIfNotNull("end_time", EndTime);
                return res;
            }
        }
    }
}
