//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIExchangeInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIExchangeInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIExchangeInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIExchangeInfo() {
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
          TapQuoteCppWrapperPINVOKE.delete_TapAPIExchangeInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ExchangeNo {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIExchangeInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIExchangeInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeName {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIExchangeInfo_ExchangeName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIExchangeInfo_ExchangeName_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIExchangeInfo() : this(TapQuoteCppWrapperPINVOKE.new_TapAPIExchangeInfo(), true) {
  }

}
