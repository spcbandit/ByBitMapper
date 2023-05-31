using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    public sealed class CrossIsolatedMarginSwitchRequest : KeyedRequestPayload
    {
        /// <summary>
        /// USDT Perpetual формат реквеста CrossIsolatedMarginSwitch
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="isIsolated"></param>
        /// <param name="buyLeverage"></param>
        /// <param name="sellLeverage"></param>
        public CrossIsolatedMarginSwitchRequest(string symbol, bool isIsolated, decimal buyLeverage,decimal sellLeverage)
        {
            Symbol = symbol;
            IsIsolated = isIsolated;
            BuyLeverage = buyLeverage;
            SellLeverage = sellLeverage;
        }

        public string Symbol { get; set; }
        public bool IsIsolated { get; set; }
        public decimal? BuyLeverage { get; set; }
        public decimal? SellLeverage { get; set; }
        internal override string EndPoint => "/private/linear/position/switch-isolated";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddBoolean("is_isolated", IsIsolated);
                res.AddDecimalIfNotNull("buy_leverage", BuyLeverage);
                res.AddDecimalIfNotNull("sell_leverage	", SellLeverage);

                return res;
            }
        }
    }
}
