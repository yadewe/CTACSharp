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

public class CThostFtdcReqOpenAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqOpenAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqOpenAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqOpenAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcReqOpenAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char Gender {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Gender_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Gender_get(swigCPtr);
      return ret;
    } 
  }

  public string CountryCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CountryCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CountryCode_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string MobilePhone {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_MobilePhone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_MobilePhone_get(swigCPtr);
      return ret;
    } 
  }

  public string Fax {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Fax_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Fax_get(swigCPtr);
      return ret;
    } 
  }

  public string EMail {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_EMail_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_EMail_get(swigCPtr);
      return ret;
    } 
  }

  public char MoneyAccountStatus {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_MoneyAccountStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_MoneyAccountStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public char CashExchangeCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CashExchangeCode_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_CashExchangeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public char BankSecuAccType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankSecuAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankSecuAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSecuAcc {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankSecuAcc_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankSecuAcc_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqOpenAccountField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqOpenAccountField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcReqOpenAccountField(), true) {
  }

}

}
