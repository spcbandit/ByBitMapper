using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Funding
{
    /// <summary>
    /// USDT Perpetual формат реквеста PredictedFundingRateMyFundingFee
    /// </summary>
    public sealed class PredictedFundingRateMyFundingFeeRequest : KeyedRequestPayload
    {
        public PredictedFundingRateMyFundingFeeRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; set; }
        internal override string EndPoint => "/private/linear/funding/predicted-funding";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);

                return res;
            }
        }
    }
}
