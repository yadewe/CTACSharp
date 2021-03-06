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
          HSMarketCppWrapperPINVOKE.delete_CHSRspQryInstrumentField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentName {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentName_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentName_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentEngName {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentEngName_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_InstrumentEngName_get(swigCPtr);
      return ret;
    } 
  }

  public string ProductID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ProductID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ProductID_get(swigCPtr);
      return ret;
    } 
  }

  public char ProductType {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ProductType_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ProductType_get(swigCPtr);
      return ret;
    } 
  }

  public double MaxMarketOrderVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarketOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarketOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double MinMarketOrderVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MinMarketOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MinMarketOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double MaxLimitOrderVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxLimitOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxLimitOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double MinLimitOrderVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MinLimitOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MinLimitOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double VolumeMultiple {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_VolumeMultiple_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_VolumeMultiple_get(swigCPtr);
      return ret;
    } 
  }

  public double PriceTick {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_PriceTick_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_PriceTick_get(swigCPtr);
      return ret;
    } 
  }

  public char MaxMarginSideAlgorithm {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarginSideAlgorithm_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarginSideAlgorithm_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxMarginSideProductID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarginSideProductID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MaxMarginSideProductID_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public double ExercisePrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ExercisePrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ExercisePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char OptionsType {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_OptionsType_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_OptionsType_get(swigCPtr);
      return ret;
    } 
  }

  public char TradingFlag {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_TradingFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_TradingFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int MarketDate {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MarketDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_MarketDate_get(swigCPtr);
      return ret;
    } 
  }

  public int ExpireDate {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ExpireDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_ExpireDate_get(swigCPtr);
      return ret;
    } 
  }

  public int BeginExerciseDate {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_BeginExerciseDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_BeginExerciseDate_get(swigCPtr);
      return ret;
    } 
  }

  public int EndExerciseDate {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_EndExerciseDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_EndExerciseDate_get(swigCPtr);
      return ret;
    } 
  }

  public int BeginDeliveryDate {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_BeginDeliveryDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_BeginDeliveryDate_get(swigCPtr);
      return ret;
    } 
  }

  public int EndDeliveryDate {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_EndDeliveryDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspQryInstrumentField_EndDeliveryDate_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQryInstrumentField() : this(HSMarketCppWrapperPINVOKE.new_CHSRspQryInstrumentField(), true) {
  }

}

}
