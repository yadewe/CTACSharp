//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIOrderMarketDeleteReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderMarketDeleteReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderMarketDeleteReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderMarketDeleteReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIOrderMarketDeleteReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public char ServerFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketDeleteReq_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketDeleteReq_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderBuyNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketDeleteReq_OrderBuyNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketDeleteReq_OrderBuyNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSellNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketDeleteReq_OrderSellNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketDeleteReq_OrderSellNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderMarketDeleteReq() : this(TapTradeCppWrapperPINVOKE.new_TapAPIOrderMarketDeleteReq(), true) {
  }

}
