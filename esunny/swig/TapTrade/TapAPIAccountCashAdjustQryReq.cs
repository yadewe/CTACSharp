//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIAccountCashAdjustQryReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountCashAdjustQryReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountCashAdjustQryReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIAccountCashAdjustQryReq() {
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
          TapTradeCppWrapperPINVOKE.delete_TapAPIAccountCashAdjustQryReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint SerialID {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_SerialID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_SerialID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountAttributeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_AccountAttributeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_AccountAttributeNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BeginDate {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_BeginDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_BeginDate_get(swigCPtr);
      return ret;
    } 
  }

  public string EndDate {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_EndDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_EndDate_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountCashAdjustQryReq() : this(TapTradeCppWrapperPINVOKE.new_TapAPIAccountCashAdjustQryReq(), true) {
  }

}