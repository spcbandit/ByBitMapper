using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    /// <summary>
    /// USDT Perpetual формат реквеста FullPartialPositionTPSLSwitch
    /// </summary>
    public sealed class FullPartialPositionTPSLSwitchRequest : KeyedRequestPayload
    {
        public FullPartialPositionTPSLSwitchRequest(string symbol, TpSlModeType tpSlMode )
        {
            Symbol = symbol;
            TpSlMode = tpSlMode;
        }

        public string Symbol { get; set; }
        public TpSlModeType TpSlMode { get; set; }
        internal override string EndPoint => "/private/linear/tpsl/switch-mode";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("tp_sl_mode", TpSlMode);
                return res;
            }
        }
    }
}
