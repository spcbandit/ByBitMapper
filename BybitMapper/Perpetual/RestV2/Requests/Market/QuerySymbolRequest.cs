using BybitMapper.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Perpetual.RestV2.Requests.Market
{
    /// <summary>
    /// USDT Perpetual Реквест : Get symbol info.
    /// </summary>
    public sealed class QuerySymbolRequest : RequestPayload
    {
        /// <summary>
        /// Такая же ссылка как у InversePerpetual
        /// </summary>
        internal override string EndPoint => "/v2/public/symbols";
        internal override RequestMethod Method => RequestMethod.GET;
    }
}
