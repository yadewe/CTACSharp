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

public class CHSReqLockInsertField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSReqLockInsertField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSReqLockInsertField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSReqLockInsertField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSReqLockInsertField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqLockInsertField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqLockInsertField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqLockInsertField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqLockInsertField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public char LockType {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqLockInsertField_LockType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSReqLockInsertField_LockType_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqLockInsertField_OrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSReqLockInsertField_OrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public CHSReqLockInsertField() : this(HSTradeCppWrapperPINVOKE.new_CHSReqLockInsertField(), true) {
  }

}

}
