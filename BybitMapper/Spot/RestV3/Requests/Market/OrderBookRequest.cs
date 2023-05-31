using System;
using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Requests;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Requests.Market
{
    public class OrderBookRequest : RequestPayload
    {
        public OrderBookRequest([NotNull] string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }
        /// <summary>
        /// Инструмент
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Лимит ордеров, значение по умолчанию — 100. Максимальное значение — 200.
        /// </summary>
        public int? Limit { get; set; } = 100;

        internal override string EndPoint => "/spot/v3/public/quote/depth";

        internal override RequestMethod Method => RequestMethod.GET;

        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddSimpleStructIfNotNull("limit", Limit);
                return res;
            }
        }
    }
}
