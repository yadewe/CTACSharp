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

public class CThostFtdcMarketDataUpdateTimeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataUpdateTimeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataUpdateTimeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataUpdateTimeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcMarketDataUpdateTimeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataUpdateTimeField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataUpdateTimeField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string UpdateTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataUpdateTimeField_UpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataUpdateTimeField_UpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public int UpdateMillisec {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataUpdateTimeField_UpdateMillisec_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataUpdateTimeField_UpdateMillisec_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataUpdateTimeField_ActionDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataUpdateTimeField_ActionDay_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataUpdateTimeField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcMarketDataUpdateTimeField(), true) {
  }

}

}