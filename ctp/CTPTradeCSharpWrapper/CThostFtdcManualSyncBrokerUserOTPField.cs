//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcManualSyncBrokerUserOTPField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcManualSyncBrokerUserOTPField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcManualSyncBrokerUserOTPField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcManualSyncBrokerUserOTPField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcManualSyncBrokerUserOTPField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char OTPType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_OTPType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_OTPType_get(swigCPtr);
      return ret;
    } 
  }

  public string FirstOTP {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_FirstOTP_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_FirstOTP_get(swigCPtr);
      return ret;
    } 
  }

  public string SecondOTP {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_SecondOTP_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcManualSyncBrokerUserOTPField_SecondOTP_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcManualSyncBrokerUserOTPField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcManualSyncBrokerUserOTPField(), true) {
  }

}