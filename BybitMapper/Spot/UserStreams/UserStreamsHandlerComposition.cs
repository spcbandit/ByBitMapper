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
    public class UserStreamsHandlerComposition
    {
        [NotNull]
        private readonly IUserStreamsHandlerFactory _factory;
        [NotNull]
        private readonly ISnapshotHandler<ExecutionReportEvent> _executionReportEvent;
        [NotNull]
        private readonly ISnapshotHandler<TicketInfoEvent> _ticketInfoEvent;
        [NotNull]
        private readonly ISnapshotHandler<UserDefaultEvent> _userdefaultEvent;

        public UserStreamsHandlerComposition([NotNull] IUserStreamsHandlerFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _executionReportEvent = factory.CreateExecutionReportEvent();
            _ticketInfoEvent = factory.CreateTicketInfoEvent();
            _userdefaultEvent = factory.CreateUserDefaultEvent();

        }

        public IReadOnlyList<ExecutionReportEvent> HandleExecutionReportEvent(string message) => _executionReportEvent.HandleSnapshot(message);
        public IReadOnlyList<TicketInfoEvent> HandleTicketInfoEvent(string message) => _ticketInfoEvent.HandleSnapshot(message);       
        public IReadOnlyList<UserDefaultEvent> HandleUserDefaultEvent(string message) => _userdefaultEvent.HandleSnapshot(message);       
    }
}
