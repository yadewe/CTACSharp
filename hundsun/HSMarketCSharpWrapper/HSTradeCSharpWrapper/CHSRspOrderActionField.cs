//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Trade {

public class CHSRspOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertTime {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_InsertTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspOrderActionField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspOrderActionField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspOrderActionField(), true) {
  }

}

}
