using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using System;
using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Positions
{
    public class QueryMyPositionsRequest : UsdcKeyedRequestPayload
    {
        public QueryMyPositionsRequest(CategoryType category)
        {
            Category = category;
        }
        public CategoryType Category { get; set; }
        public string Symbol { get; set; }
        public string Cursor { get; set; }
        public string Direction { get; set; }
        public int? Limit { get; set; }

        internal override string EndPoint => "/option/usdc/openapi/private/v1/query-position";
        internal override RequestMethod Method => RequestMethod.POST;

        internal override object Body
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddEnum("category", Category);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("cursor", Cursor);
                res.AddStringIfNotEmptyOrWhiteSpace("direction", Direction);
                res.AddSimpleStructIfNotNull("limit", Limit);

                return res;
            }
        }
    }
}