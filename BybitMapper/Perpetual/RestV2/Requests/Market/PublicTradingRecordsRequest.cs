using BybitMapper.Extensions;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Market
{
    /// <summary>
    /// USDT Perpetual Реквест : Получить последние сделки
    /// </summary>
    public sealed class PublicTradingRecordsRequest : RequestPayload
    {
        public PublicTradingRecordsRequest(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }

        public string Symbol { get; set; }
        public int? Limit { get; set; }
        internal override string EndPoint => "/public/linear/recent-trading-records";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var result = new Dictionary<string, string>();
                result.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                result.AddSimpleStructIfNotNull("limit", Limit);
                return result;
            }
        }
    }
}
