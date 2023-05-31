using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests
{
    public sealed class APIKeyInfoRequest : KeyedRequestPayload
    {
        public APIKeyInfoRequest()
        {
        }

        internal override string EndPoint => "/v2/private/account/api-key";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();


                return res;
            }
        }
    }
}
