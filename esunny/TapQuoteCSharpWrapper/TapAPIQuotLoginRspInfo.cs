//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIQuotLoginRspInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIQuotLoginRspInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuotLoginRspInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIQuotLoginRspInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapQuoteCppWrapperPINVOKE.delete_TapAPIQuotLoginRspInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UserNo {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public int UserType {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserType_set(swigCPtr, value);
    } 
    get {
      int ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserType_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteTempPassword {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_QuoteTempPassword_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_QuoteTempPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string ReservedInfo {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_ReservedInfo_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_ReservedInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginIP {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint LastLoginProt {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginProt_set(swigCPtr, value);
    } 
    get {
      uint ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginProt_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginTime {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLogoutTime {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLogoutTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLogoutTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastSettleTime {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastSettleTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastSettleTime_get(swigCPtr);
      return ret;
    } 
  }

  public string StartTime {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_StartTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_StartTime_get(swigCPtr);
      return ret;
    } 
  }

  public string InitTime {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_InitTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuotLoginRspInfo_InitTime_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIQuotLoginRspInfo() : this(TapQuoteCppWrapperPINVOKE.new_TapAPIQuotLoginRspInfo(), true) {
  }

}
