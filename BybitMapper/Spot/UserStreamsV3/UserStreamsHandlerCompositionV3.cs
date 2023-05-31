using System;
using System.Collections.Generic;
using BybitMapper.Handlers;
using BybitMapper.Spot.UserStreamsV3.Events;
using JetBrains.Annotations;

namespace BybitMapper.Spot.UserStreamsV3
{
    public class UserStreamsHandlerCompositionV3
    {
        [NotNull]
        private readonly IUserStreamsHandlerFactoryV3 _factory;
        [NotNull]
        private readonly ISingleMessageHandler<OrderEvent> _orderEvent;
        [NotNull]
        private readonly ISingleMessageHandler<StopOrderEvent> _stopOrderEvent;
        [NotNull]
        private readonly ISingleMessageHandler<TicketInfoEvent> _ticketInfoEvent;
        [NotNull]
        private readonly ISingleMessageHandler<UserDefaultEvent> _userDefaultEvent;
        [NotNull]
        private readonly ISingleMessageHandler<DefaultEvent> _defaultEvent;

        public UserStreamsHandlerCompositionV3([NotNull] IUserStreamsHandlerFactoryV3 factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _orderEvent = factory.CreateOrderEvent();
            _ticketInfoEvent = factory.CreateTicketInfoEvent();
            _userDefaultEvent = factory.CreateUserDefaultEvent();
            _defaultEvent = factory.CreateDefaultEvent();
            _stopOrderEvent = factory.CreateStopOrderEvent();
        }

        public OrderEvent HandleOrderEvent(string message) => _orderEvent.HandleSingle(message);
        public StopOrderEvent HandleStopOrderEvent(string message) => _stopOrderEvent.HandleSingle(message);
        public TicketInfoEvent HandleTicketInfoEvent(string message) => _ticketInfoEvent.HandleSingle(message);
        public UserDefaultEvent HandleUserDefaultEvent(string message) => _userDefaultEvent.HandleSingle(message);
        public DefaultEvent HandleDefaultEvent(string message) => _defaultEvent.HandleSingle(message);

    }
}
