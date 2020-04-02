//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIAccountInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIAccountInfo() {
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
          TapTradeCppWrapperPINVOKE.delete_TapAPIAccountInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountType_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountState {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountState_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountState_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountTradeRight {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountTradeRight_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountTradeRight_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityGroupNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_CommodityGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_CommodityGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountShortName {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountShortName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountShortName_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountEnShortName {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountEnShortName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIAccountInfo_AccountEnShortName_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountInfo() : this(TapTradeCppWrapperPINVOKE.new_TapAPIAccountInfo(), true) {
  }

}