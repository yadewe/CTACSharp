//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Market {

public class CThostFtdcAuthenticationInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcAuthenticationInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcAuthenticationInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcAuthenticationInfoField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcAuthenticationInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string AuthInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_AuthInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_AuthInfo_get(swigCPtr);
      return ret;
    } 
  }

  public int IsResult {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_IsResult_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcAuthenticationInfoField_IsResult_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcAuthenticationInfoField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcAuthenticationInfoField(), true) {
  }

}

}
