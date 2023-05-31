using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    /// <summary>
    /// USDT Perpetual формат реквсета  SetAutoAddMargin
    /// </summary>
    public sealed class SetAutoAddMarginRequest : KeyedRequestPayload
    {
        public SetAutoAddMarginRequest(string symbol, OrderSideType side, bool autoAddMargin)
        {
            Symbol = symbol;
            Side = side;
            AutoAddMargin = autoAddMargin;
        }

        public string Symbol { get; set; }
        public OrderSideType Side { get; set; }
        public bool AutoAddMargin { get; set; }
        internal override string EndPoint => "/private/linear/position/set-auto-add-margin";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("side", Side);
                res.AddBoolean("auto_add_margin", AutoAddMargin);

                return res;
            }
        }
    }
}
