//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIHisPositionQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIHisPositionQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIHisPositionQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIHisPositionQryRsp() {
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
          TapTradeCppWrapperPINVOKE.delete_TapAPIHisPositionQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string SettleDate {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_SettleDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_SettleDate_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSide {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_MatchSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_MatchSide_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint PositionQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string PositionNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroup {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_CurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_CurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string Currency {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_Currency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_Currency_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PreSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PreSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_SettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_SettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionDProfit {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionDProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_PositionDProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double LMEPositionProfit {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_LMEPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_LMEPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionMarketValue {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_OptionMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_OptionMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountInitialMargin {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountMaintenanceMargin {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_AccountMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperInitialMargin {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMaintenanceMargin {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_UpperMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public string SettleGroupNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_SettleGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryRsp_SettleGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIHisPositionQryRsp() : this(TapTradeCppWrapperPINVOKE.new_TapAPIHisPositionQryRsp(), true) {
  }

}
