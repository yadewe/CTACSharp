//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIHisPositionQryReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIHisPositionQryReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIHisPositionQryReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIHisPositionQryReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIHisPositionQryReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string Date {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryReq_Date_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryReq_Date_get(swigCPtr);
      return ret;
    } 
  }

  public char SettleFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryReq_SettleFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIHisPositionQryReq_SettleFlag_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIHisPositionQryReq() : this(TapTradeCppWrapperPINVOKE.new_TapAPIHisPositionQryReq(), true) {
  }

}
