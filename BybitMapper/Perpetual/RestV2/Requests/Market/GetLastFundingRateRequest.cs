using BybitMapper.Extensions;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Market
{
    /// <summary>
    /// USDT Perpetual Реквест : Ставка финансирования в 0/8/16 по Гринвичу
    /// </summary>
    public sealed class GetLastFundingRateRequest : RequestPayload
    {
        public GetLastFundingRateRequest(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }
        public string Symbol { get; set; }
        internal override string EndPoint => "/public/linear/funding/prev-funding-rate";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                return res;
            }
        }
    }
}
