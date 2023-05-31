using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Requests;

namespace BybitMapper.Spot.RestV3.Requests.Account
{
    public class OrderListRequest : KeyedRequestPayload
    {
        /// <summary>
        /// Инструмент
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Укажите orderId, чтобы вернуть все заказы, чей orderId меньше, чем этот(для разбивки на страницы)
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// Лимит ордеров, значение по умолчанию – 500, максимальное значение – 500.
        /// </summary>
        public int? Limit { get; set; } = 500;
        /// <summary>
        /// Категория ордера 0: нормальный порядок(по умолчанию) 1: ордер TP/SL(требуется для ордера TP/SL)
        /// </summary>
        public int? OrderCategory { get; set; } = 0;

        internal override string EndPoint => "/spot/v3/private/open-orders";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("orderId", OrderId);
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddSimpleStructIfNotNull("orderCategory", OrderCategory);

                return res;
            }
        }
    }
}
