using BybitMapper.Handlers;
using BybitMapper.Spot.UserStreams.Events;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.UserStreams
{
    public interface IUserStreamsHandlerFactory
    {
        [NotNull]
        ISnapshotHandler<ExecutionReportEvent> CreateExecutionReportEvent();
        [NotNull]
        ISnapshotHandler<TicketInfoEvent> CreateTicketInfoEvent();
        [NotNull]
        ISnapshotHandler<UserDefaultEvent> CreateUserDefaultEvent();
    }
}
