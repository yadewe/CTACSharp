//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIApplicationInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIApplicationInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIApplicationInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIApplicationInfo() {
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
          TapQuoteCppWrapperPINVOKE.delete_TapAPIApplicationInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AuthCode {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIApplicationInfo_AuthCode_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIApplicationInfo_AuthCode_get(swigCPtr);
      return ret;
    } 
  }

  public string KeyOperationLogPath {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIApplicationInfo_KeyOperationLogPath_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIApplicationInfo_KeyOperationLogPath_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIApplicationInfo() : this(TapQuoteCppWrapperPINVOKE.new_TapAPIApplicationInfo(), true) {
  }

}