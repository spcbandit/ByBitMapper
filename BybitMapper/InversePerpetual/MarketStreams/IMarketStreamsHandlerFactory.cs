using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.MarketStreams.Events;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams
{
    public interface IMarketStreamsHandlerFactory
    {
        [NotNull]
        ISingleMessageHandler<InsuranceEvent> CreateInsuranceEvent();
        [NotNull]
        ISingleMessageHandler<KlineEvent> CreateKlineEvent();
        [NotNull]
        ISingleMessageHandler<OrderBookL2Event> CreateOrderBookEvent();
        [NotNull]
        ISingleMessageHandler<TradeEvent> CreateTradeEvent();
        [NotNull]
        ISingleMessageHandler<DefaultEvent> CreateDefaultEvent();
        [NotNull]
        ISingleMessageHandler<InstrumentInfoEvent> CreateInstrumentInfoEvent();
    }
}
