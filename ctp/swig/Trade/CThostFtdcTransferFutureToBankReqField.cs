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

public class CThostFtdcTransferFutureToBankReqField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferFutureToBankReqField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferFutureToBankReqField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTransferFutureToBankReqField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcTransferFutureToBankReqField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string FutureAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FutureAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FutureAccount_get(swigCPtr);
      return ret;
    } 
  }

  public char FuturePwdFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FuturePwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FuturePwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureAccPwd {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FutureAccPwd_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FutureAccPwd_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmt {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_TradeAmt_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_TradeAmt_get(swigCPtr);
      return ret;
    } 
  }

  public double CustFee {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_CustFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_CustFee_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_CurrencyCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_CurrencyCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferFutureToBankReqField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcTransferFutureToBankReqField(), true) {
  }

}

}
