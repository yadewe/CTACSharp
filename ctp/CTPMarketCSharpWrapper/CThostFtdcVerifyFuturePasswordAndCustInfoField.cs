//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcVerifyFuturePasswordAndCustInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcVerifyFuturePasswordAndCustInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcVerifyFuturePasswordAndCustInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcVerifyFuturePasswordAndCustInfoField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcVerifyFuturePasswordAndCustInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string CustomerName {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyFuturePasswordAndCustInfoField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcVerifyFuturePasswordAndCustInfoField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcVerifyFuturePasswordAndCustInfoField(), true) {
  }

}