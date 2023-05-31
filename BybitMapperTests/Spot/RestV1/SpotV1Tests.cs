using System;
using System.Security.Authentication;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;

using NUnit.Framework;

using RestSharp;
using WebSocketSharp;

using BybitMapper.Requests;
using BybitMapper.Spot.MarketStreams;
using BybitMapper.Spot.RestV1;
using BybitMapper.Spot.RestV1.Requests.Market;
using BybitMapper.Spot.RestV1.Responses.Market;
using BybitMapper.Spot.RestV1.Data.Enums;

using BybitMapper.Spot.RestV1.Requests.Account;
using BybitMapper.Spot.UserStreams.Subscriptions;
using BybitMapper.Spot.UserStreams.Enums;

namespace BybitMapperTests
{
	public class SpotV1Tests
	{
		public SpotV1HandlerComposition RESTHandlers;

		public MarketStreamsHandlerComposition WSHandler = new MarketStreamsHandlerComposition(new MarketStreamsHandlerFactory());

		//private const string ApiKey = "2pam4sQkFE6yIz5Ily";
		//
		//private const string SecretKey = "Ds5eEKo5ZfmMPNSzGxTWBtiBUVXv0ivEx7dy";

		private const string ApiKey = "sKBvMgsXbONGJQ1Zuq";

		private const string SecretKey = "HFh9Ddp27gK8FHCE2nIPHarUDG4tBQNh6C16";

        private const string pathTestApi = "https://api-testnet.bybit.com";

		private const string pathApi = "https://api.bybit.com";

		private RequestArranger requestArranger;

		private RestClient client;

		private WebSocket socket;

		public SpotV1Tests()
		{
			client = new RestClient(pathApi);
			
			requestArranger = new RequestArranger(ApiKey, SecretKey, GetTime);

			RESTHandlers = new SpotV1HandlerComposition(new SpotV1HandlerFactory());
		}

		private long GetTime()
        {
			var request = new ServerTimeRequest();

			var message = SendTest(request);

			var response = RESTHandlers.HandleServerTimeResponse(message);

			return (long)response.Result.ServerTime;
        }

		/// <summary>
		/// Тест, в котором проверяется корректность обработки списка баланса разных монет.
		/// В споте возвращается объект balances, который внутри содержит список баланса монет.
		/// </summary>
		[Test]
		public void GetBalance_Success()
		{
			var request = new SpotWalletBalanceRequest();

			var message = SendTest(request);

			var response = RESTHandlers.HandleSpotWalletBalanceResponse(message);
			
			//"result\":{\"balances\":[{\"coin\":\"USDC\",\"coinId\":\"USDC\",\"coinName\":\"USDC\",\"total\":\"0.000684\",\"free\":\"0.000684\",\"locked\":\"0\"}]}

			var list = response.BalacesResult.BalancesData.ToList();
			
			Assert.IsNotNull(response);
			
			Assert.IsNotNull(response.BalacesResult);
			
			Assert.AreEqual(response.RetMessage, "OK");
			
			Assert.AreEqual(response.RetCode, 0);
		}

		/// <summary>
		/// Тест, в котором проверяется поведение системы в случае добавления новой монеты со стороны биржи.
		/// </summary>
		[Test]
		public void ExtraCointTest()
		{
			var message = "{\"ret_code\":0,\"ret_msg\":\"OK\",\"result\":{\"balances\":[{\"coin\":\"USDC\",\"coinId\":\"USDC\",\"coinName\":\"USDC\",\"total\":\"0.000684\",\"free\":\"0.000684\",\"locked\":\"0\"},{\"coin\":\"USDT\",\"coinId\":\"USDT\",\"coinName\":\"USDT\",\"total\":\"0.0000453\",\"free\":\"0.0000453\",\"locked\":\"0\"},{\"coin\":\"FAKE\",\"coinId\":\"FAKE\",\"coinName\":\"FAKE\",\"total\":\"1.1\",\"free\":\"2.2\",\"locked\":\"3.3\"},]},\"ext_code\":\"\",\"ext_info\":null,\"time_now\":\"1667295471.745933\"}";
			
			var response = RESTHandlers.HandleSpotWalletBalanceResponse(message);
			
			var list = response.BalacesResult.BalancesData.ToList();
			
			var coin = response.BalacesResult.BalancesData.Where(x => x.CoinName == "FAKE");
			
			Assert.IsNotNull(response);

			Assert.IsTrue(coin.Count() != 0);
			Assert.IsTrue(coin.First().Total == 1.1m);
			Assert.IsTrue(coin.First().Free == 2.2m);
			Assert.IsTrue(coin.First().Locked == 3.3m);

			Assert.IsNotNull(response.BalacesResult);
			
			Assert.AreEqual(response.RetMessage, "OK");
			
			Assert.AreEqual(response.RetCode, 0);
		}

		[Test]
		public void PlaceOrder_Success()
		{
			socket = new WebSocket("wss://stream.bybit.com/spot/ws")
			{
				EmitOnPing = true
			};
			
			socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
			
			socket.OnOpen += (object sender, EventArgs e) =>
			{
                var expires = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000;

				var request1 = CombineStremsSubs.Login(SubType.Auth, ApiKey, SecretKey, expires);

				socket.Send(request1);
			};

			socket.OnMessage += (object sender, MessageEventArgs e) =>
			{
				Debug.Print("Message: \"" + e.Data + "\"");

				//var response1 = WSHandler.HandleDefaultEvent(e.Data);
				//
				//if((EventType)response1.WSEventType == EventType.ExecutionReport)
				//{
				//	Assert.Pass();
				//	return;
				//}
			};

			socket.OnError += (object sender, ErrorEventArgs e) =>
			{
				Debug.Print("Error");
			};

			socket.OnClose += (object sender, CloseEventArgs e) =>
			{
				Debug.Print("Close");
			};

			socket.Connect();

			Task.Delay(6000).Wait();
			
			var request = new CreateSpotOrderRequest("XRPUSDT", 22.2m, CreateSpotOrderSideType.Buy,
				CreateSpotOrderType.Limit)
			{
				Price = 0.45m,
			};
			
			var message2 = SendTest(request);
			
			var response2 = RESTHandlers.HandleCreateSpotOrderResponse(message2);
			
			Assert.IsNotNull(response2);
			
			Assert.IsNotNull(response2.Result);
			
			Assert.AreEqual(response2.RetCode, 0);
			
			Task.Delay(20000).Wait();
		}

		public string SendTest(RequestPayload payload)
		{
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

