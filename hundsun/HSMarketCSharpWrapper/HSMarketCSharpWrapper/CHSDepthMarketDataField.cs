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

public class CHSDepthMarketDataField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSDepthMarketDataField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSDepthMarketDataField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSDepthMarketDataField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSDepthMarketDataField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int TradingDay {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_TradingDay_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public double LastPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_LastPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_LastPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreClosePrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_PreClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_PreClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_OpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_OpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double HighestPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_HighestPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_HighestPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double LowestPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_LowestPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_LowestPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_TradeVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_TradeVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeBalance {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_TradeBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_TradeBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenInterest {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_OpenInterest_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_OpenInterest_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_ClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_ClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperLimitPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_UpperLimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_UpperLimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double LowerLimitPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_LowerLimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_LowerLimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreDelta {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_PreDelta_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_PreDelta_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrDelta {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_CurrDelta_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_CurrDelta_get(swigCPtr);
      return ret;
    } 
  }

  public int UpdateTime {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_UpdateTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_UpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice1 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice1_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice1_get(swigCPtr);
      return ret;
    } 
  }

  public double BidVolume1 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume1_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume1_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice1 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice1_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice1_get(swigCPtr);
      return ret;
    } 
  }

  public double AskVolume1 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume1_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume1_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice2 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public double BidVolume2 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume2_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume2_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice2 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public double AskVolume2 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume2_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume2_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice3 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice3_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice3_get(swigCPtr);
      return ret;
    } 
  }

  public double BidVolume3 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume3_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume3_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice3 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice3_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice3_get(swigCPtr);
      return ret;
    } 
  }

  public double AskVolume3 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume3_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume3_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice4 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice4_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice4_get(swigCPtr);
      return ret;
    } 
  }

  public double BidVolume4 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume4_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume4_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice4 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice4_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice4_get(swigCPtr);
      return ret;
    } 
  }

  public double AskVolume4 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume4_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume4_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice5 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice5_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidPrice5_get(swigCPtr);
      return ret;
    } 
  }

  public double BidVolume5 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume5_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_BidVolume5_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice5 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice5_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskPrice5_get(swigCPtr);
      return ret;
    } 
  }

  public double AskVolume5 {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume5_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AskVolume5_get(swigCPtr);
      return ret;
    } 
  }

  public double AveragePrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AveragePrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_AveragePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreOpenInterest {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_PreOpenInterest_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_PreOpenInterest_get(swigCPtr);
      return ret;
    } 
  }

  public char InstrumentTradeStatus {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_InstrumentTradeStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_InstrumentTradeStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenRestriction {
    set {
      HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_OpenRestriction_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSDepthMarketDataField_OpenRestriction_get(swigCPtr);
      return ret;
    } 
  }

  public CHSDepthMarketDataField() : this(HSMarketCppWrapperPINVOKE.new_CHSDepthMarketDataField(), true) {
  }

}

}
