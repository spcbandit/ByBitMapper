using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects;

using JetBrains.Annotations;

using System;

namespace BybitMapper.UsdcPerpetual.UserStreams
{
    public sealed class UserStreamsUsdcHandlerComposition
    {
        [NotNull]
        private readonly IUserStreamsUsdcHandlerFactory _factory;

        [NotNull]
        private readonly ISingleMessageHandler<ExecutionEvent> _executionEvent;
        [NotNull]
        private readonly ISingleMessageHandler<OrderEvent> _orderEvent;
        [NotNull]
        private readonly ISingleMessageHandler<PositionEvent> _positionEvent;
        
        

        public UserStreamsUsdcHandlerComposition([NotNull] IUserStreamsUsdcHandlerFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _executionEvent = factory.CreateExecutionUsdcEvent();
            _orderEvent = factory.CreateOrderUsdcEvent();
            _positionEvent = factory.CreatePositionUsdcEvent();
            

        }
        
        public ExecutionEvent HandleExecutionUsdcEvent(string message) => _executionEvent.HandleSingle(message);
        public OrderEvent HandleOrderUsdcEvent(string message) => _orderEvent.HandleSingle(message);
        public PositionEvent HandlePositionUsdcEvent(string message) => _positionEvent.HandleSingle(message);
        
    }
}
