//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Trade {

public class CThostFtdcQryInstrumentStatusField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryInstrumentStatusField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryInstrumentStatusField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryInstrumentStatusField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcQryInstrumentStatusField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryInstrumentStatusField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryInstrumentStatusField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryInstrumentStatusField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryInstrumentStatusField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryInstrumentStatusField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcQryInstrumentStatusField(), true) {
  }

}

}