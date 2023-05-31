using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;
using BybitMapper.Extensions;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Positions
{
    public class UserTradesRequest : KeyedRequestPayload
    {
        public UserTradesRequest(string symbol, string orderId, DateTime? startTimeInDate,/*long? startTime,*/ int? page, int? limit, OrderSortType? orderBy)
        {
            StartTimeInDate = startTimeInDate;
            OrderId = orderId;
            Symbol = symbol;
           // StartTime = startTime;
            Page = page;
            Limit = limit;
            OrderBy = orderBy;
        }

        [CanBeNull]
        public string OrderId { get; }
        public string Symbol { get; }
        /// <summary>
        /// Millisecond
        /// </summary>
        [CanBeNull]
        public long? StartTime { get; set; }
        [CanBeNull]
        public DateTime? StartTimeInDate
        {
            get
            {
                if (StartTime.HasValue)
                {
                    return StartTime.Value.ToDateTimeFromUnixTimeMilliseconds();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue)
                {
                    StartTime = value.Value.ToUnixTimeMilliseconds();
                }
            }
        }
        [CanBeNull]
        public int? Page { get; }
        [CanBeNull]
        public int? Limit { get; }
        [CanBeNull]
        public OrderSortType? OrderBy { get; }
        internal override string EndPoint => "/v2/private/execution/list";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("order_id",OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol",Symbol);

                res.AddSimpleStructIfNotNull("start_time", StartTime);

                res.AddSimpleStructIfNotNull("page", Page);
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddEnumIfNotNull("order", OrderBy);

                return res;
            }
        }
    }
}
