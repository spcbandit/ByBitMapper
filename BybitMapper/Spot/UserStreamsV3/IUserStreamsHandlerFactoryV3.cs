using BybitMapper.Handlers;
using BybitMapper.Spot.UserStreamsV3.Events;
using JetBrains.Annotations;

namespace BybitMapper.Spot.UserStreamsV3
{
    public interface IUserStreamsHandlerFactoryV3
    {
        [NotNull]
        ISingleMessageHandler<OrderEvent> CreateOrderEvent();
        [NotNull]
        ISingleMessageHandler<StopOrderEvent> CreateStopOrderEvent();
        [NotNull]
        ISingleMessageHandler<TicketInfoEvent> CreateTicketInfoEvent();
        [NotNull]
        ISingleMessageHandler<UserDefaultEvent> CreateUserDefaultEvent();
        [NotNull]
        ISingleMessageHandler<DefaultEvent> CreateDefaultEvent();
    }
}
