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

public class CThostFtdcMarketDataBid23Field : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataBid23Field(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataBid23Field obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataBid23Field() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcMarketDataBid23Field(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double BidPrice2 {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataBid23Field_BidPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataBid23Field_BidPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume2 {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataBid23Field_BidVolume2_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataBid23Field_BidVolume2_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice3 {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataBid23Field_BidPrice3_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataBid23Field_BidPrice3_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume3 {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataBid23Field_BidVolume3_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataBid23Field_BidVolume3_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataBid23Field() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcMarketDataBid23Field(), true) {
  }

}

}