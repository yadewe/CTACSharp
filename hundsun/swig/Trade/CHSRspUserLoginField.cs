//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Trade {

public class CHSRspUserLoginField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspUserLoginField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspUserLoginField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspUserLoginField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspUserLoginField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int BranchID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_BranchID_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public int TradingDay {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_TradingDay_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PreTradingDay {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_PreTradingDay_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_PreTradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public char BillConfirmFlag {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_BillConfirmFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_BillConfirmFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public char UserApplicationType {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_UserApplicationType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_UserApplicationType_get(swigCPtr);
      return ret;
    } 
  }

  public string UserApplicationInfo {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_UserApplicationInfo_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspUserLoginField_UserApplicationInfo_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspUserLoginField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspUserLoginField(), true) {
  }

}

}