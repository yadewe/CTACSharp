//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIOrderLocalRemoveRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderLocalRemoveRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderLocalRemoveRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderLocalRemoveRsp() {
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
          TapTradeCppWrapperPINVOKE.delete_TapAPIOrderLocalRemoveRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TapAPIOrderLocalRemoveReq req {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_req_set(swigCPtr, TapAPIOrderLocalRemoveReq.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapTradeCppWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_req_get(swigCPtr);
      TapAPIOrderLocalRemoveReq ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIOrderLocalRemoveReq(cPtr, false);
      return ret;
    } 
  }

  public string ClientLocalIP {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientLocalIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientLocalIP_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientMac {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientMac_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientMac_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientIP {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientIP_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderLocalRemoveRsp() : this(TapTradeCppWrapperPINVOKE.new_TapAPIOrderLocalRemoveRsp(), true) {
  }

}
