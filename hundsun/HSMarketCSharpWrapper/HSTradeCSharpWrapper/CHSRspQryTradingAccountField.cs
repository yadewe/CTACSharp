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

public class CHSRspQryTradingAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQryTradingAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQryTradingAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQryTradingAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspQryTradingAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public double YdBalance {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_YdBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_YdBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double YdPositionMargin {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_YdPositionMargin_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_YdPositionMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double YdFundEquity {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_YdFundEquity_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_YdFundEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double FundEquity {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FundEquity_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FundEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionsMarketValue {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_OptionsMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_OptionsMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public double Equity {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Equity_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Equity_get(swigCPtr);
      return ret;
    } 
  }

  public double AvailableBalance {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_AvailableBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_AvailableBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double WithdrawBalance {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_WithdrawBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_WithdrawBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double Margin {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Margin_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Margin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double RiskDegree {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_RiskDegree_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_RiskDegree_get(swigCPtr);
      return ret;
    } 
  }

  public double Premium {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Premium_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Premium_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenPremium {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FrozenPremium_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FrozenPremium_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfitByDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_PositionProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_PositionProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public double Withdraw {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Withdraw_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_Withdraw_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgage {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FundMortgage_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FundMortgage_get(swigCPtr);
      return ret;
    } 
  }

  public double WarrantMortgage {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_WarrantMortgage_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_WarrantMortgage_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenBalance {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FrozenBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_FrozenBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double UnFrozenBalance {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_UnFrozenBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTradingAccountField_UnFrozenBalance_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQryTradingAccountField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspQryTradingAccountField(), true) {
  }

}

}
