//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Market {

public class CHSExerciseField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSExerciseField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSExerciseField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSExerciseField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSExerciseField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExerciseOrderSysID {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_ExerciseOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_ExerciseOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExerciseRef {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_ExerciseRef_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_ExerciseRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public char ExerciseType {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_ExerciseType_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_ExerciseType_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_OrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_OrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertDate {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_InsertDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertTime {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_InsertTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      HSMarketCppWrapperPINVOKE.CHSExerciseField_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSExerciseField_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public CHSExerciseField() : this(HSMarketCppWrapperPINVOKE.new_CHSExerciseField(), true) {
  }

}

}
