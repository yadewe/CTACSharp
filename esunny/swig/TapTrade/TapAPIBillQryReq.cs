//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIBillQryReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIBillQryReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIBillQryReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIBillQryReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIBillQryReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UserNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIBillQryReq_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIBillQryReq_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public char BillType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIBillQryReq_BillType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIBillQryReq_BillType_get(swigCPtr);
      return ret;
    } 
  }

  public string BillDate {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIBillQryReq_BillDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIBillQryReq_BillDate_get(swigCPtr);
      return ret;
    } 
  }

  public char BillFileType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIBillQryReq_BillFileType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIBillQryReq_BillFileType_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIBillQryReq() : this(TapTradeCppWrapperPINVOKE.new_TapAPIBillQryReq(), true) {
  }

}
