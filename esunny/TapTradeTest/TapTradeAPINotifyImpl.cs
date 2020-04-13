using Newtonsoft.Json;
using System;

namespace TapTradeTest
{
    public class TapTradeAPINotifyImpl : ITapTradeAPINotify
    {
        public bool ApiReady { get; set; }
        public override void OnConnect()
        {
            Console.WriteLine("OnConnect");
        }

        public override void OnRspLogin(int errorCode, TapAPITradeLoginRspInfo loginRspInfo)
        {
                Console.WriteLine("login successfully "+ errorCode);
            
        }

        public override void OnAPIReady(int errorCode)
        {
            ApiReady = errorCode == 0;
            Console.WriteLine("OnAPIReady "+ errorCode);
        }

        public override void OnRtnOrder(TapAPIOrderInfoNotice info)
        {
            Console.WriteLine("InsertOrder failed. {0} {1}", info.OrderInfo.OrderState, info.OrderInfo.OrderNo);
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnContactInfo(int errorCode, char isLast, string ContactInfo)
        {
            Console.WriteLine("_OnRtnContactInfo(swigCPtr, errorCode, isLast, ContactInfo");
        }

        public virtual void OnRspRequestVertificateCode(uint sessionID, int errorCode, TapAPIRequestVertificateCodeRsp rsp)
        {
            Console.WriteLine("_OnRspRequestVertificateCode(swigCPtr, sessionID, errorCode, TapAPIRequestVertificateCodeRsp.getCPtr(rsp)");
        }

        public virtual void OnExpriationDate(string date, int days)
        {
            Console.WriteLine("_OnExpriationDate(swigCPtr, date, days");
        }
        

        public virtual void OnDisconnect(int reasonCode)
        {
            Console.WriteLine("_OnDisconnect(swigCPtr, reasonCode");
        }

        public virtual void OnRspChangePassword(uint sessionID, int errorCode)
        {
            Console.WriteLine("_OnRspChangePassword(swigCPtr, sessionID, errorCode");
        }

        public virtual void OnRspAuthPassword(uint sessionID, int errorCode)
        {
            Console.WriteLine("_OnRspAuthPassword(swigCPtr, sessionID, errorCode");
        }

        public virtual void OnRspQryTradingDate(uint sessionID, int errorCode, TapAPITradingCalendarQryRsp info)
        {
            Console.WriteLine("_OnRspQryTradingDate(swigCPtr, sessionID, errorCode, TapAPITradingCalendarQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspSetReservedInfo(uint sessionID, int errorCode, string info)
        {
            Console.WriteLine("_OnRspSetReservedInfo(swigCPtr, sessionID, errorCode, info");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryAccount(uint sessionID, uint errorCode, char isLast, TapAPIAccountInfo info)
        {
            Console.WriteLine("_OnRspQryAccount(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryFund(uint sessionID, int errorCode, char isLast, TapAPIFundData info)
        {
            Console.WriteLine("_OnRspQryFund(swigCPtr, sessionID, errorCode, isLast, TapAPIFundData.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnFund(TapAPIFundData info)
        {
            Console.WriteLine("_OnRtnFund(swigCPtr, TapAPIFundData.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryExchange(uint sessionID, int errorCode, char isLast, TapAPIExchangeInfo info)
        {
            Console.WriteLine("_OnRspQryExchange(swigCPtr, sessionID, errorCode, isLast, TapAPIExchangeInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPICommodityInfo info)
        {
            Console.WriteLine("_OnRspQryCommodity(swigCPtr, sessionID, errorCode, isLast, TapAPICommodityInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPITradeContractInfo info)
        {
            Console.WriteLine("_OnRspQryContract(swigCPtr, sessionID, errorCode, isLast, TapAPITradeContractInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnContract(TapAPITradeContractInfo info)
        {
            Console.WriteLine("_OnRtnContract(swigCPtr, TapAPITradeContractInfo.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspOrderAction(uint sessionID, int errorCode, TapAPIOrderActionRsp info)
        {
            Console.WriteLine("_OnRspOrderAction(swigCPtr, sessionID, errorCode, TapAPIOrderActionRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }


        public virtual void OnRspQryOrder(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {
            Console.WriteLine("_OnRspQryOrder(swigCPtr, sessionID, errorCode, isLast, TapAPIOrderInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {
            Console.WriteLine("_OnRspQryOrderProcess(swigCPtr, sessionID, errorCode, isLast, TapAPIOrderInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryFill(uint sessionID, int errorCode, char isLast, TapAPIFillInfo info)
        {
            Console.WriteLine("_OnRspQryFill(swigCPtr, sessionID, errorCode, isLast, TapAPIFillInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnFill(TapAPIFillInfo info)
        {
            Console.WriteLine("_OnRtnFill(swigCPtr, TapAPIFillInfo.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryPosition(uint sessionID, int errorCode, char isLast, TapAPIPositionInfo info)
        {
            Console.WriteLine("_OnRspQryPosition(swigCPtr, sessionID, errorCode, isLast, TapAPIPositionInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnPosition(TapAPIPositionInfo info)
        {
            Console.WriteLine("_OnRtnPosition(swigCPtr, TapAPIPositionInfo.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryPositionSummary(uint sessionID, int errorCode, char isLast, TapAPIPositionSummary info)
        {
            Console.WriteLine("_OnRspQryPositionSummary(swigCPtr, sessionID, errorCode, isLast, TapAPIPositionSummary.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnPositionSummary(TapAPIPositionSummary info)
        {
            Console.WriteLine("_OnRtnPositionSummary(swigCPtr, TapAPIPositionSummary.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnPositionProfit(TapAPIPositionProfitNotice info)
        {
            Console.WriteLine("_OnRtnPositionProfit(swigCPtr, TapAPIPositionProfitNotice.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryCurrency(uint sessionID, int errorCode, char isLast, TapAPICurrencyInfo info)
        {
            Console.WriteLine("_OnRspQryCurrency(swigCPtr, sessionID, errorCode, isLast, TapAPICurrencyInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryTradeMessage(uint sessionID, int errorCode, char isLast, TapAPITradeMessage info)
        {
            Console.WriteLine("_OnRspQryTradeMessage(swigCPtr, sessionID, errorCode, isLast, TapAPITradeMessage.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnTradeMessage(TapAPITradeMessage info)
        {
            Console.WriteLine("_OnRtnTradeMessage(swigCPtr, TapAPITradeMessage.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryHisOrder(uint sessionID, int errorCode, char isLast, TapAPIHisOrderQryRsp info)
        {
            Console.WriteLine("_OnRspQryHisOrder(swigCPtr, sessionID, errorCode, isLast, TapAPIHisOrderQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryHisOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIHisOrderQryRsp info)
        {
            Console.WriteLine("_OnRspQryHisOrderProcess(swigCPtr, sessionID, errorCode, isLast, TapAPIHisOrderQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryHisMatch(uint sessionID, int errorCode, char isLast, TapAPIHisMatchQryRsp info)
        {
            Console.WriteLine("_OnRspQryHisMatch(swigCPtr, sessionID, errorCode, isLast, TapAPIHisMatchQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryHisPosition(uint sessionID, int errorCode, char isLast, TapAPIHisPositionQryRsp info)
        {
            Console.WriteLine("_OnRspQryHisPosition(swigCPtr, sessionID, errorCode, isLast, TapAPIHisPositionQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryHisDelivery(uint sessionID, int errorCode, char isLast, TapAPIHisDeliveryQryRsp info)
        {
            Console.WriteLine("_OnRspQryHisDelivery(swigCPtr, sessionID, errorCode, isLast, TapAPIHisDeliveryQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryAccountCashAdjust(uint sessionID, int errorCode, char isLast, TapAPIAccountCashAdjustQryRsp info)
        {
            Console.WriteLine("_OnRspQryAccountCashAdjust(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountCashAdjustQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryBill(uint sessionID, int errorCode, char isLast, TapAPIBillQryRsp info)
        {
            Console.WriteLine("_OnRspQryBill(swigCPtr, sessionID, errorCode, isLast, TapAPIBillQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryAccountFeeRent(uint sessionID, int errorCode, char isLast, TapAPIAccountFeeRentQryRsp info)
        {
            Console.WriteLine("_OnRspQryAccountFeeRent(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountFeeRentQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryAccountMarginRent(uint sessionID, int errorCode, char isLast, TapAPIAccountMarginRentQryRsp info)
        {
            Console.WriteLine("_OnRspQryAccountMarginRent(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountMarginRentQryRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspHKMarketOrderInsert(uint sessionID, int errorCode, TapAPIOrderMarketInsertRsp info)
        {
            Console.WriteLine("_OnRspHKMarketOrderInsert(swigCPtr, sessionID, errorCode, TapAPIOrderMarketInsertRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspHKMarketOrderDelete(uint sessionID, int errorCode, TapAPIOrderMarketInsertRsp info)
        {
            Console.WriteLine("_OnRspHKMarketOrderDelete(swigCPtr, sessionID, errorCode, TapAPIOrderMarketInsertRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnHKMarketQuoteNotice(TapAPIOrderQuoteMarketNotice info)
        {
            Console.WriteLine("_OnHKMarketQuoteNotice(swigCPtr, TapAPIOrderQuoteMarketNotice.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspOrderLocalRemove(uint sessionID, int errorCode, TapAPIOrderLocalRemoveRsp info)
        {
            Console.WriteLine("_OnRspOrderLocalRemove(swigCPtr, sessionID, errorCode, TapAPIOrderLocalRemoveRsp.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspOrderLocalInput(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            Console.WriteLine("_OnRspOrderLocalInput(swigCPtr, sessionID, errorCode, TapAPIOrderInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspOrderLocalModify(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            Console.WriteLine("_OnRspOrderLocalModify(swigCPtr, sessionID, errorCode, TapAPIOrderInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspOrderLocalTransfer(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            Console.WriteLine("_OnRspOrderLocalTransfer(swigCPtr, sessionID, errorCode, TapAPIOrderInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspFillLocalInput(uint sessionID, int errorCode, TapAPIFillLocalInputReq info)
        {
            Console.WriteLine("_OnRspFillLocalInput(swigCPtr, sessionID, errorCode, TapAPIFillLocalInputReq.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspFillLocalRemove(uint sessionID, int errorCode, TapAPIFillLocalRemoveReq info)
        {
            Console.WriteLine("_OnRspFillLocalRemove(swigCPtr, sessionID, errorCode, TapAPIFillLocalRemoveReq.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQrySpotLock(uint sessionID, int errorCode, char isLast, TapAPISpotLockDataRsp info)
        {
            Console.WriteLine("_OnRspQrySpotLock(swigCPtr, sessionID, errorCode, isLast, TapAPISpotLockDataRsp.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnSpotLock(TapAPISpotLockDataRsp info)
        {
            Console.WriteLine("_OnRtnSpotLock(swigCPtr, TapAPISpotLockDataRsp.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspSubmitUserLoginInfo(uint sessionID, int errorCode, char isLast, TapAPISubmitUserLoginRspInfo info)
        {
            Console.WriteLine("_OnRspSubmitUserLoginInfo(swigCPtr, sessionID, errorCode, isLast, TapAPISubmitUserLoginRspInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspSpecialOrderAction(uint sessionID, int errorCode, TapAPISpecialOrderInfo info)
        {
            Console.WriteLine("_OnRspSpecialOrderAction(swigCPtr, sessionID, errorCode, TapAPISpecialOrderInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnSpecialOrder(TapAPISpecialOrderInfo info)
        {
            Console.WriteLine("_OnRtnSpecialOrder(swigCPtr, TapAPISpecialOrderInfo.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQrySpecialOrder(uint sessionID, int errorCode, char isLast, TapAPISpecialOrderInfo info)
        {
            Console.WriteLine("_OnRspQrySpecialOrder(swigCPtr, sessionID, errorCode, isLast, TapAPISpecialOrderInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRspQryCombinePosition(uint sessionID, int errorCode, char isLast, TapAPICombinePositionInfo info)
        {
            Console.WriteLine("_OnRspQryCombinePosition(swigCPtr, sessionID, errorCode, isLast, TapAPICombinePositionInfo.getCPtr(info)");
            Console.WriteLine($"errorCode:{errorCode}, {JsonConvert.SerializeObject(info)}");
        }

        public virtual void OnRtnCombinePosition(TapAPICombinePositionInfo info)
        {
            Console.WriteLine("_OnRtnCombinePosition(swigCPtr, TapAPICombinePositionInfo.getCPtr(info)");
            Console.WriteLine($" {JsonConvert.SerializeObject(info)}");
        }
    }
}
