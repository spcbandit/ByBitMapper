using BybitMapper.Extensions;
using BybitMapper.Spot.MarketStreams.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams.Subscriptions
{
    public sealed class CombineStremsSubs
    {
        public static string Create(string symbol, PublicEndpointType topicType, SubType eventType, bool binary = false)
        {
            var result = new Dictionary<string, object>();
            var @params = new Dictionary<string, object>();            
            result.Add("topic", topicType.GetEnumMemberAttributeValue());
            result.Add("event", eventType.GetEnumMemberAttributeValue());
            result.Add("symbol", symbol);
            @params.Add("binary", binary);
            result.Add("params", @params);
            var res = JsonConvert.SerializeObject(result);
            return res;
        }
    }
}
