//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIOrderMarketInsertReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderMarketInsertReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderMarketInsertReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderMarketInsertReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIOrderMarketInsertReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char BuyPositionEffect {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_BuyPositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_BuyPositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char SellPositionEffect {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_SellPositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_SellPositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char AddOneIsValid {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_AddOneIsValid_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_AddOneIsValid_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderBuyPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderBuyPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderBuyPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderSellPrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderSellPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderSellPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderBuyQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderBuyQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderBuyQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderSellQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderSellQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_OrderSellQty_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientBuyOrderNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ClientBuyOrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ClientBuyOrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientSellOrderNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ClientSellOrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_ClientSellOrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RefInt {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_RefInt_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_RefInt_get(swigCPtr);
      return ret;
    } 
  }

  public double RefDouble {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_RefDouble_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_RefDouble_get(swigCPtr);
      return ret;
    } 
  }

  public string RefString {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_RefString_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_RefString_get(swigCPtr);
      return ret;
    } 
  }

  public string Remark {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_Remark_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderMarketInsertReq_Remark_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderMarketInsertReq() : this(TapTradeCppWrapperPINVOKE.new_TapAPIOrderMarketInsertReq(), true) {
  }

}
