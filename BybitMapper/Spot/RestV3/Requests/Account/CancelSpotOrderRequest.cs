using System;
using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.Spot.RestV3.Data.Enums;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Requests.Account
{
    public class CancelSpotOrderRequest : KeyedRequestPayload
    {
        /// <summary>
        /// Отмена заявки
        /// </summary>
        /// <param name="OrderId">Номер ордера. Требуется, если не передается orderLinkId</param>
        /// <param name="OrderLinkId">Уникальный идентификатор ордера, устанавливаемый пользователем. Требуется, если не передается orderId</param>
        public CancelSpotOrderRequest([CanBeNull] string orderId, [CanBeNull] string orderLinkId = null)
        {
            if(orderId == null && orderLinkId == null)
                throw new ArgumentException("Order id and order link id can not be null!");

            OrderId = orderId;
            OrderLinkId = orderLinkId;
        }

        /// <summary>
        /// Номер ордера. Требуется, если не передается orderLinkId
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// Уникальный идентификатор ордера, устанавливаемый пользователем. Требуется, если не передается orderId
        /// </summary>
        public string OrderLinkId { get; set; }

        /// <summary>
        /// Категория ордера 0: нормальный порядок(по умолчанию) 1: ордер TP/SL(требуется для ордера TP/SL)
        /// </summary>
        public OrderCategoryType? OrderCategory { get; set; } = OrderCategoryType.Normal;

        internal override string EndPoint => "/spot/v3/private/cancel-order";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("orderId", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("orderLinkId", OrderLinkId);
                res.AddEnumIfNotNull("orderCategory", OrderCategory);

                return res;
            }
        }
    }
}
