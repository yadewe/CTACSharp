//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqDayEndFileReadyField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqDayEndFileReadyField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqDayEndFileReadyField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqDayEndFileReadyField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcReqDayEndFileReadyField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public char FileBusinessCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_FileBusinessCode_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_FileBusinessCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqDayEndFileReadyField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqDayEndFileReadyField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcReqDayEndFileReadyField(), true) {
  }

}