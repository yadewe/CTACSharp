//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPISubmitUserLoginInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPISubmitUserLoginInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPISubmitUserLoginInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPISubmitUserLoginInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPISubmitUserLoginInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string GatherInfo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_GatherInfo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_GatherInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientLoginIP {
    set {
      TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint ClientLoginPort {
    set {
      TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginPort_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginPort_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientLoginDateTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientAppID {
    set {
      TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_ClientAppID_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_ClientAppID_get(swigCPtr);
      return ret;
    } 
  }

  public uint AuthKeyVersion {
    set {
      TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_AuthKeyVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_AuthKeyVersion_get(swigCPtr);
      return ret;
    } 
  }

  public char AbnormalNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_AbnormalNo_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPISubmitUserLoginInfo_AbnormalNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPISubmitUserLoginInfo() : this(TapTradeCppWrapperPINVOKE.new_TapAPISubmitUserLoginInfo(), true) {
  }

}
