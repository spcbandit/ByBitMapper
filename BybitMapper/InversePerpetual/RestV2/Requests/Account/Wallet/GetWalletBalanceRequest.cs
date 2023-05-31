using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Wallet
{
    public class GetWalletBalanceRequest : KeyedRequestPayload
    {
        /// <summary>
        /// [BTC, ETH, EOS, XRP, USDT]
        /// </summary>
        /// <param name="coin"></param>
        public GetWalletBalanceRequest(string coin)
        {
            //if (string.IsNullOrEmpty(coin))
            //    throw new ArgumentException("Coin can not be null or empty!", coin);
            Coin = coin;
        }

        /// <summary>
        /// Not a pair like symbol. This like a [BTC]
        /// </summary>
        public string Coin { get; set; }
        internal override string EndPoint => "/v2/private/wallet/balance";

        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("coin", Coin);
                return res;
            }
        }

    }
}
