using BybitMapper.Handlers;
using BybitMapper.Spot.UserStreams.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.UserStreams
{
    public class UserStreamsHandlerFactory : IUserStreamsHandlerFactory
    {
        public ISnapshotHandler<ExecutionReportEvent> CreateExecutionReportEvent() => new BaseJsonHandler<ExecutionReportEvent>();
        public ISnapshotHandler<TicketInfoEvent> CreateTicketInfoEvent() => new BaseJsonHandler<TicketInfoEvent>();
        public ISnapshotHandler<UserDefaultEvent> CreateUserDefaultEvent() => new BaseJsonHandler<UserDefaultEvent>();
    }
}
