using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.UserStreams.Events;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.UserStreams
{
    public class UserStreamsHandlerFactory : IUserStreamsHandlerFactory
    {
        public ISingleMessageHandler<PositionEvent> CreatePositionEvent() => new BaseJsonHandler<PositionEvent>();
        public ISingleMessageHandler<ExecutionEvent> CreateExecutionEvent() => new BaseJsonHandler<ExecutionEvent>();
        public ISingleMessageHandler<OrderEvent> CreateOrderEvent() => new BaseJsonHandler<OrderEvent>();
        public ISingleMessageHandler<StopOrderEvent> CreateStopOrderEvent() => new BaseJsonHandler<StopOrderEvent>();
    }
}
