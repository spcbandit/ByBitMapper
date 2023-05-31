using System;
using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Spot.MarketStreamsV3.Data;
using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Subscriptions
{
    public sealed class CombineStreamsSubs
    {
        public static string Create(string symbol, PublicEndpointType topicType, SubType eventType, KlineIntervalType intervalType = KlineIntervalType.Unrecognized)
        {
            var result = new Dictionary<string, object>();
            var args = new List<string>();
            result.Add("op", eventType.GetEnumMemberAttributeValue());

            var endPoint = $"{topicType.GetEnumMemberAttributeValue()}.{symbol}";
            if (topicType == PublicEndpointType.Kline)
            {
                endPoint =
                    $"{topicType.GetEnumMemberAttributeValue()}.{intervalType.GetEnumMemberAttributeValue()}.{symbol}";
            }

            args.Add(endPoint);
            result.Add("args", args);
            var res = JsonConvert.SerializeObject(result);
            return res;
        }

    }
}
