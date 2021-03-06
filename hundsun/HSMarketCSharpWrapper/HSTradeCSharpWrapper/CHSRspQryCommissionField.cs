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

public class CHSRspQryCommissionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQryCommissionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQryCommissionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQryCommissionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspQryCommissionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public char ProductType {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ProductType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ProductType_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public double LongOpenCommissionRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongOpenCommissionRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongOpenCommissionRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double LongOpenCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongOpenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongOpenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double LongCloseCommissionRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongCloseCommissionRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongCloseCommissionRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double LongCloseCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongCloseCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongCloseCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double LongCloseTodayCommissionRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongCloseTodayCommissionRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongCloseTodayCommissionRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double LongCloseTodayCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongCloseTodayCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_LongCloseTodayCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortOpenCommissionRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortOpenCommissionRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortOpenCommissionRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortOpenCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortOpenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortOpenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortCloseCommissionRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortCloseCommissionRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortCloseCommissionRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortCloseCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortCloseCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortCloseCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortCloseTodayCommissionRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortCloseTodayCommissionRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortCloseTodayCommissionRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortCloseTodayCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortCloseTodayCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ShortCloseTodayCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double ExerciseCommissionRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ExerciseCommissionRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ExerciseCommissionRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double ExerciseCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ExerciseCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_ExerciseCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeValueRatio {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_TradeValueRatio_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_TradeValueRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double StockValue {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_StockValue_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryCommissionField_StockValue_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQryCommissionField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspQryCommissionField(), true) {
  }

}

}
