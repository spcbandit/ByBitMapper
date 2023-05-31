using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

using System;
using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Market
{
    /// <summary>
    /// Реквест на свечи
    /// </summary>
    public sealed class QueryKlineRequest : RequestPayload
    {
        public QueryKlineRequest(string symbol, IntervalType period, DateTime startTime)
        {
            Symbol = symbol;
            Period = period;
            StartTime = startTime;
        }
        public string Symbol { get; set; }
        public IntervalType Period { get; set; }
        public DateTime StartTime
        {
            get => StartInMilliseconds.ToDateTimeFromUnixTimeMilliseconds();
            set => StartInMilliseconds = value.ToUnixTimeMilliseconds();
        }
        public long StartInMilliseconds { get; set; }

        public int? Limit { get; set; }
        
        internal override string EndPoint => "/perpetual/usdc/openapi/public/v1/kline/list";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.Add("symbol", Symbol);
                res.AddEnum("period", Period);
                res.AddSimpleStruct("startTime", StartInMilliseconds/1000);
                res.AddSimpleStructIfNotNull("limit", Limit);
                return res;
            }
        }
    }
}