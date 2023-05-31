using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Wallet
{
    /// <summary>
    /// USDT Perpetual формат реквеста AssetExchangeRecords
    /// </summary>
    public sealed class AssetExchangeRecordsRequest : KeyedRequestPayload
    {
        public AssetExchangeRecordsRequest()
        {

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
