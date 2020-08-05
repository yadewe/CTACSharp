namespace TapQuoteCSharpWrapper
{
     //------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIQuoteWhole : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIQuoteWhole(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuoteWhole obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIQuoteWhole() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapQuoteCppWrapperPINVOKE.delete_TapAPIQuoteWhole(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TapAPIContract Contract {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_Contract_set(swigCPtr, TapAPIContract.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_Contract_get(swigCPtr);
      TapAPIContract ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIContract(cPtr, false);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public char TradingState {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_TradingState_set(swigCPtr, value);
    } 
    get {
      char ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_TradingState_get(swigCPtr);
      return ret;
    } 
  }

  public string DateTimeStamp {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_DateTimeStamp_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_DateTimeStamp_get(swigCPtr);
      return ret;
    } 
  }

  public double QPreClosingPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPreClosingPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPreClosingPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QPreSettlePrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPreSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPreSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QPrePositionQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPrePositionQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPrePositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public double QOpeningPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QOpeningPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QOpeningPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QLastPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLastPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLastPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QHighPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QHighPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QHighPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QLowPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLowPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLowPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QHisHighPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QHisHighPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QHisHighPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QHisLowPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QHisLowPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QHisLowPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QLimitUpPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLimitUpPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLimitUpPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QLimitDownPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLimitDownPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLimitDownPrice_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QTotalQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalQty_get(swigCPtr);
      return ret;
    } 
  }

  public double QTotalTurnover {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalTurnover_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalTurnover_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QPositionQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPositionQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public double QAveragePrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QAveragePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QAveragePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QClosingPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QClosingPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QClosingPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QSettlePrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QLastQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLastQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QLastQty_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double QBidPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QBidPrice_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QBidPrice_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_long_long QBidQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QBidQty_set(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QBidQty_get(swigCPtr);
      SWIGTYPE_p_unsigned_long_long ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_long_long(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_double QAskPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QAskPrice_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QAskPrice_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_long_long QAskQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QAskQty_set(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QAskQty_get(swigCPtr);
      SWIGTYPE_p_unsigned_long_long ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_long_long(cPtr, false);
      return ret;
    } 
  }

  public double QImpliedBidPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QImpliedBidPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QImpliedBidPrice_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QImpliedBidQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QImpliedBidQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QImpliedBidQty_get(swigCPtr);
      return ret;
    } 
  }

  public double QImpliedAskPrice {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QImpliedAskPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QImpliedAskPrice_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QImpliedAskQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QImpliedAskQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QImpliedAskQty_get(swigCPtr);
      return ret;
    } 
  }

  public double QPreDelta {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPreDelta_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPreDelta_get(swigCPtr);
      return ret;
    } 
  }

  public double QCurrDelta {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QCurrDelta_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QCurrDelta_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QInsideQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QInsideQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QInsideQty_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QOutsideQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QOutsideQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QOutsideQty_get(swigCPtr);
      return ret;
    } 
  }

  public double QTurnoverRate {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTurnoverRate_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTurnoverRate_get(swigCPtr);
      return ret;
    } 
  }

  public ulong Q5DAvgQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_Q5DAvgQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_Q5DAvgQty_get(swigCPtr);
      return ret;
    } 
  }

  public double QPERatio {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPERatio_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPERatio_get(swigCPtr);
      return ret;
    } 
  }

  public double QTotalValue {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalValue_get(swigCPtr);
      return ret;
    } 
  }

  public double QNegotiableValue {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QNegotiableValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QNegotiableValue_get(swigCPtr);
      return ret;
    } 
  }

  public long QPositionTrend {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPositionTrend_set(swigCPtr, value);
    } 
    get {
      long ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QPositionTrend_get(swigCPtr);
      return ret;
    } 
  }

  public double QChangeSpeed {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QChangeSpeed_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QChangeSpeed_get(swigCPtr);
      return ret;
    } 
  }

  public double QChangeRate {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QChangeRate_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QChangeRate_get(swigCPtr);
      return ret;
    } 
  }

  public double QChangeValue {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QChangeValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QChangeValue_get(swigCPtr);
      return ret;
    } 
  }

  public double QSwing {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QSwing_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QSwing_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QTotalBidQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalBidQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalBidQty_get(swigCPtr);
      return ret;
    } 
  }

  public ulong QTotalAskQty {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalAskQty_set(swigCPtr, value);
    } 
    get {
      ulong ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_QTotalAskQty_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIContract UnderlyContract {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_UnderlyContract_set(swigCPtr, TapAPIContract.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteWhole_UnderlyContract_get(swigCPtr);
      TapAPIContract ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIContract(cPtr, false);
      return ret;
    } 
  }

  public TapAPIQuoteWhole() : this(TapQuoteCppWrapperPINVOKE.new_TapAPIQuoteWhole(), true) {
  }

}

}