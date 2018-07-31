//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Trade {

public class CHSRspQryTransferField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQryTransferField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQryTransferField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQryTransferField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspQryTransferField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int TransferSerialID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_TransferSerialID_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_TransferSerialID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankName {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_BankName_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_BankName_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessName {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_BusinessName_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_BusinessName_get(swigCPtr);
      return ret;
    } 
  }

  public double OccurBalance {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_OccurBalance_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_OccurBalance_get(swigCPtr);
      return ret;
    } 
  }

  public int TransferTime {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_TransferTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_TransferTime_get(swigCPtr);
      return ret;
    } 
  }

  public char TransferStatus {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_TransferStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_TransferStatus_get(swigCPtr);
      return ret;
    } 
  }

  public char TransferSource {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_TransferSource_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_TransferSource_get(swigCPtr);
      return ret;
    } 
  }

  public string Remarks {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_Remarks_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryTransferField_Remarks_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQryTransferField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspQryTransferField(), true) {
  }

}

}
