using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.UserStreams.Events;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.UserStreams
{
    public class UserStreamsHandlerComposition
    {
        [NotNull]
        private readonly IUserStreamsHandlerFactory _factory;

        [NotNull]
        private readonly ISingleMessageHandler<PositionEvent> _PositionEvent;
        [NotNull]
        private readonly ISingleMessageHandler<ExecutionEvent> _ExecutionEvent;
        [NotNull]
        private readonly ISingleMessageHandler<OrderEvent> _OrderEvent;
        [NotNull]
        private readonly ISingleMessageHandler<StopOrderEvent> _StopOrderEvent;

        public UserStreamsHandlerComposition([NotNull] IUserStreamsHandlerFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _PositionEvent = factory.CreatePositionEvent();
            _ExecutionEvent = factory.CreateExecutionEvent();
            _OrderEvent = factory.CreateOrderEvent();
            _StopOrderEvent = factory.CreateStopOrderEvent();
        }

        public PositionEvent HandlePositionEvent(string message) => _PositionEvent.HandleSingle(message);
        public ExecutionEvent HandleExecutionEvent(string message) => _ExecutionEvent.HandleSingle(message);
        public OrderEvent HandleOrderEvent(string message) => _OrderEvent.HandleSingle(message);
        public StopOrderEvent HandleStopOrderEvent(string message) => _StopOrderEvent.HandleSingle(message);
    }
}
