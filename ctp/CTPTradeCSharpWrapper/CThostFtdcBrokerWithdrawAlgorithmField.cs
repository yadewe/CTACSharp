//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcBrokerWithdrawAlgorithmField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerWithdrawAlgorithmField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerWithdrawAlgorithmField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerWithdrawAlgorithmField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcBrokerWithdrawAlgorithmField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public char WithdrawAlgorithm {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_WithdrawAlgorithm_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_WithdrawAlgorithm_get(swigCPtr);
      return ret;
    } 
  }

  public double UsingRatio {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_UsingRatio_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_UsingRatio_get(swigCPtr);
      return ret;
    } 
  }

  public char IncludeCloseProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_IncludeCloseProfit_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_IncludeCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public char AllWithoutTrade {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_AllWithoutTrade_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_AllWithoutTrade_get(swigCPtr);
      return ret;
    } 
  }

  public char AvailIncludeCloseProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_AvailIncludeCloseProfit_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_AvailIncludeCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public int IsBrokerUserEvent {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_IsBrokerUserEvent_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_IsBrokerUserEvent_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageRatio {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_FundMortgageRatio_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_FundMortgageRatio_get(swigCPtr);
      return ret;
    } 
  }

  public char BalanceAlgorithm {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_BalanceAlgorithm_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_BalanceAlgorithm_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerWithdrawAlgorithmField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcBrokerWithdrawAlgorithmField(), true) {
  }

}