using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Positions
{
    public class SetTradingStopRequest: KeyedRequestPayload
    {
        public SetTradingStopRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; set; }
        public decimal? TakeProfit { get; set; }
        public decimal? StopLoss { get; set; }
        public decimal? TrailingStop { get; set; }
        public TriggerPriceType? TpTriggerBy { get; set; }
        public TriggerPriceType? SlTriggerBy { get; set; }
        public decimal? NewTrailingActive { get; set; }
        public decimal? SlSize { get; set; }
        public decimal? TpSize { get; set; }
        internal override string EndPoint => "/v2/private/position/trading-stop";

        internal override RequestMethod Method =>  RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("take_profit", TakeProfit);
                res.AddDecimalIfNotNull("stop_loss", StopLoss);
                res.AddDecimalIfNotNull("trailing_stop", TrailingStop);
                res.AddEnumIfNotNull("tp_trigger_by", TpTriggerBy);
                res.AddEnumIfNotNull("sl_trigger_by", SlTriggerBy);
                res.AddDecimalIfNotNull("new_trailing_active", NewTrailingActive);
                res.AddDecimalIfNotNull("new_trailing_active", NewTrailingActive);
                res.AddDecimalIfNotNull("sl_size", SlSize);
                res.AddDecimalIfNotNull("tp_size", TpSize);
                return res;
            }
        }
    }
}