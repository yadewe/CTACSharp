//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Market {

public class CThostFtdcExecOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExecOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExecOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExecOrderField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcExecOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderRef {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExecOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExecOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ActionType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ActionType_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char ReservePositionFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ReservePositionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ReservePositionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char CloseFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_CloseFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_CloseFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderLocalID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExecOrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExecOrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderSysID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExecOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExecOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public char ExecResult {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExecResult_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ExecResult_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveUserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ActiveUserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_ActiveUserID_get(swigCPtr);
      return ret;
    } 
  }

  public int BrokerExecOrderSeq {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_BrokerExecOrderSeq_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExecOrderField_BrokerExecOrderSeq_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExecOrderField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcExecOrderField(), true) {
  }

}

}
