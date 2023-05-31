using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Market
{
    /// <summary>
    /// USDT Perpetual Реквест : Query mark price kline (like Query Kline but for mark price).
    /// </summary>
    public sealed class QueryMarkPriceKlineRequest : RequestPayload
    {
        public QueryMarkPriceKlineRequest(string symbol, IntervalType interval, DateTime from)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);

            Symbol = symbol;
            Interval = interval;
            From = from;
        }

        public string Symbol { get; set; }
        public IntervalType Interval { get; set; }
        public DateTime From
        {
            get => FromInSeconds.ToDateTimeFromUnixTimeSeconds();
            set => FromInSeconds = value.ToUnixTimeSeconds();
        }

        public int? Limit { get; set; }
        private long FromInSeconds { get; set; }

        internal override string EndPoint => "/public/linear/mark-price-kline";

        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("interval", Interval);
                res.AddSimpleStruct("from", FromInSeconds);
                res.AddSimpleStructIfNotNull("limit", Limit);

                return res;
            }
        }
    }
}
