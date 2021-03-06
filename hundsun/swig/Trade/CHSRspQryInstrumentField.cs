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

public class CHSRspQryInstrumentField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQryInstrumentField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQryInstrumentField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQryInstrumentField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspQryInstrumentField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentName {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentName_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentName_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentEngName {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentEngName_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentEngName_get(swigCPtr);
      return ret;
    } 
  }

  public string ProductID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ProductID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ProductID_get(swigCPtr);
      return ret;
    } 
  }

  public char ProductType {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ProductType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ProductType_get(swigCPtr);
      return ret;
    } 
  }

  public double MaxMarketOrderVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarketOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarketOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double MinMarketOrderVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MinMarketOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MinMarketOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double MaxLimitOrderVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxLimitOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxLimitOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double MinLimitOrderVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MinLimitOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MinLimitOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double VolumeMultiple {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_VolumeMultiple_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_VolumeMultiple_get(swigCPtr);
      return ret;
    } 
  }

  public double PriceTick {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_PriceTick_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_PriceTick_get(swigCPtr);
      return ret;
    } 
  }

  public char MaxMarginSideAlgorithm {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarginSideAlgorithm_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarginSideAlgorithm_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxMarginSideProductID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarginSideProductID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarginSideProductID_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public double ExercisePrice {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ExercisePrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ExercisePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char OptionsType {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_OptionsType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_OptionsType_get(swigCPtr);
      return ret;
    } 
  }

  public char TradingFlag {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_TradingFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_TradingFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int MarketDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MarketDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_MarketDate_get(swigCPtr);
      return ret;
    } 
  }

  public int ExpireDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ExpireDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_ExpireDate_get(swigCPtr);
      return ret;
    } 
  }

  public int BeginExerciseDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_BeginExerciseDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_BeginExerciseDate_get(swigCPtr);
      return ret;
    } 
  }

  public int EndExerciseDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_EndExerciseDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_EndExerciseDate_get(swigCPtr);
      return ret;
    } 
  }

  public int BeginDeliveryDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_BeginDeliveryDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_BeginDeliveryDate_get(swigCPtr);
      return ret;
    } 
  }

  public int EndDeliveryDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_EndDeliveryDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryInstrumentField_EndDeliveryDate_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQryInstrumentField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspQryInstrumentField(), true) {
  }

}

}
