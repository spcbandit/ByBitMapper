using System;
using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    public class PositionModeSwitchRequest : KeyedRequestPayload
    {
        public string Symbol { get; }
        public PositionModeType ModeType { get; }

        public PositionModeSwitchRequest(string symbol, PositionModeType mode)
        {
            Symbol = symbol ?? throw new ArgumentException(nameof(symbol));
            ModeType = mode;
        }
        internal override string EndPoint => "/private/linear/position/switch-mode";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddEnum("mode", ModeType);
                res.Add("symbol", Symbol);
                return res;
            }
        }
    }
}