//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPICommodityInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPICommodityInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPICommodityInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPICommodityInfo() {
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
          TapTradeCppWrapperPINVOKE.delete_TapAPICommodityInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityName {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityName_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityEngName {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityEngName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityEngName_get(swigCPtr);
      return ret;
    } 
  }

  public string RelateExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char RelateCommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateCommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateCommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string RelateCommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateCommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateCommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string RelateExchangeNo2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateExchangeNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateExchangeNo2_get(swigCPtr);
      return ret;
    } 
  }

  public char RelateCommodityType2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateCommodityType2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateCommodityType2_get(swigCPtr);
      return ret;
    } 
  }

  public string RelateCommodityNo2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateCommodityNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_RelateCommodityNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroupNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CurrencyGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CurrencyGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeCurrency {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_TradeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_TradeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public char OpenCloseMode {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_OpenCloseMode_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_OpenCloseMode_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikePriceTimes {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_StrikePriceTimes_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_StrikePriceTimes_get(swigCPtr);
      return ret;
    } 
  }

  public double CommodityTickSize {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityTickSize_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityTickSize_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityDenominator {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityDenominator_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityDenominator_get(swigCPtr);
      return ret;
    } 
  }

  public char CmbDirect {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CmbDirect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CmbDirect_get(swigCPtr);
      return ret;
    } 
  }

  public char DeliveryMode {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_DeliveryMode_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_DeliveryMode_get(swigCPtr);
      return ret;
    } 
  }

  public int DeliveryDays {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_DeliveryDays_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_DeliveryDays_get(swigCPtr);
      return ret;
    } 
  }

  public string AddOneTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_AddOneTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_AddOneTime_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityTimeZone {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityTimeZone_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_CommodityTimeZone_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPICommodityInfo_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPICommodityInfo() : this(TapTradeCppWrapperPINVOKE.new_TapAPICommodityInfo(), true) {
  }

}
