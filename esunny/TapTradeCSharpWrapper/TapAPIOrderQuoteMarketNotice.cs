//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIOrderQuoteMarketNotice : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderQuoteMarketNotice(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderQuoteMarketNotice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderQuoteMarketNotice() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPIOrderQuoteMarketNotice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSide {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_OrderSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_OrderSide_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_OrderQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderQuoteMarketNotice() : this(TapTradeCppWrapperPINVOKE.new_TapAPIOrderQuoteMarketNotice(), true) {
  }

}