using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Wallet
{
    public class AssetExchangeRecordsRequest : KeyedRequestPayload
    {
        public AssetExchangeRecordsRequest(int? limit, string fromId, DirectionExchangeType? direction)
        {
            Limit = limit;
            FromId = fromId;
            Direction = direction;
        }

        public int? Limit { get; }
        public string FromId { get; }
        public DirectionExchangeType? Direction { get; }
        internal override string EndPoint => "/v2/private/exchange-order/list";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddStringIfNotEmptyOrWhiteSpace("from", FromId);
                res.AddEnumIfNotNull("direction", Direction);
                return res;
            }
        }
    }
}
