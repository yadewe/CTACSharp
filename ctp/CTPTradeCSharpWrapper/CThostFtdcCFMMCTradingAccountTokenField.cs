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
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcCFMMCTradingAccountTokenField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public int KeyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_KeyID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_KeyID_get(swigCPtr);
      return ret;
    } 
  }

  public string Token {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_Token_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcCFMMCTradingAccountTokenField_Token_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcCFMMCTradingAccountTokenField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcCFMMCTradingAccountTokenField(), true) {
  }

}

}
