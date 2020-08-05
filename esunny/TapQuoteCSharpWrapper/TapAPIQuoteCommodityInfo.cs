//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPIQuoteCommodityInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIQuoteCommodityInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuoteCommodityInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIQuoteCommodityInfo() {
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
          TapQuoteCppWrapperPINVOKE.delete_TapAPIQuoteCommodityInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TapAPICommodity Commodity {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_Commodity_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_Commodity_get(swigCPtr);
      TapAPICommodity ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public string CommodityName {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityName_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityEngName {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityEngName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityEngName_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public double CommodityTickSize {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityTickSize_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityTickSize_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityDenominator {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityDenominator_set(swigCPtr, value);
    } 
    get {
      int ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityDenominator_get(swigCPtr);
      return ret;
    } 
  }

  public char CmbDirect {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CmbDirect_set(swigCPtr, value);
    } 
    get {
      char ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CmbDirect_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityContractLen {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityContractLen_set(swigCPtr, value);
    } 
    get {
      int ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_CommodityContractLen_get(swigCPtr);
      return ret;
    } 
  }

  public char IsDST {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_IsDST_set(swigCPtr, value);
    } 
    get {
      char ret = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_IsDST_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPICommodity RelateCommodity1 {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_RelateCommodity1_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_RelateCommodity1_get(swigCPtr);
      TapAPICommodity ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public TapAPICommodity RelateCommodity2 {
    set {
      TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_RelateCommodity2_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuoteCppWrapperPINVOKE.TapAPIQuoteCommodityInfo_RelateCommodity2_get(swigCPtr);
      TapAPICommodity ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public TapAPIQuoteCommodityInfo() : this(TapQuoteCppWrapperPINVOKE.new_TapAPIQuoteCommodityInfo(), true) {
  }

}
