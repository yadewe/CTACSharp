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

public class CHSRspQryPositionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQryPositionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQryPositionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQryPositionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspQryPositionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public double YdPositionVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_YdPositionVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_YdPositionVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double TodayPositionVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_TodayPositionVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_TodayPositionVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double AvailablePositionVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_AvailablePositionVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_AvailablePositionVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double TodayAvailablePositionVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_TodayAvailablePositionVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_TodayAvailablePositionVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionMargin {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionMargin_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double Premium {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_Premium_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_Premium_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_FrozenVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_FrozenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CombVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CombVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CombVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CombFrozenVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CombFrozenVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CombFrozenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ExerciseFrozenVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_ExerciseFrozenVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_ExerciseFrozenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenPremium {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_FrozenPremium_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_FrozenPremium_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_OpenVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CloseVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CloseVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenBalance {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_OpenBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_OpenBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseBalance {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CloseBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CloseBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionAveragePrice {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionAveragePrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionAveragePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCost {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionCost_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionCost_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionAveragePriceByDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionAveragePriceByDate_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionAveragePriceByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfitByDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_PositionProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionsMarketValue {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_OptionsMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_OptionsMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQryPositionField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspQryPositionField(), true) {
  }

}

}