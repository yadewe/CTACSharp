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

public class CHSReqOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSReqOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSReqOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSReqOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSReqOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string OrderSysID {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqOrderActionField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqOrderActionField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqOrderActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSReqOrderActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqOrderActionField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqOrderActionField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public CHSReqOrderActionField() : this(HSTradeCppWrapperPINVOKE.new_CHSReqOrderActionField(), true) {
  }

}

}