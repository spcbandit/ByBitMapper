using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    /// <summary>
    /// USDT Perpetual формат реквеста AddReduceMargin
    /// </summary>
    public sealed class AddReduceMarginRequest : KeyedRequestPayload
    {
        public AddReduceMarginRequest(string symbol, OrderSideType side, decimal margin)
        {
            Symbol = symbol;
            Side = side;
            Margin = margin;
        }

        public string Symbol { get; set; }
        public OrderSideType Side { get; set; }
        public decimal? Margin { get; set; }
        internal override string EndPoint => "/private/linear/position/add-margin";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("side", Side);
                res.AddDecimalIfNotNull("margin", Margin);

                return res;
            }
        }
    }
}
