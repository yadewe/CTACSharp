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

public class CThostFtdcBrokerUserOTPParamField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerUserOTPParamField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerUserOTPParamField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerUserOTPParamField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcBrokerUserOTPParamField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string OTPVendorsID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_OTPVendorsID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_OTPVendorsID_get(swigCPtr);
      return ret;
    } 
  }

  public string SerialNumber {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_SerialNumber_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_SerialNumber_get(swigCPtr);
      return ret;
    } 
  }

  public string AuthKey {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_AuthKey_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_AuthKey_get(swigCPtr);
      return ret;
    } 
  }

  public int LastDrift {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_LastDrift_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_LastDrift_get(swigCPtr);
      return ret;
    } 
  }

  public int LastSuccess {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_LastSuccess_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_LastSuccess_get(swigCPtr);
      return ret;
    } 
  }

  public char OTPType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_OTPType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserOTPParamField_OTPType_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerUserOTPParamField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcBrokerUserOTPParamField(), true) {
  }

}

}
