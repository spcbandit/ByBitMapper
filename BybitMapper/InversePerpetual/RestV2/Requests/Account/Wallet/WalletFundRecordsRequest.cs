using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Wallet
{
    public class WalletFundRecordsRequest : KeyedRequestPayload
    {
        public WalletFundRecordsRequest(string currency, string coin, string walletFundType, int? page, int? limit)
        {
            Currency = currency;
            Coin = coin;
            WalletFundType = walletFundType;
            Page = page;
            Limit = limit;
        }

        public string Currency { get; }
        public string Coin { get; }
        public string WalletFundType { get; }
        public int? Page { get; }
        public int? Limit { get; }
        internal override string EndPoint => "/open-api/wallet/fund/records";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("currency", Currency);
                res.AddStringIfNotEmptyOrWhiteSpace("coin", Coin);
                res.AddStringIfNotEmptyOrWhiteSpace("wallet_fund_type", WalletFundType);
                res.AddSimpleStructIfNotNull("page",Page);
                res.AddSimpleStructIfNotNull("limit",Limit);
                return res;
            }
        }
    }
}
