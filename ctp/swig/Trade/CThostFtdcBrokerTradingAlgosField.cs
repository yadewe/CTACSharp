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

public class CThostFtdcBrokerTradingAlgosField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerTradingAlgosField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerTradingAlgosField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerTradingAlgosField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcBrokerTradingAlgosField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char HandlePositionAlgoID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_HandlePositionAlgoID_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_HandlePositionAlgoID_get(swigCPtr);
      return ret;
    } 
  }

  public char FindMarginRateAlgoID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_FindMarginRateAlgoID_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_FindMarginRateAlgoID_get(swigCPtr);
      return ret;
    } 
  }

  public char HandleTradingAccountAlgoID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_HandleTradingAccountAlgoID_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerTradingAlgosField_HandleTradingAccountAlgoID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerTradingAlgosField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcBrokerTradingAlgosField(), true) {
  }

}

}