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

public class CHSReqQueryMaxOrderVolumeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSReqQueryMaxOrderVolumeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSReqQueryMaxOrderVolumeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSReqQueryMaxOrderVolumeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSReqQueryMaxOrderVolumeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommand {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OrderCommand_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OrderCommand_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public CHSReqQueryMaxOrderVolumeField() : this(HSTradeCppWrapperPINVOKE.new_CHSReqQueryMaxOrderVolumeField(), true) {
  }

}

}
