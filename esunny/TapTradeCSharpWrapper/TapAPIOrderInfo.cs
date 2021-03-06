//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIOrderInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIOrderInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSide {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_PositionEffect2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_PositionEffect2_get(swigCPtr);
      return ret;
    } 
  }

  public string InquiryNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_InquiryNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_InquiryNo_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMinQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMinQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMinQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderCanceledQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderCanceledQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderCanceledQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint MinClipSize {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MinClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MinClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint MaxClipSize {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MaxClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MaxClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public string LicenseNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_LicenseNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_LicenseNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RefInt {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_RefInt_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_RefInt_get(swigCPtr);
      return ret;
    } 
  }

  public string RefString {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_RefString_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_RefString_get(swigCPtr);
      return ret;
    } 
  }

  public string ParentAccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ParentAccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ParentAccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientOrderNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ClientOrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ClientOrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderLocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderLocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSystemNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderExchangeSystemNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderExchangeSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderExchangeSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderParentNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderParentNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderParentNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderParentSystemNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderParentSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderParentSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TradeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TradeNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperChannelNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperChannelNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperChannelNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperSettleNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperSettleNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperSettleNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperUserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderInsertUserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderInsertUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderInsertUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderInsertTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderInsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderInsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommandUserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderCommandUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderCommandUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderUpdateUserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderUpdateUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderUpdateUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderUpdateTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderUpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderUpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderState {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderState_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderState_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderMatchPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderMatchPrice2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMatchPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMatchPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMatchQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMatchQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMatchQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMatchQty2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMatchQty2_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderMatchQty2_get(swigCPtr);
      return ret;
    } 
  }

  public uint ErrorCode {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ErrorCode_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ErrorCode_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorText {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ErrorText_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ErrorText_get(swigCPtr);
      return ret;
    } 
  }

  public char IsBackInput {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_IsBackInput_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_IsBackInput_get(swigCPtr);
      return ret;
    } 
  }

  public char IsDeleted {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_IsDeleted_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_IsDeleted_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderStreamID {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public uint UpperStreamID {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_UpperStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ContractSize2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_ContractSize2_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrencyGroup {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CommodityCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CommodityCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrency {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CommodityCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CommodityCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public char FeeMode {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeMode_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeMode_get(swigCPtr);
      return ret;
    } 
  }

  public double FeeParam {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeParam_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeParam_get(swigCPtr);
      return ret;
    } 
  }

  public string FeeCurrencyGroup {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string FeeCurrency {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public char FeeMode2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeMode2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeMode2_get(swigCPtr);
      return ret;
    } 
  }

  public double FeeParam2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeParam2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeParam2_get(swigCPtr);
      return ret;
    } 
  }

  public string FeeCurrencyGroup2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeCurrencyGroup2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeCurrencyGroup2_get(swigCPtr);
      return ret;
    } 
  }

  public string FeeCurrency2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeCurrency2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeCurrency2_get(swigCPtr);
      return ret;
    } 
  }

  public char MarginMode {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginMode_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginMode_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginParam {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginParam_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginParam_get(swigCPtr);
      return ret;
    } 
  }

  public char MarginMode2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginMode2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginMode2_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginParam2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginParam2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginParam2_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_PreSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_PreSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlePrice2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_PreSettlePrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_PreSettlePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public uint OpenVol {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OpenVol_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OpenVol_get(swigCPtr);
      return ret;
    } 
  }

  public uint CoverVol {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CoverVol_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CoverVol_get(swigCPtr);
      return ret;
    } 
  }

  public uint OpenVol2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OpenVol2_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OpenVol2_get(swigCPtr);
      return ret;
    } 
  }

  public uint CoverVol2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CoverVol2_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_CoverVol2_get(swigCPtr);
      return ret;
    } 
  }

  public double FeeValue {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_FeeValue_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginValue {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarginValue_get(swigCPtr);
      return ret;
    } 
  }

  public char TacticsType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TacticsType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TacticsType_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerCondition {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TriggerCondition_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TriggerCondition_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerPriceType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TriggerPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_TriggerPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char AddOneIsValid {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_AddOneIsValid_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_AddOneIsValid_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderQty2_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderQty2_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_HedgeFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_HedgeFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public byte MarketLevel {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarketLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_MarketLevel_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderDeleteByDisConnFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderDeleteByDisConnFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderInfo_OrderDeleteByDisConnFlag_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderInfo() : this(TapTradeCppWrapperPINVOKE.new_TapAPIOrderInfo(), true) {
  }

}
