//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcCFMMCTradingAccountTokenField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcCFMMCTradingAccountTokenField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcCFMMCTradingAccountTokenField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcCFMMCTradingAccountTokenField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcCFMMCTradingAccountTokenField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public int KeyID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_KeyID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_KeyID_get(swigCPtr);
      return ret;
    } 
  }

  public string Token {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_Token_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_Token_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcCFMMCTradingAccountTokenField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcCFMMCTradingAccountTokenField(), true) {
  }

}