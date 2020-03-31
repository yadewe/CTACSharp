using System;

namespace TapTradeTest
{
    class TapTradeAPINotifyImpl : ITapTradeAPINotify
    {
        public uint SessionId;

        public bool ApiReady
        {
            get { return _apiReady; }
        }
        private bool _apiReady = false;

        public override void OnConnect()
        {
            Console.WriteLine("OnConnect");
        }

        public override void OnRspLogin(int errorCode, TapAPITradeLoginRspInfo loginRspInfo)
        {
            if (errorCode == 0)
            {
                Console.WriteLine("login successfully");
            }
            else
            {
                Console.WriteLine("login failed");
            }
        }

        public override void OnAPIReady(int errorCode)
        {
            Console.WriteLine("OnAPIReady");
            _apiReady = true;
        }

        public override void OnRtnOrder(TapAPIOrderInfoNotice info)
        {
            if (info != null)
            {
                if (info.ErrorCode != 0)
                {
                    Console.WriteLine("OnRtnOrder error!");
                }
                else
                {
                    if (info.SessionID == SessionId)
                    {
                        if (info.OrderInfo.ErrorCode != 0)
                        {
                            Console.WriteLine("InsertOrder failed. {0} {1}", info.OrderInfo.OrderState, info.OrderInfo.OrderNo);
                        }
                        else
                        {
                            Console.WriteLine("InsertOrder succeed. {0} {1}", info.OrderInfo.OrderState, info.OrderInfo.OrderNo);
                        }
                    }
                }
            }
        }

        public virtual void OnRtnContactInfo(int errorCode, char isLast, string ContactInfo)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnContactInfo(swigCPtr, errorCode, isLast, ContactInfo");
        }

        public virtual void OnRspRequestVertificateCode(uint sessionID, int errorCode, TapAPIRequestVertificateCodeRsp rsp)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspRequestVertificateCode(swigCPtr, sessionID, errorCode, TapAPIRequestVertificateCodeRsp.getCPtr(rsp)");
        }

        public virtual void OnExpriationDate(string date, int days)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnExpriationDate(swigCPtr, date, days");
        }


        public virtual void OnDisconnect(int reasonCode)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnDisconnect(swigCPtr, reasonCode");
        }

        public virtual void OnRspChangePassword(uint sessionID, int errorCode)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspChangePassword(swigCPtr, sessionID, errorCode");
        }

        public virtual void OnRspAuthPassword(uint sessionID, int errorCode)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspAuthPassword(swigCPtr, sessionID, errorCode");
        }

        public virtual void OnRspQryTradingDate(uint sessionID, int errorCode, TapAPITradingCalendarQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryTradingDate(swigCPtr, sessionID, errorCode, TapAPITradingCalendarQryRsp.getCPtr(info)");
        }

        public virtual void OnRspSetReservedInfo(uint sessionID, int errorCode, string info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspSetReservedInfo(swigCPtr, sessionID, errorCode, info");
        }

        public virtual void OnRspQryAccount(uint sessionID, uint errorCode, char isLast, TapAPIAccountInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryAccount(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountInfo.getCPtr(info)");
        }

        public virtual void OnRspQryFund(uint sessionID, int errorCode, char isLast, TapAPIFundData info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryFund(swigCPtr, sessionID, errorCode, isLast, TapAPIFundData.getCPtr(info)");
        }

        public virtual void OnRtnFund(TapAPIFundData info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnFund(swigCPtr, TapAPIFundData.getCPtr(info)");
        }

        public virtual void OnRspQryExchange(uint sessionID, int errorCode, char isLast, TapAPIExchangeInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryExchange(swigCPtr, sessionID, errorCode, isLast, TapAPIExchangeInfo.getCPtr(info)");
        }

        public virtual void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPICommodityInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryCommodity(swigCPtr, sessionID, errorCode, isLast, TapAPICommodityInfo.getCPtr(info)");
        }

        public virtual void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPITradeContractInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryContract(swigCPtr, sessionID, errorCode, isLast, TapAPITradeContractInfo.getCPtr(info)");
        }

        public virtual void OnRtnContract(TapAPITradeContractInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnContract(swigCPtr, TapAPITradeContractInfo.getCPtr(info)");
        }

        public virtual void OnRspOrderAction(uint sessionID, int errorCode, TapAPIOrderActionRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspOrderAction(swigCPtr, sessionID, errorCode, TapAPIOrderActionRsp.getCPtr(info)");
        }


        public virtual void OnRspQryOrder(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryOrder(swigCPtr, sessionID, errorCode, isLast, TapAPIOrderInfo.getCPtr(info)");
        }

        public virtual void OnRspQryOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryOrderProcess(swigCPtr, sessionID, errorCode, isLast, TapAPIOrderInfo.getCPtr(info)");
        }

        public virtual void OnRspQryFill(uint sessionID, int errorCode, char isLast, TapAPIFillInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryFill(swigCPtr, sessionID, errorCode, isLast, TapAPIFillInfo.getCPtr(info)");
        }

        public virtual void OnRtnFill(TapAPIFillInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnFill(swigCPtr, TapAPIFillInfo.getCPtr(info)");
        }

        public virtual void OnRspQryPosition(uint sessionID, int errorCode, char isLast, TapAPIPositionInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryPosition(swigCPtr, sessionID, errorCode, isLast, TapAPIPositionInfo.getCPtr(info)");
        }

        public virtual void OnRtnPosition(TapAPIPositionInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnPosition(swigCPtr, TapAPIPositionInfo.getCPtr(info)");
        }

        public virtual void OnRspQryPositionSummary(uint sessionID, int errorCode, char isLast, TapAPIPositionSummary info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryPositionSummary(swigCPtr, sessionID, errorCode, isLast, TapAPIPositionSummary.getCPtr(info)");
        }

        public virtual void OnRtnPositionSummary(TapAPIPositionSummary info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnPositionSummary(swigCPtr, TapAPIPositionSummary.getCPtr(info)");
        }

        public virtual void OnRtnPositionProfit(TapAPIPositionProfitNotice info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnPositionProfit(swigCPtr, TapAPIPositionProfitNotice.getCPtr(info)");
        }

        public virtual void OnRspQryCurrency(uint sessionID, int errorCode, char isLast, TapAPICurrencyInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryCurrency(swigCPtr, sessionID, errorCode, isLast, TapAPICurrencyInfo.getCPtr(info)");
        }

        public virtual void OnRspQryTradeMessage(uint sessionID, int errorCode, char isLast, TapAPITradeMessage info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryTradeMessage(swigCPtr, sessionID, errorCode, isLast, TapAPITradeMessage.getCPtr(info)");
        }

        public virtual void OnRtnTradeMessage(TapAPITradeMessage info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnTradeMessage(swigCPtr, TapAPITradeMessage.getCPtr(info)");
        }

        public virtual void OnRspQryHisOrder(uint sessionID, int errorCode, char isLast, TapAPIHisOrderQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryHisOrder(swigCPtr, sessionID, errorCode, isLast, TapAPIHisOrderQryRsp.getCPtr(info)");
        }

        public virtual void OnRspQryHisOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIHisOrderQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryHisOrderProcess(swigCPtr, sessionID, errorCode, isLast, TapAPIHisOrderQryRsp.getCPtr(info)");
        }

        public virtual void OnRspQryHisMatch(uint sessionID, int errorCode, char isLast, TapAPIHisMatchQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryHisMatch(swigCPtr, sessionID, errorCode, isLast, TapAPIHisMatchQryRsp.getCPtr(info)");
        }

        public virtual void OnRspQryHisPosition(uint sessionID, int errorCode, char isLast, TapAPIHisPositionQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryHisPosition(swigCPtr, sessionID, errorCode, isLast, TapAPIHisPositionQryRsp.getCPtr(info)");
        }

        public virtual void OnRspQryHisDelivery(uint sessionID, int errorCode, char isLast, TapAPIHisDeliveryQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryHisDelivery(swigCPtr, sessionID, errorCode, isLast, TapAPIHisDeliveryQryRsp.getCPtr(info)");
        }

        public virtual void OnRspQryAccountCashAdjust(uint sessionID, int errorCode, char isLast, TapAPIAccountCashAdjustQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryAccountCashAdjust(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountCashAdjustQryRsp.getCPtr(info)");
        }

        public virtual void OnRspQryBill(uint sessionID, int errorCode, char isLast, TapAPIBillQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryBill(swigCPtr, sessionID, errorCode, isLast, TapAPIBillQryRsp.getCPtr(info)");
        }

        public virtual void OnRspQryAccountFeeRent(uint sessionID, int errorCode, char isLast, TapAPIAccountFeeRentQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryAccountFeeRent(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountFeeRentQryRsp.getCPtr(info)");
        }

        public virtual void OnRspQryAccountMarginRent(uint sessionID, int errorCode, char isLast, TapAPIAccountMarginRentQryRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryAccountMarginRent(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountMarginRentQryRsp.getCPtr(info)");
        }

        public virtual void OnRspHKMarketOrderInsert(uint sessionID, int errorCode, TapAPIOrderMarketInsertRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspHKMarketOrderInsert(swigCPtr, sessionID, errorCode, TapAPIOrderMarketInsertRsp.getCPtr(info)");
        }

        public virtual void OnRspHKMarketOrderDelete(uint sessionID, int errorCode, TapAPIOrderMarketInsertRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspHKMarketOrderDelete(swigCPtr, sessionID, errorCode, TapAPIOrderMarketInsertRsp.getCPtr(info)");
        }

        public virtual void OnHKMarketQuoteNotice(TapAPIOrderQuoteMarketNotice info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnHKMarketQuoteNotice(swigCPtr, TapAPIOrderQuoteMarketNotice.getCPtr(info)");
        }

        public virtual void OnRspOrderLocalRemove(uint sessionID, int errorCode, TapAPIOrderLocalRemoveRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspOrderLocalRemove(swigCPtr, sessionID, errorCode, TapAPIOrderLocalRemoveRsp.getCPtr(info)");
        }

        public virtual void OnRspOrderLocalInput(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspOrderLocalInput(swigCPtr, sessionID, errorCode, TapAPIOrderInfo.getCPtr(info)");
        }

        public virtual void OnRspOrderLocalModify(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspOrderLocalModify(swigCPtr, sessionID, errorCode, TapAPIOrderInfo.getCPtr(info)");
        }

        public virtual void OnRspOrderLocalTransfer(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspOrderLocalTransfer(swigCPtr, sessionID, errorCode, TapAPIOrderInfo.getCPtr(info)");
        }

        public virtual void OnRspFillLocalInput(uint sessionID, int errorCode, TapAPIFillLocalInputReq info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspFillLocalInput(swigCPtr, sessionID, errorCode, TapAPIFillLocalInputReq.getCPtr(info)");
        }

        public virtual void OnRspFillLocalRemove(uint sessionID, int errorCode, TapAPIFillLocalRemoveReq info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspFillLocalRemove(swigCPtr, sessionID, errorCode, TapAPIFillLocalRemoveReq.getCPtr(info)");
        }

        public virtual void OnRspQrySpotLock(uint sessionID, int errorCode, char isLast, TapAPISpotLockDataRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQrySpotLock(swigCPtr, sessionID, errorCode, isLast, TapAPISpotLockDataRsp.getCPtr(info)");
        }

        public virtual void OnRtnSpotLock(TapAPISpotLockDataRsp info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnSpotLock(swigCPtr, TapAPISpotLockDataRsp.getCPtr(info)");
        }

        public virtual void OnRspSubmitUserLoginInfo(uint sessionID, int errorCode, char isLast, TapAPISubmitUserLoginRspInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspSubmitUserLoginInfo(swigCPtr, sessionID, errorCode, isLast, TapAPISubmitUserLoginRspInfo.getCPtr(info)");
        }

        public virtual void OnRspSpecialOrderAction(uint sessionID, int errorCode, TapAPISpecialOrderInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspSpecialOrderAction(swigCPtr, sessionID, errorCode, TapAPISpecialOrderInfo.getCPtr(info)");
        }

        public virtual void OnRtnSpecialOrder(TapAPISpecialOrderInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnSpecialOrder(swigCPtr, TapAPISpecialOrderInfo.getCPtr(info)");
        }

        public virtual void OnRspQrySpecialOrder(uint sessionID, int errorCode, char isLast, TapAPISpecialOrderInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQrySpecialOrder(swigCPtr, sessionID, errorCode, isLast, TapAPISpecialOrderInfo.getCPtr(info)");
        }

        public virtual void OnRspQryCombinePosition(uint sessionID, int errorCode, char isLast, TapAPICombinePositionInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRspQryCombinePosition(swigCPtr, sessionID, errorCode, isLast, TapAPICombinePositionInfo.getCPtr(info)");
        }

        public virtual void OnRtnCombinePosition(TapAPICombinePositionInfo info)
        {
            Console.WriteLine("TapTradeCppWrapperPINVOKE.ITapTradeAPINotify_OnRtnCombinePosition(swigCPtr, TapAPICombinePositionInfo.getCPtr(info)");
        }
    }
}
