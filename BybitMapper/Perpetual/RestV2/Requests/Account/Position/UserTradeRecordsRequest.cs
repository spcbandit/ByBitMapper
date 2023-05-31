using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    /// <summary>
    /// USDT Perpetual формат реквеста  UserTradeRecords
    /// </summary>
    public sealed class UserTradeRecordsRequest : KeyedRequestPayload
    {
        public UserTradeRecordsRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; set; }
        public ExecType ExecType { get; set; }
        public decimal? Page { get; set; }
        public decimal? Limit { get; set; }

        public DateTime? StartTime
        {
            get => StartTimeInSeconds?.ToDateTimeFromUnixTimeSeconds();
            set
            {
                if (value != null)
                    StartTimeInSeconds = value.Value.ToUnixTimeSeconds();
            }
        }
        public DateTime? EndTime
        {
            get => EndTimeInSeconds?.ToDateTimeFromUnixTimeMilliseconds();
            set
            {
                if (value != null)
                    EndTimeInSeconds = value.Value.ToUnixTimeMilliseconds();
            }
        }
        private long? StartTimeInSeconds { get; set; }
        private long? EndTimeInSeconds { get; set; }

        internal override string EndPoint => "/private/linear/trade/execution/list";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddSimpleStructIfNotNull("start_time", StartTimeInSeconds);
                res.AddSimpleStructIfNotNull("end_time", EndTimeInSeconds);
                res.AddEnum("exec_type", ExecType);
                res.AddDecimalIfNotNull("page", Page);
                res.AddDecimalIfNotNull("limit", Limit);

                return res;
            }
        }
    }
}
