using BybitMapper.Handlers;
using BybitMapper.Spot.UserStreamsV3.Events;

namespace BybitMapper.Spot.UserStreamsV3
{
    public class UserStreamsHandlerFactoryV3 : IUserStreamsHandlerFactoryV3
    {
        public ISingleMessageHandler<OrderEvent> CreateOrderEvent() => new BaseJsonHandler<OrderEvent>();
        public ISingleMessageHandler<StopOrderEvent> CreateStopOrderEvent() => new BaseJsonHandler<StopOrderEvent>();
        public ISingleMessageHandler<TicketInfoEvent> CreateTicketInfoEvent() => new BaseJsonHandler<TicketInfoEvent>();
        public ISingleMessageHandler<UserDefaultEvent> CreateUserDefaultEvent() => new BaseJsonHandler<UserDefaultEvent>();
        public ISingleMessageHandler<DefaultEvent> CreateDefaultEvent() => new BaseJsonHandler<DefaultEvent>();
    }
}
