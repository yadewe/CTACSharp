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

public class CThostFtdcTradingAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTradingAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTradingAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTradingAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcTradingAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMortgage {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreMortgage_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreMortgage_get(swigCPtr);
      return ret;
    } 
  }

  public double PreCredit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreCredit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreCredit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreDeposit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreDeposit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreDeposit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreBalance {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreBalance_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double InterestBase {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_InterestBase_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_InterestBase_get(swigCPtr);
      return ret;
    } 
  }

  public double Interest {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Interest_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Interest_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public double Withdraw {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Withdraw_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Withdraw_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_CurrMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_CurrMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double Balance {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Balance_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Balance_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Available_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double WithdrawQuota {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_WithdrawQuota_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_WithdrawQuota_get(swigCPtr);
      return ret;
    } 
  }

  public double Reserve {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Reserve_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Reserve_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double Credit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Credit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Credit_get(swigCPtr);
      return ret;
    } 
  }

  public double Mortgage {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Mortgage_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_Mortgage_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_ExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_ExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_DeliveryMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_DeliveryMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeDeliveryMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_ExchangeDeliveryMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_ExchangeDeliveryMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ReserveBalance {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_ReserveBalance_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_ReserveBalance_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double PreFundMortgageIn {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreFundMortgageIn_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreFundMortgageIn_get(swigCPtr);
      return ret;
    } 
  }

  public double PreFundMortgageOut {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreFundMortgageOut_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_PreFundMortgageOut_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageIn {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FundMortgageIn_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FundMortgageIn_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageOut {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FundMortgageOut_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FundMortgageOut_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageAvailable {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FundMortgageAvailable_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_FundMortgageAvailable_get(swigCPtr);
      return ret;
    } 
  }

  public double MortgageableFund {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_MortgageableFund_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_MortgageableFund_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductFrozenMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductCommission {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductCommission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductFrozenCommission {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductFrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductFrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductPositionProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductCloseProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductCloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductPositionProfitByAlg {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductPositionProfitByAlg_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductPositionProfitByAlg_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductExchangeMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradingAccountField_SpecProductExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTradingAccountField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcTradingAccountField(), true) {
  }

}

}
