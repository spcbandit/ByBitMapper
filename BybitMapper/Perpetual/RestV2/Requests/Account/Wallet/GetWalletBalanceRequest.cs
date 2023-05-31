using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Wallet
{
    /// <summary>
    /// USDT Perpetual формат реквеста GetWalletBalance
    /// </summary>
    public sealed class GetWalletBalanceRequest : KeyedRequestPayload
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coin"></param>
        public GetWalletBalanceRequest(/*string coin*/)
        {
            //Coin = coin;
        }

        /// <summary>
        /// Not a pair like symbol. This like a [BTC]
        /// </summary>
        public string Coin { get; set; }
        internal override string EndPoint => "/v2/private/wallet/balance";

        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("coin", Coin);
                return res;
            }
        }

    }
}
