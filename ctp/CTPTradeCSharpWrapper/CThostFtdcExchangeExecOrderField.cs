//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Trade {

public class CThostFtdcExchangeExecOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeExecOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeExecOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeExecOrderField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcExchangeExecOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int Volume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ActionType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ActionType_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char ReservePositionFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ReservePositionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ReservePositionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char CloseFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_CloseFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_CloseFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderLocalID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExecOrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExecOrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExecOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExecOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public char ExecResult {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExecResult_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ExecResult_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeExecOrderField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcExchangeExecOrderField(), true) {
  }

}

}
