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

public class CThostFtdcInputCombActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputCombActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputCombActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputCombActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcInputCombActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string CombActionRef {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_CombActionRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_CombActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public char CombDirection {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_CombDirection_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_CombDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInputCombActionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputCombActionField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcInputCombActionField(), true) {
  }

}

}
