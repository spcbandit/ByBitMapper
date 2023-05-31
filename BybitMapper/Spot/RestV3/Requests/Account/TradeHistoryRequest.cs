using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Requests;

namespace BybitMapper.Spot.RestV3.Requests.Account
{
    public class TradeHistoryRequest : KeyedRequestPayload
    {
        /// <summary>
        /// Инструмент
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Лимит ордеров, значение по умолчанию – 500, максимальное значение – 500.
        /// </summary>
        public int? Limit { get; set; } = 500;
        /// <summary>
        /// Запрос больше идентификатора сделки. (fromTicketId &lt; идентификатор сделки)
        /// </summary>
        public long? FromTradeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? ToTradeId { get; set; }


        internal override string EndPoint => "/spot/v3/private/my-trades";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddSimpleStructIfNotNull("fromTradeId", FromTradeId);
                res.AddSimpleStructIfNotNull("toTradeId", ToTradeId);

                return res;
            }
        }
    }
}
