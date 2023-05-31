using BybitMapper.Handlers;
using BybitMapper.Perpetual.UserStreams.Events;

using JetBrains.Annotations;

using System;

namespace BybitMapper.Perpetual.UserStreams
{
    public sealed class UserStreamsPerpetualHandlerComposition
    {
        [NotNull]
        private readonly IUserStreamsPerpetualHandlerFactory _factory;

        [NotNull]
        private readonly ISingleMessageHandler<ExecutionPerpetualEvent> _executionPerpetualEvent;
        [NotNull]
        private readonly ISingleMessageHandler<OrderPerpetualEvent> _orderPerpetualEvent;
        [NotNull]
        private readonly ISingleMessageHandler<PositionPerpetualEvent> _positionPerpetualEvent;
        [NotNull]
        private readonly ISingleMessageHandler<StopOrderPerpetualEvent> _stopOrderPerpetualEvent;
        [NotNull]
        private readonly ISingleMessageHandler<WalletPerpetualEvent> _walletPerpetualEvent;
        
        

        public UserStreamsPerpetualHandlerComposition([NotNull] IUserStreamsPerpetualHandlerFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _executionPerpetualEvent = factory.CreateExecutionPerpetualEvent();
            _orderPerpetualEvent = factory.CreateOrderPerpetualEvent();
            _positionPerpetualEvent = factory.CreatePositionPerpetualEvent();
            _stopOrderPerpetualEvent = factory.CreateStopOrderPerpetualEvent();
            _walletPerpetualEvent = factory.CreateWalletPerpetualEvent();
            

        }
        
        public ExecutionPerpetualEvent HandleExecutionPerpetualEvent(string message) => _executionPerpetualEvent.HandleSingle(message);
        public OrderPerpetualEvent HandleOrderPerpetualEvent(string message) => _orderPerpetualEvent.HandleSingle(message);
        public PositionPerpetualEvent HandlePositionPerpetualEvent(string message) => _positionPerpetualEvent.HandleSingle(message);
        public StopOrderPerpetualEvent HandleStopOrderPerpetualEvent(string message) => _stopOrderPerpetualEvent.HandleSingle(message);
        public WalletPerpetualEvent HandleWalletPerpetualEvent(string message) => _walletPerpetualEvent.HandleSingle(message);
        
    }
}
