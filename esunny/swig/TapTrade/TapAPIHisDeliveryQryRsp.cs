//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIHisDeliveryQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIHisDeliveryQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIHisDeliveryQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIHisDeliveryQryRsp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIHisDeliveryQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string DeliveryDate {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryDate_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public char OpenSide {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OpenSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OpenSide_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint DeliveryQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint FrozenQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_FrozenQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_FrozenQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OpenNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OpenNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrencyGroupy {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CommodityCurrencyGroupy_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CommodityCurrencyGroupy_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrency {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CommodityCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_CommodityCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_PreSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_PreSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryProfit {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountFrozenInitialMargin {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountFrozenInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountFrozenInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountFrozenMaintenanceMargin {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountFrozenMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountFrozenMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperFrozenInitialMargin {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperFrozenInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperFrozenInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperFrozenMaintenanceMargin {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperFrozenMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperFrozenMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountFeeCurrencyGroup {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountFeeCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountFeeCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountFeeCurrency {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountFeeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountFeeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountDeliveryFee {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountDeliveryFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_AccountDeliveryFee_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperFeeCurrencyGroup {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperFeeCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperFeeCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperFeeCurrency {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperFeeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperFeeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperDeliveryFee {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperDeliveryFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_UpperDeliveryFee_get(swigCPtr);
      return ret;
    } 
  }

  public char DeliveryMode {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryMode_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_DeliveryMode_get(swigCPtr);
      return ret;
    } 
  }

  public string OperatorNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OperatorNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OperatorNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OperateTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OperateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_OperateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string SettleGourpNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_SettleGourpNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisDeliveryQryRsp_SettleGourpNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIHisDeliveryQryRsp() : this(TapTradeCppWrapperPINVOKE.new_TapAPIHisDeliveryQryRsp(), true) {
  }

}
