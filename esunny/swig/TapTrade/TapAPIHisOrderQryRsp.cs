//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIHisOrderQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIHisOrderQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIHisOrderQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIHisOrderQryRsp() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIHisOrderQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string Date {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_Date_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_Date_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSide {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_PositionEffect2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_PositionEffect2_get(swigCPtr);
      return ret;
    } 
  }

  public string InquiryNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_InquiryNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_InquiryNo_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMinQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMinQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMinQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderCanceledQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderCanceledQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderCanceledQty_get(swigCPtr);
      return ret;
    } 
  }

  public int RefInt {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_RefInt_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_RefInt_get(swigCPtr);
      return ret;
    } 
  }

  public double RefDouble {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_RefDouble_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_RefDouble_get(swigCPtr);
      return ret;
    } 
  }

  public string RefString {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_RefString_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_RefString_get(swigCPtr);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderStreamID {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperChannelNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_UpperChannelNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_UpperChannelNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderLocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderLocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public uint UpperStreamID {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_UpperStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_UpperStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSystemNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderExchangeSystemNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderExchangeSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderExchangeSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderParentSystemNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderParentSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderParentSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderInsertUserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderInsertUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderInsertUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderInsertTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderInsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderInsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommandUserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderCommandUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderCommandUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderUpdateUserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderUpdateUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderUpdateUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderUpdateTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderUpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderUpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderState {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderState_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderState_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderMatchPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderMatchPrice2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMatchPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMatchPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMatchQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMatchQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMatchQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMatchQty2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMatchQty2_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_OrderMatchQty2_get(swigCPtr);
      return ret;
    } 
  }

  public uint ErrorCode {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ErrorCode_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ErrorCode_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorText {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ErrorText_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_ErrorText_get(swigCPtr);
      return ret;
    } 
  }

  public char IsBackInput {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_IsBackInput_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_IsBackInput_get(swigCPtr);
      return ret;
    } 
  }

  public char IsDeleted {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_IsDeleted_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_IsDeleted_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public char AddOneIsValid {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_AddOneIsValid_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_AddOneIsValid_get(swigCPtr);
      return ret;
    } 
  }

  public uint MinClipSize {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_MinClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_MinClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint MaxClipSize {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_MaxClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_MaxClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public string LicenseNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_LicenseNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_LicenseNo_get(swigCPtr);
      return ret;
    } 
  }

  public char TacticsType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_TacticsType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_TacticsType_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerCondition {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_TriggerCondition_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_TriggerCondition_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerPriceType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_TriggerPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisOrderQryRsp_TriggerPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIHisOrderQryRsp() : this(TapTradeCppWrapperPINVOKE.new_TapAPIHisOrderQryRsp(), true) {
  }

}
