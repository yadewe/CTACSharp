//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIFillLocalRemoveReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIFillLocalRemoveReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIFillLocalRemoveReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIFillLocalRemoveReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIFillLocalRemoveReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public char ServerFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIFillLocalRemoveReq_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIFillLocalRemoveReq_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIFillLocalRemoveReq_MatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIFillLocalRemoveReq_MatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIFillLocalRemoveReq() : this(TapTradeCppWrapperPINVOKE.new_TapAPIFillLocalRemoveReq(), true) {
  }

}
