using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.Spot.RestV1.Data.Enums;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Requests.Account
{
    public class CreateSpotOrderRequest : KeyedRequestPayload
    {
        public CreateSpotOrderRequest([NotNull] string symbol, decimal? qty, CreateSpotOrderSideType side, CreateSpotOrderType type)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);

            Symbol = symbol;
            Qty = qty;
            Side = side;
            Type = type;
        }

        public string Symbol { get; }
        public decimal? Qty { get; }
        public CreateSpotOrderSideType Side { get; }
        public CreateSpotOrderType Type { get; }
        public CreateSpotOrderTimeInForceType? TimeInForce { get; set; }
        public decimal? Price { get; set; }
        public string OrderLinkId { get; set; }
        public string AgentSource { get; set; }
        public override IDictionary<string, string> Headers { get; set; }
        internal override string EndPoint => "/spot/v1/order";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("qty", Qty);
                res.AddEnum("side", Side);
                res.AddEnum("type", Type);
                res.AddEnumIfNotNull("timeInForce", TimeInForce);
                res.AddDecimalIfNotNull("price", Price);
                res.AddStringIfNotEmptyOrWhiteSpace("orderLinkId", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("agentSource", AgentSource);

                return res;
            }
        }
    }
}
