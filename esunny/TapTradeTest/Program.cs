using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TapTradeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TapTrade Test start");

            var app = new TapAPIApplicationInfo();
            app.AuthCode =
                "67EA896065459BECDFDB924B29CB7DF1946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE41BCBAB68D525B0D111A0884D847D57163FF7F329FA574E7946CED32E26C1EAC946CED32E26C1EAC733827B0CE853869ABD9B8F170E14F8847D3EA0BF4E191F5D97B3DFE4CCB1F01842DD2B3EA2F4B20CAD19B8347719B7E20EA1FA7A3D1BFEFF22290F4B5C43E6C520ED5A40EC1D50ACDF342F46A92CCF87AEE6D73542C42EC17818349C7DEDAB0E4DB16977714F873D505029E27B3D57EB92D5BEDA0A710197EB67F94BB1892B30F58A3F211D9C3B3839BE2D73FD08DD776B9188654853DDA57675EBB7D6FBBFC";
            app.KeyOperationLogPath = "\\log";
            int iResult = 0;
            var api = TapTradeCppWrapper.CreateITapTradeAPI(app, out iResult);

            if (api == null)
            {
                Console.WriteLine("Failed to create api");
                return;
            }

            var trade = new TapTradeAPINotifyImpl();
            api.SetAPINotify(trade);

            const string userName = "Q513677011";
            api.SetHostAddress("61.163.243.173", 8383);
            var loginAuth = new TapAPITradeLoginAuth();
            loginAuth.UserNo = userName;
            loginAuth.Password = "566716";
            loginAuth.ISModifyPassword = 'N';
            //loginAuth.ISDDA = 'N';
            var err = api.Login(loginAuth);
            Console.WriteLine("login result " + err);
            int i = 0;
            while (!trade.ApiReady)
            {
                Console.WriteLine("api not ready... watit " + i++);
                Thread.Sleep(1000);
            }

            TestOrderInsert(api, "test");
            //TestOrderInsert(api, userName);

            var version = TapTradeCppWrapper.GetITapTradeAPIVersion();
            Console.WriteLine($"version:{version}");
            var error = TapTradeCppWrapper.GetITapErrorDescribe(2);
            Console.WriteLine($"test get error message 2:{error}");

            uint sessionId = 0;
            var result = api.QryTradingDate(out sessionId);
            Console.WriteLine($"QryTradingDate:{result}");
            //result = api.QryCommodity(out sessionId);
            //Console.WriteLine($"QryCommodity:{result}");
            result = api.QryContract(out sessionId, new TapAPICommodity() { ExchangeNo = "HKEX", CommodityNo= "HSI", CommodityType='F' });
            Console.WriteLine($"QryContract:{result}");
            //result = api.QryExchange(out sessionId);
            //Console.WriteLine($"QryExchange:{result}");
            //result = api.QryCurrency(out sessionId);
            //Console.WriteLine($"QryCurrency:{result}");

            var accInfo = new TapAPIAccQryReq();
            //exInfo.ExchangeName = "";
            //exInfo.ExchangeNo = "";
            result = api.QryAccount(out sessionId, accInfo);
            Console.WriteLine($"QryAccount:{result},info:{accInfo}");

            while (true)
            {
                Thread.Sleep(100);
            }
        }

        private static void TestOrderInsert(ITapTradeAPI api, string userName)
        {
            // {"ExchangeNo":"HKEX","CommodityType":"F","CommodityNo":"HSI","CommodityName":"恒生指数期货","CommodityEngName":"Hang Seng Index","RelateExchangeNo":"","RelateCommodityType":"\u0000","RelateCommodityNo":"","RelateExchangeNo2":"","RelateCommodityType2":"\u0000","RelateCommodityNo2":"","CurrencyGroupNo":"OTHER","TradeCurrency":"HKD","ContractSize":50.0,"OpenCloseMode":"N","StrikePriceTimes":0.0,"CommodityTickSize":1.0,"CommodityDenominator":1,"CmbDirect":"\u0000","DeliveryMode":"C","DeliveryDays":0,"AddOneTime":"16:50:00","CommodityTimeZone":8,"IsAddOne":"N"}
            // {"ExchangeNo":"HKEX","CommodityType":"F","CommodityNo":"HSI","ContractNo1":"2005","StrikePrice1":"","CallOrPutFlag1":"N","ContractNo2":"","StrikePrice2":"","CallOrPutFlag2":"N","ContractType":"1","QuoteUnderlyingContract":"","ContractName":"恒生指数期货 2005","ContractExpDate":"2020-05-28","LastTradeDate":"2020-05-28","FirstNoticeDate":"2020-05-28"}
            var order = new TapAPINewOrder();
            order.AccountNo = userName;
            order.ExchangeNo = "HKEX";
            order.CommodityType = 'F';
            order.CommodityNo = "HSI";
            order.ContractNo = "2005";
            order.StrikePrice = "1";
            order.CallOrPutFlag = 'N';
            order.ContractNo2 = "";
            order.StrikePrice2 = "";
            order.CallOrPutFlag2 = 'N';
            order.OrderType = '1';
            order.OrderSource = 'A';
            order.TimeInForce = '0';
            order.ExpireTime = "";
            order.IsRiskOrder = 'N';
            order.OrderSide = 'B';
            order.PositionEffect = 'O';
            order.PositionEffect2 = 'N';
            order.InquiryNo = "";
            order.HedgeFlag = 'T';
            order.OrderPrice = 10.0;
            order.OrderQty = 1;
            order.TacticsType = 'N';
            order.TriggerCondition = 'N';
            order.TriggerPriceType = 'N';
            order.AddOneIsValid = 'N';
            //order.HedgeFlag2 = 'N';
            //order.MarketLevel = 0;
            //order.OrderDeleteByDisConnFlag = 'N';
            string num = "123";
            uint id2 = 0;
            var result = api.InsertOrder(out id2, num, order);
            Console.WriteLine("InsertOrder result:" + result);
        }
    }
}
