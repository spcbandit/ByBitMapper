using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.RiskLimit
{
    /// <summary>
    /// USDT Perpetual формат реквеста SetRiskLimit
    /// </summary>
    public sealed class SetRiskLimitRequest : KeyedRequestPayload
    {
        public SetRiskLimitRequest(string symbol, OrderSideType side, int riskId)
        {
            Symbol = symbol;
            Side = side;
            RiskId = riskId;
        }

        public string Symbol { get; set; }
        public OrderSideType Side { get; set; }
        public int? RiskId { get; set; }
        internal override string EndPoint => "/private/linear/position/set-risk";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("side", Side);
                res.AddDecimalIfNotNull("risk_id", RiskId);

                return res;
            }
        }
    }
}
