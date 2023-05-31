using BybitMapper.Handlers;
using BybitMapper.Spot.MarketStreams.Events;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams
{
    public interface IMarketStreamsHandlerFactory
    {
        [NotNull]
        ISingleMessageHandler<DepthEvent> CreateDepthEvent();
        [NotNull]
        ISingleMessageHandler<TradeEvent> CreateTradeEvent();
        [NotNull]
        ISingleMessageHandler<DefaultEvent> CreateDefaultEvent();
        [NotNull]
        ISingleMessageHandler<InstrumentInfoEvent> CreateInstrumentInfoEvent();
    }
}
