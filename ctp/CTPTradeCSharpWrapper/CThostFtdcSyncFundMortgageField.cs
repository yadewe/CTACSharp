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

public class CThostFtdcSyncFundMortgageField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncFundMortgageField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncFundMortgageField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncFundMortgageField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcSyncFundMortgageField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string MortgageSeqNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_MortgageSeqNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_MortgageSeqNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string FromCurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_FromCurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_FromCurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double MortgageAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_MortgageAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_MortgageAmount_get(swigCPtr);
      return ret;
    } 
  }

  public string ToCurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_ToCurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncFundMortgageField_ToCurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncFundMortgageField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcSyncFundMortgageField(), true) {
  }

}

}
