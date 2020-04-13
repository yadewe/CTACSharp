//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIContract : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIContract(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIContract obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIContract() {
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
          TapTradeCppWrapperPINVOKE.delete_TapAPIContract(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TapAPICommodity Commodity {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIContract_Commodity_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapTradeCppWrapperPINVOKE.TapAPIContract_Commodity_get(swigCPtr);
      TapAPICommodity ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public string ContractNo1 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIContract_ContractNo1_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIContract_ContractNo1_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice1 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIContract_StrikePrice1_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIContract_StrikePrice1_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag1 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIContract_CallOrPutFlag1_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIContract_CallOrPutFlag1_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIContract_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIContract_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIContract_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIContract_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIContract_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIContract_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIContract() : this(TapTradeCppWrapperPINVOKE.new_TapAPIContract(), true) {
  }

}
