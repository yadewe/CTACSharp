//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTransferQryBankRspField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferQryBankRspField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferQryBankRspField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTransferQryBankRspField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcTransferQryBankRspField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string RetCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_RetCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_RetCode_get(swigCPtr);
      return ret;
    } 
  }

  public string RetInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_RetInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_RetInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureAccount {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_FutureAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_FutureAccount_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmt {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_TradeAmt_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_TradeAmt_get(swigCPtr);
      return ret;
    } 
  }

  public double UseAmt {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_UseAmt_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_UseAmt_get(swigCPtr);
      return ret;
    } 
  }

  public double FetchAmt {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_FetchAmt_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_FetchAmt_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_CurrencyCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankRspField_CurrencyCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferQryBankRspField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcTransferQryBankRspField(), true) {
  }

}