using System.Collections.Generic;
using BybitMapper.Spot.RestV3.Data.ObjectDTO.Account;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Responses.Account
{
    public class OrderListResponse : RestV3Response
    {
        [JsonConstructor]
        public OrderListResponse(int? retCode, string retMessage, object retExtInfo, object retExtMap, OrderListResult result, long time) :
            base(retCode, retMessage, retExtInfo, retExtMap, time)
        {
           
            Result = result;
        }

        [JsonProperty("result")]
        public OrderListResult Result { get; }
    }
    
    public class OrderListResult
    {
        [JsonConstructor]
        public OrderListResult(IReadOnlyList<OrderListData> list)
        {
            List = list;
        }

        [JsonProperty("list")]
        public IReadOnlyList<OrderListData> List { get; set; }
    }
}
