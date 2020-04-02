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

public class CHSOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSOrderField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerOrderID {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_BrokerOrderID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_BrokerOrderID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSOrderField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSOrderField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSOrderField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSOrderField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSOrderField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_OrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSOrderField_OrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSOrderField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_TradeVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSOrderField_TradeVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CancelVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_CancelVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSOrderField_CancelVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double TradePrice {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_TradePrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSOrderField_TradePrice_get(swigCPtr);
      return ret;
    } 
  }

  public int TradingDay {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_TradingDay_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSOrderField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_InsertDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSOrderField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertTime {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_InsertTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSOrderField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public int ReportTime {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_ReportTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSOrderField_ReportTime_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommand {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_OrderCommand_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_OrderCommand_get(swigCPtr);
      return ret;
    } 
  }

  public double MinVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_MinVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSOrderField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double SpringPrice {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_SpringPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSOrderField_SpringPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char SwapOrderFlag {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_SwapOrderFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSOrderField_SwapOrderFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ForceCloseReason {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_ForceCloseReason_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_ForceCloseReason_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSOrderField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      HSTradeCppWrapperPINVOKE.CHSOrderField_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSOrderField_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public CHSOrderField() : this(HSTradeCppWrapperPINVOKE.new_CHSOrderField(), true) {
  }

}

}