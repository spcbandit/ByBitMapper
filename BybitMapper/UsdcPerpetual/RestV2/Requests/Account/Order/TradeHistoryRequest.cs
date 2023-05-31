using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

using System;
using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Order
{
    /// <summary>
    /// Реквест история трейдов
    /// </summary>
    public sealed class TradeHistoryRequest : UsdcKeyedRequestPayload
    {
        public TradeHistoryRequest(CategoryType category, /*DateTime startTime,*/ int limit)
        {
            Category = category;
            //StartTime = startTime;
            Limit = limit;
        }
        public CategoryType Category { get; set; }
        public string Symbol { get; set; }
        public string OrderId { get; set; }
        public string OrderLinkId { get; set; }
        public DateTime StartTime
        {
            get => StartInMilliseconds.ToDateTimeFromUnixTimeMilliseconds();
            set => StartInMilliseconds = value.ToUnixTimeMilliseconds();
        }
        public long StartInMilliseconds { get; set; }
        public string Direction { get; set; }
        public int Limit { get; set; }
        public string Cursor { get; set; }
        
        internal override string EndPoint => "/option/usdc/openapi/private/v1/execution-list";
        internal override RequestMethod Method => RequestMethod.POST;

        internal override object Body
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddEnum("category", Category);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("orderId", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("orderLinkId", OrderLinkId);
                res.AddSimpleStruct("startTime", StartInMilliseconds);
                res.AddStringIfNotEmptyOrWhiteSpace("direction", Direction);
                res.AddSimpleStruct("limit", Limit);
                res.AddStringIfNotEmptyOrWhiteSpace("cursor", Cursor);

                return res;
            }
        }
    }
    
}