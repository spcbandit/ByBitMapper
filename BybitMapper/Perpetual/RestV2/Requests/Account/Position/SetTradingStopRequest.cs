using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    /// <summary>
    /// USDT Perpetual формат реквеста SetTradingStop
    /// </summary>
    public sealed class SetTradingStopRequest : KeyedRequestPayload
    {
        public SetTradingStopRequest(string symbol, OrderSideType side)
        {
            Symbol = symbol;
            Side = side;
        }

        public string Symbol { get; set; }
        public OrderSideType Side { get; set; }
        public decimal? TakeProfit { get; set; }
        public decimal? StopLoss { get; set; }
        public decimal? TrailingStop { get; set; }
        public TriggerPriceType? TpTriggerBy { get; set; }
        public TriggerPriceType? SlTriggerBy { get; set; }
        public decimal? SlSize { get; set; }
        public decimal? TpSize { get; set; }
        public decimal? PositionIdx { get; set; }

        internal override string EndPoint => "/private/linear/position/trading-stop";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("side", Side);
                res.AddDecimalIfNotNull("take_profit", TakeProfit);
                res.AddDecimalIfNotNull("stop_loss", StopLoss);
                res.AddDecimalIfNotNull("trailing_stop", TrailingStop);
                res.AddEnumIfNotNull("tp_trigger_by", TpTriggerBy);
                res.AddEnumIfNotNull("sl_trigger_by", SlTriggerBy);
                res.AddDecimalIfNotNull("sl_size", SlSize);
                res.AddDecimalIfNotNull("tp_size", TpSize);             
                res.AddDecimalIfNotNull("position_idx", PositionIdx);             

                return res;
            }
        }
    }
}
