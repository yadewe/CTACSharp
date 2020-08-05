//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ITapQuoteAPI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ITapQuoteAPI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITapQuoteAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ITapQuoteAPI() {
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
          TapQuoteCppWrapperPINVOKE.delete_ITapQuoteAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual int SetAPINotify(ITapQuoteAPINotify apiNotify) {
    int ret = TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_SetAPINotify(swigCPtr, ITapQuoteAPINotify.getCPtr(apiNotify));
    return ret;
  }

  public virtual int SetHostAddress(string IP, ushort port) {
    int ret = TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_SetHostAddress(swigCPtr, IP, port);
    return ret;
  }

  public virtual int Login(TapAPIQuoteLoginAuth loginAuth) {
    int ret = TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_Login(swigCPtr, TapAPIQuoteLoginAuth.getCPtr(loginAuth));
    return ret;
  }

  public virtual int Disconnect() {
    int ret = TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_Disconnect(swigCPtr);
    return ret;
  }

  public virtual int QryCommodity(out uint sessionID) {
    int ret = TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_QryCommodity(swigCPtr, out sessionID);
    return ret;
  }

  public virtual int QryContract(out uint sessionID, TapAPICommodity qryReq) {
    int ret = TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_QryContract(swigCPtr, out sessionID, TapAPICommodity.getCPtr(qryReq));
    return ret;
  }

  public virtual int SubscribeQuote(out uint sessionID, TapAPIContract contract) {
    int ret = TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_SubscribeQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(contract));
    return ret;
  }

  public virtual int UnSubscribeQuote(out uint sessionID, TapAPIContract contract) {
    int ret = TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_UnSubscribeQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(contract));
    return ret;
  }

  public ITapQuoteAPI() : this(TapQuoteCppWrapperPINVOKE.new_ITapQuoteAPI(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("SetAPINotify", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateITapQuoteAPI_0(SwigDirectorMethodSetAPINotify);
    if (SwigDerivedClassHasMethod("SetHostAddress", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateITapQuoteAPI_1(SwigDirectorMethodSetHostAddress);
    if (SwigDerivedClassHasMethod("Login", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateITapQuoteAPI_2(SwigDirectorMethodLogin);
    if (SwigDerivedClassHasMethod("Disconnect", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateITapQuoteAPI_3(SwigDirectorMethodDisconnect);
    if (SwigDerivedClassHasMethod("QryCommodity", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateITapQuoteAPI_4(SwigDirectorMethodQryCommodity);
    if (SwigDerivedClassHasMethod("QryContract", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateITapQuoteAPI_5(SwigDirectorMethodQryContract);
    if (SwigDerivedClassHasMethod("SubscribeQuote", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateITapQuoteAPI_6(SwigDirectorMethodSubscribeQuote);
    if (SwigDerivedClassHasMethod("UnSubscribeQuote", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateITapQuoteAPI_7(SwigDirectorMethodUnSubscribeQuote);
    TapQuoteCppWrapperPINVOKE.ITapQuoteAPI_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ITapQuoteAPI));
    return hasDerivedMethod;
  }

  private int SwigDirectorMethodSetAPINotify(global::System.IntPtr apiNotify) {
    return SetAPINotify((apiNotify == global::System.IntPtr.Zero) ? null : new ITapQuoteAPINotify(apiNotify, false));
  }

  private int SwigDirectorMethodSetHostAddress(string IP, ushort port) {
    return SetHostAddress(IP, port);
  }

  private int SwigDirectorMethodLogin(global::System.IntPtr loginAuth) {
    return Login((loginAuth == global::System.IntPtr.Zero) ? null : new TapAPIQuoteLoginAuth(loginAuth, false));
  }

  private int SwigDirectorMethodDisconnect() {
    return Disconnect();
  }

  private int SwigDirectorMethodQryCommodity(out uint sessionID) {
    return QryCommodity(out sessionID);
  }

  private int SwigDirectorMethodQryContract(out uint sessionID, global::System.IntPtr qryReq) {
    return QryContract(out sessionID, (qryReq == global::System.IntPtr.Zero) ? null : new TapAPICommodity(qryReq, false));
  }

  private int SwigDirectorMethodSubscribeQuote(out uint sessionID, global::System.IntPtr contract) {
    return SubscribeQuote(out sessionID, (contract == global::System.IntPtr.Zero) ? null : new TapAPIContract(contract, false));
  }

  private int SwigDirectorMethodUnSubscribeQuote(out uint sessionID, global::System.IntPtr contract) {
    return UnSubscribeQuote(out sessionID, (contract == global::System.IntPtr.Zero) ? null : new TapAPIContract(contract, false));
  }

  public delegate int SwigDelegateITapQuoteAPI_0(global::System.IntPtr apiNotify);
  public delegate int SwigDelegateITapQuoteAPI_1(string IP, ushort port);
  public delegate int SwigDelegateITapQuoteAPI_2(global::System.IntPtr loginAuth);
  public delegate int SwigDelegateITapQuoteAPI_3();
  public delegate int SwigDelegateITapQuoteAPI_4(out uint sessionID);
  public delegate int SwigDelegateITapQuoteAPI_5(out uint sessionID, global::System.IntPtr qryReq);
  public delegate int SwigDelegateITapQuoteAPI_6(out uint sessionID, global::System.IntPtr contract);
  public delegate int SwigDelegateITapQuoteAPI_7(out uint sessionID, global::System.IntPtr contract);

  private SwigDelegateITapQuoteAPI_0 swigDelegate0;
  private SwigDelegateITapQuoteAPI_1 swigDelegate1;
  private SwigDelegateITapQuoteAPI_2 swigDelegate2;
  private SwigDelegateITapQuoteAPI_3 swigDelegate3;
  private SwigDelegateITapQuoteAPI_4 swigDelegate4;
  private SwigDelegateITapQuoteAPI_5 swigDelegate5;
  private SwigDelegateITapQuoteAPI_6 swigDelegate6;
  private SwigDelegateITapQuoteAPI_7 swigDelegate7;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(ITapQuoteAPINotify) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(string), typeof(ushort) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(TapAPIQuoteLoginAuth) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(uint).MakeByRefType() };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(uint).MakeByRefType(), typeof(TapAPICommodity) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(uint).MakeByRefType(), typeof(TapAPIContract) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(uint).MakeByRefType(), typeof(TapAPIContract) };
}
