using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    /// <summary>
    /// USDT Perpetual формат реквеста SetLeverage
    /// </summary>
    public sealed class SetLeverageRequest : KeyedRequestPayload
    {
        public SetLeverageRequest(string symbol, decimal buyLeverage, decimal sellLeverage)
        {
            Symbol = symbol;
            BuyLeverage = buyLeverage;
            SellLeverage = sellLeverage;
        }

        public string Symbol { get; set; }
        public decimal? BuyLeverage { get; set; }
        public decimal? SellLeverage { get; set; }
        internal override string EndPoint => "/private/linear/position/set-leverage";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("buy_leverage", BuyLeverage);
                res.AddDecimalIfNotNull("sell_leverage", SellLeverage);

                return res;
            }
        }
    }
}
