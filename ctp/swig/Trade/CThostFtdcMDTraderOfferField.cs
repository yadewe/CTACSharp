//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Trade {

public class CThostFtdcMDTraderOfferField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMDTraderOfferField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMDTraderOfferField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMDTraderOfferField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcMDTraderOfferField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public char TraderConnectStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_TraderConnectStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_TraderConnectStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string ConnectRequestDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ConnectRequestDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ConnectRequestDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ConnectRequestTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ConnectRequestTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ConnectRequestTime_get(swigCPtr);
      return ret;
    } 
  }

  public string LastReportDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_LastReportDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_LastReportDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastReportTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_LastReportTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_LastReportTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ConnectDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ConnectDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ConnectDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ConnectTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ConnectTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_ConnectTime_get(swigCPtr);
      return ret;
    } 
  }

  public string StartDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_StartDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_StartDate_get(swigCPtr);
      return ret;
    } 
  }

  public string StartTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_StartTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_StartTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxTradeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_MaxTradeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_MaxTradeID_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxOrderMessageReference {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_MaxOrderMessageReference_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMDTraderOfferField_MaxOrderMessageReference_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMDTraderOfferField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcMDTraderOfferField(), true) {
  }

}

}
