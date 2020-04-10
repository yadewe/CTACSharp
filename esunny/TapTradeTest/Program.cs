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

            var trade = new TapTradeAPINotifyImpl2();
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
                Thread.Sleep(000);
                Console.WriteLine("api not ready... watit " + i++);
            }

            // TestOrderInsert(api, userName);

            var version = TapTradeCppWrapper.GetITapTradeAPIVersion();
            Console.WriteLine($"version:{version}");
            var error = TapTradeCppWrapper.GetITapErrorDescribe(2);
            Console.WriteLine($"error:{error}");
            while (true)
            {
                Thread.Sleep(100);
            }
        }

        private static void TestOrderInsert(ITapTradeAPI api, string userName)
        {
            var order = new TapAPINewOrder();
            order.AccountNo = userName;
            order.ExchangeNo = "CFFEX";
            order.CommodityType = 'F';
            order.CommodityNo = "IF";
            order.ContractNo = "1803";
            order.StrikePrice = "";
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
            order.OrderPrice = 0.0;
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
            api.InsertOrder(out id2, num, order);
        }
    }
}
