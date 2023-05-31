using BybitMapper.InversePerpetual.RestV2;
using BybitMapper.InversePerpetual.MarketStreams;
using BybitMapper.InversePerpetual.MarketStreams.Subscriptions;
using BybitMapper.InversePerpetual.UserStreams;
using BybitMapper.InversePerpetual.UserStreams.Subscriptions;
using BybitMapper.Requests;

using RestSharp;

using System;
using System.Security.Authentication;

using WebSocketSharp;
using BybitMapper.Spot.RestV1;
using BybitMapper.Spot.MarketStreams.Events;
using BybitMapper.Perpetual.RestV2;
using BybitMapper.Perpetual.MarketStreams;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;
using BybitMapper.Perpetual.MarketStreams.Events;
using BybitMapper.Perpetual.MarketStreams.Subscriptions;
using BybitMapper.Perpetual.UserStreams;
using BybitMapper.Perpetual.UserStreams.Subscriptions;
using BybitMapper.Perpetual.UserStreams.Data.Enum;
using BybitMapper.Perpetual.UserStreams.Events;
using BybitMapper.UsdcPerpetual.RestV2;
using BybitMapper.UsdcPerpetual.MarketStreams;
using BybitMapper.UsdcPerpetual.MarketStreams.Subscriptions;
using BybitMapper.UsdcPerpetual.UserStreams;
using BybitMapper.UsdcPerpetual.UserStreams.Subscriptions;

namespace BybitTester
{
    public class TesterByBit
    {
        private string pathApi = "https://api.bybit.com";
        private string pathTestApi = "https://api-testnet.bybit.com";
        private string testPathTestApi = "wss://stream-testnet.bybit.com/realtime";
        private string testSpotPathTestApi = "wss://stream-testnet.bybit.com/spot/quote/ws/v1";
        private string testSpotPrivatePathTestApi = "wss://stream.bybit.com/spot/ws";
        private string pathWSS = "wss://stream.bybit.com/realtime";
        private RestClient client = null;
        private WebSocket socket = null;
        private string apiKey = string.Empty;
        private string secretKey = string.Empty;

        #region [USDTPerpetual переменные]
        //private string testPerpetualPublic = "wss://stream-testnet.bybit.com/realtime_public";
        private string testPerpetualPublic = "wss://stream.bybit.com/realtime_private";

        public PerpetualHandlerComposition PRestHandler = new PerpetualHandlerComposition(new PerpetualHandlerFactory());
        public BybitMapper.Perpetual.MarketStreams.MarketStreamsPerpetualHandlerComposition PMarketHandler = new BybitMapper.Perpetual.MarketStreams.MarketStreamsPerpetualHandlerComposition(new BybitMapper.Perpetual.MarketStreams.MarketStreamsPerpetualHandlerFactory());
        public UserStreamsPerpetualHandlerComposition PUserHandler = new UserStreamsPerpetualHandlerComposition(new UserStreamsPerpetualHandlerFactory());
        #endregion
        #region [USDCPerpetual переменные]
        //private string testPerpetualPublic = "wss://stream-testnet.bybit.com/realtime_public";
        private string testUsdcPerpetualPublic = "wss://stream.bybit.com/perpetual/ws/v1/realtime_public";
        private string testUsdcPerpetualPrivate = "wss://stream.bybit.com/trade/option/usdc/private/v1";

        public UsdcPepetualHandlerComposition UsdcPRestHandler = new UsdcPepetualHandlerComposition(new UsdcPepetualHandlerFactory());
        public MarketStreamsUsdcPerpetualHandlerComposition UsdcMarketHandler = new MarketStreamsUsdcPerpetualHandlerComposition(new MarketStreamsUsdcPerpetualHandlerFactory());
        public UserStreamsUsdcHandlerComposition UsdcUserHandler = new UserStreamsUsdcHandlerComposition(new UserStreamsUsdcHandlerFactory());
        #endregion
        public InversePerpetualV2HandlerComposition RESTHandlers = new InversePerpetualV2HandlerComposition(new InversePerpetualV2HandlerFactory());

        public MarketStreamsHandlerComposition WSHandler = new MarketStreamsHandlerComposition(new MarketStreamsHandlerFactory());
        public UserStreamsHandlerComposition WSUserHandler = new UserStreamsHandlerComposition(new UserStreamsHandlerFactory());
        public SpotV1HandlerComposition SPOTHandlers = new SpotV1HandlerComposition(new SpotV1HandlerFactory());
        public BybitMapper.Spot.MarketStreams.MarketStreamsHandlerComposition WSSPOTHandler = new BybitMapper.Spot.MarketStreams.MarketStreamsHandlerComposition(new BybitMapper.Spot.MarketStreams.MarketStreamsHandlerFactory());
        public BybitMapper.Spot.UserStreams.UserStreamsHandlerComposition WSSPOTUserHandler = new BybitMapper.Spot.UserStreams.UserStreamsHandlerComposition(new BybitMapper.Spot.UserStreams.UserStreamsHandlerFactory());

        private RequestArranger requestArranger = null;

        public string Symbol = "BTCUSD";
        public string Coin = "BTC";
        public decimal Size = 0.001m;
        public string Address = "";
        public string Password = "";
        public int Depth = 35;
        public int Limit = 50;
        public DateTime Start = DateTime.Now.AddDays(-1);
        public DateTime End = DateTime.Now;
        public TesterByBit(bool ws = true)
        {
            if (ws)
            {
                //тестирование websocket
                ConnectWS();
            }
            else
            {
                //тестирование public/private market
                client = new RestClient(pathApi);
                requestArranger = new RequestArranger();
            }
        }


        
        private void ConnectWS()
        {
            //socket = new WebSocket(testSpotPathTestApi);
            //socket = new WebSocket(testSpotPrivatePathTestApi) { EmitOnPing = true};
            
            socket = new WebSocket("wss://stream.bybit.com/realtime") { EmitOnPing = true }; //USDT Perpetual
            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
            socket.OnOpen += OpenWS;
            socket.OnMessage += OnMessageWS;
            socket.Connect();
        }

        public void OnMessageWS(object sender, MessageEventArgs e)
        {
            //bool isAuf = false;
            bool isAuf = true;

            #region [InversePerpetualPublicStream]
            var message = WSHandler.HandleDefaultEvent(e.Data);
            switch (message.WSEventType.Value)
            {
                case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.None:
                    break;
                case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.Insurance:
                    var insurance = WSHandler.HandleInsuranceEvent(e.Data);
                    break;
                case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.InstrumentInfo:
                    var instrumentInfo = WSHandler.HandleInstrumentInfoEvent(e.Data);
                    if (instrumentInfo.Type == BybitMapper.InversePerpetual.MarketStreams.Data.DataEventType.Snapshot)
                    {
                        var ss = instrumentInfo.DataSnap;
                    }
                    else
                    {
                        var ss = instrumentInfo.DataDelta;
                    }
                    break;
                case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.Kline:
                    var kline = WSHandler.HandleKlineEvent(e.Data);

                    break;
                case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.OrderBook25:
                    var ob25 = WSHandler.HandleOrderBookEvent(e.Data);

                    break;
                case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.OrderBook200:
                    var ob200 = WSHandler.HandleOrderBookEvent(e.Data);
                    if (ob200.Type == BybitMapper.InversePerpetual.MarketStreams.Data.DataEventType.Snapshot)
                    {
                        var ss = ob200.DataSnap;
                    }
                    else
                    {
                        var ss = ob200.DataObject;
                    }
                    break;
                case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.Trade:
                    var trade = WSHandler.HandleTradeEvent(e.Data);

                    break;
                default:
                    break;
            }
            #endregion
            #region [InversePerpetualPrivateStream]
            //switch (message.WSEventType.Value)
            //{
            //    case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.Position:
            //        var resp = WSUserHandler.HandlePositionEvent(e.Data);

            //        break;
            //    case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.Execution:
            //        var resp2 = WSUserHandler.HandleExecutionEvent(e.Data);

            //        break;
            //    case BybitMapper.InversePerpetual.MarketStreams.Data.EventType.Order:
            //        var resp3 = WSUserHandler.HandleOrderEvent(e.Data);

            //        break;
            //    default:
            //        break;
            //}
            #endregion

            #region [SpotPublicStream]
            //var message = WSSPOTHandler.HandleDefaultEvent(e.Data);
            //switch (message.WSEventType.Value)
            //{
            //    case BybitMapper.Spot.MarketStreams.Data.EventType.None:
            //        break;
            //    case BybitMapper.Spot.MarketStreams.Data.EventType.Realtimes:
            //        var infoInstrument = WSSPOTHandler.HandleInstrumentInfoEvent(e.Data);
            //        break;

            //    default:
            //        break;
            //}
            #endregion
            #region [SpotPrivateStream]

            #endregion

            #region [USDTPerpetualPublicStream]

            //var message = PMarketHandler.HandleDefaultEvent(e.Data);
            //switch (message.PerpetualEventType.Value)
            //{
            //    case EventPerpetualType.None:
            //        break;
            //    case EventPerpetualType.InstrumentInfo:
            //        var instrumentInfo = PMarketHandler.HandleInstrumentInfoEvent(e.Data);
            //        if (instrumentInfo.Type == DataEventType.Snapshot)
            //        {
            //            var ss = instrumentInfo.DataSnap;
            //        }
            //        else
            //        {
            //            var ss = instrumentInfo.DataDelta;
            //        }
            //        break;
            //    case EventPerpetualType.Liquidation:
            //        var liq = PMarketHandler.HandleLiquidationEvent(e.Data);
            //        break;
            //    //done
            //    case EventPerpetualType.Kline:
            //        var kline = PMarketHandler.HandleKlineEvent(e.Data);
            //        break;
            //    case EventPerpetualType.OrderBook25:
            //        var ob25 = PMarketHandler.HandleOrderBookL2Event(e.Data);
            //        if (ob25.Type == DataEventType.Snapshot)
            //        {
            //            var ss = ob25.DataSnap;
            //        }
            //        else
            //        {
            //            var ss = ob25.DataDelta;
            //        }
            //        break;
            //    case EventPerpetualType.OrderBook200:
            //        var ob200 = PMarketHandler.HandleOrderBookL2Event(e.Data);
            //        if (ob200.Type == DataEventType.Snapshot)
            //        {
            //            var ss = ob200.DataSnap;
            //        }
            //        else
            //        {
            //            var ss = ob200.DataDelta;
            //        }
            //        break;
            //    case EventPerpetualType.Trade:
            //        var trade = PMarketHandler.HandleTradeEvent(e.Data);
            //        break;
            //    default:
            //        break;
            //}
            #endregion
            #region [USDTPerpetualPrivateStream]

            //PDefaultEvent message = null;
            //message = PerpetualHandler.HandleDefaultEvent(e.Data);
            //switch (message.PerpetualEventType.Value)
            //{
            //    case EventPerpetualType.None:
            //        break;
            //    case EventPerpetualType.Position:
            //        var resp1 = PUserHandler.HandlePositionPerpetualEvent(e.Data);
            //        break;
            //    case EventPerpetualType.Execution:
            //        var resp2 = PUserHandler.HandleExecutionPerpetualEvent(e.Data);
            //        break;
            //    case EventPerpetualType.Order:
            //        var resp3 = PUserHandler.HandleOrderPerpetualEvent(e.Data);
            //        break;
            //    case EventPerpetualType.StopOrder:
            //        var resp4 = PUserHandler.HandleStopOrderPerpetualEvent(e.Data);
            //        break;
            //    case EventPerpetualType.Wallet:
            //        var resp5 = PUserHandler.HandleWalletPerpetualEvent(e.Data);
            //        break;

            //    default:
            //        break;
            //}
            #endregion

            #region [USDCPerpetualPublicStream]
            //var message = UsdcMarketHandler.HandleDefaultEvent(e.Data);
            //switch (message.PerpetualEventType.Value)
            //{
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.None:
            //        break;
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.InstrumentInfo:
            //        var instrumentInfo = UsdcMarketHandler.HandleInstrumentInfoEvent(e.Data);
            //        if (instrumentInfo.Type == BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.DataEventType.Snapshot)
            //        {
            //            var ss = instrumentInfo.DataSnap;
            //        }
            //        else
            //        {
            //            var ss = instrumentInfo.DataDelta;
            //        }
            //        break;
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.OrderBook25:
            //        var ob25 = UsdcMarketHandler.HandleOrderBookL2Event(e.Data);
            //        if (ob25.Type == BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.DataEventType.Snapshot)
            //        {
            //            var ss = ob25.DataSnap;
            //        }
            //        else
            //        {
            //            var ss = ob25.DataDelta;
            //        }
            //        break;
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.OrderBook200:
            //        var ob200 = UsdcMarketHandler.HandleOrderBookL2Event(e.Data);
            //        if (ob200.Type == BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.DataEventType.Snapshot)
            //        {
            //            var ss = ob200.DataSnap;
            //        }
            //        else
            //        {
            //            var ss = ob200.DataDelta;
            //        }
            //        break;
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.Trade:
            //        var trade = UsdcMarketHandler.HandleTradeEvent(e.Data);
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            #region [USDCPerpetualUserStream]
            //var message = UsdcMarketHandler.HandleDefaultEvent(e.Data);
            //switch (message.PerpetualEventType.Value)
            //{
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.None:
            //        break;
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.Order:
            //        var order = UsdcUserHandler.HandleOrderUsdcEvent(e.Data);
            //        break;
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.Positions:
            //        var positions = UsdcUserHandler.HandlePositionUsdcEvent(e.Data);
            //        break;
            //    case BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.EventPerpetualType.Trade:
            //        var execution = UsdcUserHandler.HandleExecutionUsdcEvent(e.Data);
            //        break;
            //    default:
            //        break;
            //}
            #endregion

        }

        public void OpenWS(object sender, EventArgs e)
        {

            #region [InversePerpetualPublicStream]
            //var req = BybitMapper.InversePerpetual.MarketStreams.Subscriptions.CombineStremsSubs.Create(this.Symbol, BybitMapper.InversePerpetual.MarketStreams.Data.SubType.Subscribe, BybitMapper.InversePerpetual.MarketStreams.Data.PublicEndpointType.Trade);
            //socket.Send(req);
            //var req2 = CombineStremsSubs.Create(this.Symbol, BybitMapper.InversePerpetual.MarketStreams.Data.SubType.Subscribe, BybitMapper.InversePerpetual.MarketStreams.Data.PublicEndpointType.OrderBook200, "100ms");
            //socket.Send(req2);
            //var req = CombineStremsSubs.Create(this.Symbol, 
            //    BybitMapper.InversePerpetual.MarketStreams.Data.KlineType.FiveMinute, 
            //    BybitMapper.InversePerpetual.MarketStreams.Data.SubType.Subscribe,
            //    eventType: BybitMapper.InversePerpetual.MarketStreams.Data.PublicEndpointType.KlineV2  );
            //socket.Send(req);
            //var req = BybitMapper.InversePerpetual.MarketStreams.Subscriptions.CombineStremsSubs.Create("BTC", 
            //    BybitMapper.InversePerpetual.MarketStreams.Data.SubType.Subscribe,
            //    BybitMapper.InversePerpetual.MarketStreams.Data.PublicEndpointType.Insurance);
            //socket.Send(req);
            var req = BybitMapper.InversePerpetual.MarketStreams.Subscriptions.CombineStremsSubs.Create("BTCUSD",
               BybitMapper.InversePerpetual.MarketStreams.Data.SubType.Subscribe,
               BybitMapper.InversePerpetual.MarketStreams.Data.PublicEndpointType.InstrumentInfo, "100ms");
            socket.Send(req);
            #endregion
            #region [InversePerpetualPrivateStream]
            //var req = BybitMapper.InversePerpetual.UserStreams.Subscriptions.CombineStremsSubs.Create(
            //    BybitMapper.InversePerpetual.UserStreams.Data.SubType.Auth,
            //    "vcs5Jptx3XE7yXAY5Q",
            //    "zW63AWFCKfdPwtujNzohmgdSQZAkh2eLWiA2");
            //socket.Send(req);

            //var req2 = BybitMapper.InversePerpetual.UserStreams.Subscriptions.CombineStremsSubs.Create(
            //    BybitMapper.InversePerpetual.UserStreams.Data.SubType.Subscribe,
            //    type: BybitMapper.InversePerpetual.UserStreams.Data.UserEventType.Position);
            //socket.Send(req2);
            //var req3 = BybitMapper.InversePerpetual.UserStreams.Subscriptions.CombineStremsSubs.Create(
            //    BybitMapper.InversePerpetual.UserStreams.Data.SubType.Subscribe,
            //    type: BybitMapper.InversePerpetual.UserStreams.Data.UserEventType.Order);
            //socket.Send(req3);
            //var req4 = BybitMapper.InversePerpetual.UserStreams.Subscriptions.CombineStremsSubs.Create(
            //    BybitMapper.InversePerpetual.UserStreams.Data.SubType.Subscribe,
            //    type: BybitMapper.InversePerpetual.UserStreams.Data.UserEventType.Execution);
            //socket.Send(req4);
            #endregion

            #region [SpotPublicStream]
            //var req = BybitMapper.Spot.MarketStreams.Subscriptions.CombineStremsSubs.Create("BTCUSDT", BybitMapper.Spot.MarketStreams.Data.PublicEndpointType.Realtimes, BybitMapper.Spot.MarketStreams.Data.SubType.Subscribe);
            //socket.Send(req);
            //var req = BybitMapper.Spot.MarketStreams.Subscriptions.CombineStremsSubs.Create("BTCUSDT", BybitMapper.Spot.MarketStreams.Data.PublicEndpointType.Depth, BybitMapper.Spot.MarketStreams.Data.SubType.Subscribe);
            //socket.Send(req);
            //var req2 = BybitMapper.Spot.MarketStreams.Subscriptions.CombineStremsSubs.Create("BTCUSDT", BybitMapper.Spot.MarketStreams.Data.PublicEndpointType.Trade, BybitMapper.Spot.MarketStreams.Data.SubType.Subscribe);
            //socket.Send(req2);
            #endregion
            #region [SpotPrivateStream]
            //var req3 = BybitMapper.Spot.UserStreams.Subscriptions.CombineStremsSubs.Login(
            //    BybitMapper.Spot.UserStreams.Enums.SubType.Auth,
            //    "AgNYY1xevp0m9XJse5",
            //    "uC9auVfjds5C38CnquMN6mMSk7blEac0R3a8");
            //socket.Send(req3);
            #endregion

            #region [USDTPerpetualPublicStream]
            //done Trade
            //var req = PCombineStremsSubs.Create("BTCUSDT", SubType.Subscribe, PublicEndpointType.Trade);
            //socket.Send(req);
            ////done Kline
            //var req2 = PCombineStremsSubs.Create("BTCUSDT", SubType.Subscribe, PublicEndpointType.Kline);
            //socket.Send(req2);
            //done InstrumentInfo
            //var req = PCombineStremsSubs.Create("BTCUSDT", SubType.Subscribe, PublicEndpointType.InstrumentInfo);
            //socket.Send(req);

            ////OrderBook200 done всё ок ток возвращает не 200 а 400 в первом респонсе О_О
            //var req = PCombineStremsSubs.Create("BTCUSDT", SubType.Subscribe, PublicEndpointType.OrderBook200);
            //socket.Send(req);
            ////OrderBookL2_25 done всё ок ток возвращает не 25 а 50 в первом респонсе О_О
            //var req = PCombineStremsSubs.Create("BTCUSDT", SubType.Subscribe, PublicEndpointType.OrderBookL2_25);
            //socket.Send(req);

            ////Data null ??? Liquidation
            //var req = PCombineStremsSubs.Create("XRPUSDT", SubType.Subscribe, PublicEndpointType.Liquidation);
            //socket.Send(req);
            #endregion
            #region [USDTPerpetualPrivateStream]
            //var req = CombineStremsSubsPerpetualUser.Create(SubType.Auth, "zJzaErgNc7WlqIS26E", "1qcywPsLyX0ansrKAfOW3ohifWFqTEZ8mzY0");
            //socket.Send(req);

            ////done открытие закрытие
            //var req1 = CombineStremsSubsPerpetualUser.Create(SubType.Subscribe, type: UserEventType.Position);
            //socket.Send(req1);

            ////done при выставлении лимитки
            //var req2 = CombineStremsSubsPerpetualUser.Create( SubType.Subscribe, type: UserEventType.Execution);
            //socket.Send(req2);

            ////done при выставлении заказов
            //var req3 = CombineStremsSubsPerpetualUser.Create(SubType.Subscribe, type: UserEventType.Order);
            //socket.Send(req3);

            ////done приходит информация о кошельке при заказе
            //var req5 = CombineStremsSubsPerpetualUser.Create(SubType.Subscribe, type: UserEventType.Wallet);
            //socket.Send(req5);

            ////это не тестировано
            //var req4 = CombineStremsSubsPerpetualUser.Create(SubType.Subscribe,type: UserEventType.StopOrder);
            //socket.Send(req4);
            #endregion

            #region [USDCPerpetualPublicStream]
            //var req = UsdcMarketCombineStremsSubs.Create("BTCPERP", BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.SubType.Subscribe, BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.PublicEndpointType.InstrumentInfo);
            //socket.Send(req);
            //done Trade
            //var req = UsdcMarketCombineStremsSubs.Create("BTCPERP", BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.SubType.Subscribe, BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.PublicEndpointType.Trade);
            //socket.Send(req);
            //done Orderbook
            //var req1 = UsdcMarketCombineStremsSubs.Create("BTCPERP", BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.SubType.Subscribe, BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.PublicEndpointType.OrderBook200);
            //socket.Send(req1);
            #endregion

            #region [USDCPerpetualUserStream]

            //var req = CombineStremsSubsUsdcPerpetualUser.Create(BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.SubType.Auth, "", "");
            //socket.Send("{\"op\":\"subscribe\",\"args\":[{\"instType\":\"mc\",\"channel\":\"books\",\"instId\":\"BTCUSDT\"}]}");

            //////done
            ////var req1 = CombineStremsSubsUsdcPerpetualUser.Create(BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.SubType.Subscribe, type: BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.UserEventType.Position);
            ////socket.Send(req1);

            //////done при выставлении лимитки
            //var req2 = CombineStremsSubsUsdcPerpetualUser.Create(BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.SubType.Subscribe, type: BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.UserEventType.Execution);
            //socket.Send(req2);

            ////done при выставлении заказов
            //var req3 = CombineStremsSubsUsdcPerpetualUser.Create(BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.SubType.Subscribe, type: BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum.UserEventType.Order);
            //socket.Send(req3);

            #endregion


        }



        public TesterByBit(string api, string secret, Func<long> time = null)
        {
            client = new RestClient(pathTestApi);
            requestArranger = new RequestArranger(api, secret, time);

            apiKey = api;
            secretKey = secret;
        }

        public TesterByBit(string api, string secret, Func<long> time = null, bool testApi = true)
        {
            client = new RestClient(pathApi);
            requestArranger = new RequestArranger(api, secret, time)
            {
                ActualityWindow = 5000
            };

            apiKey = api;
            secretKey = secret;
            ConnectWS();
        }

        public string SendTest(RequestPayload payload)
        {
            // var h = new Dictionary<string, string> { { "Referer", "Cscalp" } };
            var request = requestArranger.Arrange(payload);
            var req = new RestRequest(request.Query, MapRequestMethod(request.Method));

            if (request.Body != null)
            {
                req.RequestFormat = DataFormat.Json;
                req.AddJsonBody(request.Body);
            }

            if (request.Headers != null)
            {
                foreach (var header in request.Headers)
                {
                    req.AddHeader(header.Key, header.Value);
                }
            }
            var result = client.Execute(req)?.Content;
            return (result);
        }

        private static Method MapRequestMethod(RequestMethod method)
        {
            switch (method)
            {
                case RequestMethod.GET:
                    return Method.GET;
                case RequestMethod.POST:
                    return Method.POST;
                case RequestMethod.PUT:
                    return Method.PUT;
                case RequestMethod.DELETE:
                    return Method.DELETE;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
