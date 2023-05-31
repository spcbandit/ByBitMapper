using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Market
{
    public sealed class SymbolOpenInterestRequest : RequestPayload
    {
        public SymbolOpenInterestRequest([NotNull] string symbol, PeriodType period,[CanBeNull] int? limit)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can no be null!", symbol);

            Symbol = symbol;
            Period = period;
            Limit = limit;
        }

        public string Symbol { get; }
        public PeriodType Period { get; }
        public int? Limit { get; }
        internal override string EndPoint => "/v2/public/open-interest";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("period", Period);
                res.AddSimpleStructIfNotNull("limit", Limit);
                return res;
            }
        }
    }
}
