//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Market {

public class CHSRspQueryBankAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQueryBankAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQueryBankAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQueryBankAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSRspQueryBankAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BankID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQueryBankAccountField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQueryBankAccountField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankName {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQueryBankAccountField_BankName_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQueryBankAccountField_BankName_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccountID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQueryBankAccountField_BankAccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQueryBankAccountField_BankAccountID_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQueryBankAccountField() : this(HSMarketCppWrapperPINVOKE.new_CHSRspQueryBankAccountField(), true) {
  }

}

}