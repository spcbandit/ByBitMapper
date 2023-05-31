using BybitMapper.Extensions;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Market
{
    /// <summary>
    /// USDT Perpetual Реквест : Последняя информация о symbol
    /// </summary>
    public sealed class LatestInformationSymbolRequest : RequestPayload
    {
        public LatestInformationSymbolRequest()
        {
        }
        public string Symbol { get; set; }

        /// <summary>
        /// Такая же ссылка как у InversePerpetual
        /// </summary>
        internal override string EndPoint => "/v2/public/tickers";
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
