using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Market
{
    /// <summary>
    /// USDT Perpetual Реквест : общее количество контрактов, заключенных по открытым позициям.
    /// </summary>
    public sealed class OpenInterestRequest : RequestPayload
    {
        public OpenInterestRequest(string symbol, PeriodType period)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
            Period = period;
        }

        public string Symbol { get; set; }
        public PeriodType Period { get; set; }
        public int? Limit { get; set; }

        /// <summary>
        /// Такая же ссылка как у InversePerpetual
        /// </summary>
        internal override string EndPoint => "/v2/public/open-interest";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var result = new Dictionary<string, string>();
                result.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                result.AddEnum("period", Period);
                result.AddSimpleStructIfNotNull("limit", Limit);
                return result;
            }
        }
    }
}
