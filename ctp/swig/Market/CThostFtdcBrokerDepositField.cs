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

public class CThostFtdcBrokerDepositField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerDepositField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerDepositField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerDepositField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcBrokerDepositField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public double PreBalance {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_PreBalance_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_PreBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_CurrMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_CurrMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double Balance {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Balance_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Balance_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public double Withdraw {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Withdraw_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Withdraw_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Available_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double Reserve {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Reserve_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_Reserve_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerDepositField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerDepositField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcBrokerDepositField(), true) {
  }

}

}
