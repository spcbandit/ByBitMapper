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
    public interface IUserStreamsHandlerFactory
    {
        [NotNull]
        ISingleMessageHandler<PositionEvent> CreatePositionEvent();
        [NotNull]
        ISingleMessageHandler<ExecutionEvent> CreateExecutionEvent();
        [NotNull]
        ISingleMessageHandler<OrderEvent> CreateOrderEvent();
        [NotNull]
        ISingleMessageHandler<StopOrderEvent> CreateStopOrderEvent();
    }
}
