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

public class CHSMdSpi : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSMdSpi(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSMdSpi obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSMdSpi() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSMdSpi(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void OnFrontConnected() {
    if (SwigDerivedClassHasMethod("OnFrontConnected", swigMethodTypes0)) HSMarketCppWrapperPINVOKE.CHSMdSpi_OnFrontConnectedSwigExplicitCHSMdSpi(swigCPtr); else HSMarketCppWrapperPINVOKE.CHSMdSpi_OnFrontConnected(swigCPtr);
  }

  public virtual void OnFrontDisconnected(int nResult) {
    if (SwigDerivedClassHasMethod("OnFrontDisconnected", swigMethodTypes1)) HSMarketCppWrapperPINVOKE.CHSMdSpi_OnFrontDisconnectedSwigExplicitCHSMdSpi(swigCPtr, nResult); else HSMarketCppWrapperPINVOKE.CHSMdSpi_OnFrontDisconnected(swigCPtr, nResult);
  }

  public virtual void OnRspDepthMarketDataSubscribe(CHSRspInfoField pRspInfo, int nRequestID, bool bIsLast) {
    if (SwigDerivedClassHasMethod("OnRspDepthMarketDataSubscribe", swigMethodTypes2)) HSMarketCppWrapperPINVOKE.CHSMdSpi_OnRspDepthMarketDataSubscribeSwigExplicitCHSMdSpi(swigCPtr, CHSRspInfoField.getCPtr(pRspInfo), nRequestID, bIsLast); else HSMarketCppWrapperPINVOKE.CHSMdSpi_OnRspDepthMarketDataSubscribe(swigCPtr, CHSRspInfoField.getCPtr(pRspInfo), nRequestID, bIsLast);
  }

  public virtual void OnRspDepthMarketDataCancel(CHSRspInfoField pRspInfo, int nRequestID, bool bIsLast) {
    if (SwigDerivedClassHasMethod("OnRspDepthMarketDataCancel", swigMethodTypes3)) HSMarketCppWrapperPINVOKE.CHSMdSpi_OnRspDepthMarketDataCancelSwigExplicitCHSMdSpi(swigCPtr, CHSRspInfoField.getCPtr(pRspInfo), nRequestID, bIsLast); else HSMarketCppWrapperPINVOKE.CHSMdSpi_OnRspDepthMarketDataCancel(swigCPtr, CHSRspInfoField.getCPtr(pRspInfo), nRequestID, bIsLast);
  }

  public virtual void OnRtnDepthMarketData(CHSDepthMarketDataField pDepthMarketData) {
    if (SwigDerivedClassHasMethod("OnRtnDepthMarketData", swigMethodTypes4)) HSMarketCppWrapperPINVOKE.CHSMdSpi_OnRtnDepthMarketDataSwigExplicitCHSMdSpi(swigCPtr, CHSDepthMarketDataField.getCPtr(pDepthMarketData)); else HSMarketCppWrapperPINVOKE.CHSMdSpi_OnRtnDepthMarketData(swigCPtr, CHSDepthMarketDataField.getCPtr(pDepthMarketData));
  }

  public CHSMdSpi() : this(HSMarketCppWrapperPINVOKE.new_CHSMdSpi(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnFrontConnected", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateCHSMdSpi_0(SwigDirectorOnFrontConnected);
    if (SwigDerivedClassHasMethod("OnFrontDisconnected", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateCHSMdSpi_1(SwigDirectorOnFrontDisconnected);
    if (SwigDerivedClassHasMethod("OnRspDepthMarketDataSubscribe", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateCHSMdSpi_2(SwigDirectorOnRspDepthMarketDataSubscribe);
    if (SwigDerivedClassHasMethod("OnRspDepthMarketDataCancel", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateCHSMdSpi_3(SwigDirectorOnRspDepthMarketDataCancel);
    if (SwigDerivedClassHasMethod("OnRtnDepthMarketData", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateCHSMdSpi_4(SwigDirectorOnRtnDepthMarketData);
    HSMarketCppWrapperPINVOKE.CHSMdSpi_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(CHSMdSpi));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnFrontConnected() {
    OnFrontConnected();
  }

  private void SwigDirectorOnFrontDisconnected(int nResult) {
    OnFrontDisconnected(nResult);
  }

  private void SwigDirectorOnRspDepthMarketDataSubscribe(global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast) {
    OnRspDepthMarketDataSubscribe((pRspInfo == global::System.IntPtr.Zero) ? null : new CHSRspInfoField(pRspInfo, false), nRequestID, bIsLast);
  }

  private void SwigDirectorOnRspDepthMarketDataCancel(global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast) {
    OnRspDepthMarketDataCancel((pRspInfo == global::System.IntPtr.Zero) ? null : new CHSRspInfoField(pRspInfo, false), nRequestID, bIsLast);
  }

  private void SwigDirectorOnRtnDepthMarketData(global::System.IntPtr pDepthMarketData) {
    OnRtnDepthMarketData((pDepthMarketData == global::System.IntPtr.Zero) ? null : new CHSDepthMarketDataField(pDepthMarketData, false));
  }

  public delegate void SwigDelegateCHSMdSpi_0();
  public delegate void SwigDelegateCHSMdSpi_1(int nResult);
  public delegate void SwigDelegateCHSMdSpi_2(global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast);
  public delegate void SwigDelegateCHSMdSpi_3(global::System.IntPtr pRspInfo, int nRequestID, bool bIsLast);
  public delegate void SwigDelegateCHSMdSpi_4(global::System.IntPtr pDepthMarketData);

  private SwigDelegateCHSMdSpi_0 swigDelegate0;
  private SwigDelegateCHSMdSpi_1 swigDelegate1;
  private SwigDelegateCHSMdSpi_2 swigDelegate2;
  private SwigDelegateCHSMdSpi_3 swigDelegate3;
  private SwigDelegateCHSMdSpi_4 swigDelegate4;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(CHSRspInfoField), typeof(int), typeof(bool) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(CHSRspInfoField), typeof(int), typeof(bool) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(CHSDepthMarketDataField) };
}

}