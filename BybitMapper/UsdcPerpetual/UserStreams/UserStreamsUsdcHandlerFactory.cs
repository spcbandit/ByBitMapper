using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects;

namespace BybitMapper.UsdcPerpetual.UserStreams
{
    public sealed class UserStreamsUsdcHandlerFactory : IUserStreamsUsdcHandlerFactory
    {
        public ISingleMessageHandler<ExecutionEvent> CreateExecutionUsdcEvent() => new BaseJsonHandler<ExecutionEvent>();
        public ISingleMessageHandler<OrderEvent> CreateOrderUsdcEvent() => new BaseJsonHandler<OrderEvent>();
        public ISingleMessageHandler<PositionEvent> CreatePositionUsdcEvent() => new BaseJsonHandler<PositionEvent>();
    }
}
