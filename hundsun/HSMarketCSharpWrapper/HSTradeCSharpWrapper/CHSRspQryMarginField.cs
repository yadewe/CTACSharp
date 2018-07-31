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

public class CHSRspQryMarginField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQryMarginField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQryMarginField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQryMarginField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspQryMarginField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_LongMarginRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_LongMarginRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMargin {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_LongMargin_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_LongMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_ShortMarginRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_ShortMarginRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMargin {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_ShortMargin_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryMarginField_ShortMargin_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQryMarginField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspQryMarginField(), true) {
  }

}

}
