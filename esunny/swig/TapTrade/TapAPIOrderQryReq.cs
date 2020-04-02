//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIOrderQryReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderQryReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderQryReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderQryReq() {
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
          TapTradeCppWrapperPINVOKE.delete_TapAPIOrderQryReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public char IsBackInput {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_IsBackInput_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_IsBackInput_get(swigCPtr);
      return ret;
    } 
  }

  public char IsDeleted {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_IsDeleted_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_IsDeleted_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeCppWrapperPINVOKE.TapAPIOrderQryReq_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderQryReq() : this(TapTradeCppWrapperPINVOKE.new_TapAPIOrderQryReq(), true) {
  }

}