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

public class CHSReqUserPasswordUpdateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSReqUserPasswordUpdateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSReqUserPasswordUpdateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSReqUserPasswordUpdateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSReqUserPasswordUpdateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public char PasswordType {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqUserPasswordUpdateField_PasswordType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSReqUserPasswordUpdateField_PasswordType_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqUserPasswordUpdateField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqUserPasswordUpdateField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string NewPassword {
    set {
      HSTradeCppWrapperPINVOKE.CHSReqUserPasswordUpdateField_NewPassword_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSReqUserPasswordUpdateField_NewPassword_get(swigCPtr);
      return ret;
    } 
  }

  public CHSReqUserPasswordUpdateField() : this(HSTradeCppWrapperPINVOKE.new_CHSReqUserPasswordUpdateField(), true) {
  }

}

}