using System;
using System.Collections.Generic;

using BybitMapper.Extensions;

using BybitMapper.Requests;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

// https://bybit-exchange.github.io/docs/usdc/perpetual/#t-usdccancelall

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Order
{
	/// <summary>
	/// Реквест за накрытие всех активных ордеров.
	/// </summary>
	public sealed class CancelAllActiveOrdersRequest : UsdcKeyedRequestPayload
	{
		public CancelAllActiveOrdersRequest(string symbol, OrderFilterType orderFilter)
        {
            Symbol = symbol;
            OrderFilter = orderFilter;
        }

		public string Symbol { get; }

        public OrderFilterType OrderFilter { get; }

		internal override string EndPoint => "/perpetual/usdc/openapi/private/v1/cancel-all";

        internal override RequestMethod Method => RequestMethod.POST;

		internal override object Body
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("orderFilter", OrderFilter);

                return res;
            }
        }
	}
}

