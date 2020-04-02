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

public class CThostFtdcChangeAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcChangeAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcChangeAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcChangeAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcChangeAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char Gender {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Gender_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Gender_get(swigCPtr);
      return ret;
    } 
  }

  public string CountryCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_CountryCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_CountryCode_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string MobilePhone {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_MobilePhone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_MobilePhone_get(swigCPtr);
      return ret;
    } 
  }

  public string Fax {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Fax_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Fax_get(swigCPtr);
      return ret;
    } 
  }

  public string EMail {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_EMail_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_EMail_get(swigCPtr);
      return ret;
    } 
  }

  public char MoneyAccountStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_MoneyAccountStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_MoneyAccountStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string NewBankAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_NewBankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_NewBankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string NewBankPassWord {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_NewBankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_NewBankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcChangeAccountField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcChangeAccountField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcChangeAccountField(), true) {
  }

}

}