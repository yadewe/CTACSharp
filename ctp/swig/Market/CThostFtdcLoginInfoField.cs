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

public class CThostFtdcLoginInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcLoginInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcLoginInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcLoginInfoField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcLoginInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int FrontID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginDate {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_LoginDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_LoginDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginTime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_LoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_LoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string InterfaceProductInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_InterfaceProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_InterfaceProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string ProtocolInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_ProtocolInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_ProtocolInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string SystemName {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_SystemName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_SystemName_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxOrderRef {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_MaxOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_MaxOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string SHFETime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_SHFETime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_SHFETime_get(swigCPtr);
      return ret;
    } 
  }

  public string DCETime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_DCETime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_DCETime_get(swigCPtr);
      return ret;
    } 
  }

  public string CZCETime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_CZCETime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_CZCETime_get(swigCPtr);
      return ret;
    } 
  }

  public string FFEXTime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_FFEXTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_FFEXTime_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string OneTimePassword {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_OneTimePassword_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_OneTimePassword_get(swigCPtr);
      return ret;
    } 
  }

  public string INETime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_INETime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcLoginInfoField_INETime_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcLoginInfoField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcLoginInfoField(), true) {
  }

}

}