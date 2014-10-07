/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbmlcs {

using System;
using System.Runtime.InteropServices;

public class DateList : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DateList(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DateList obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DateList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_DateList(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public DateList() : this(libsbmlPINVOKE.new_DateList(), true) {
  }

  public void add(Date item) {
    libsbmlPINVOKE.DateList_add(swigCPtr, Date.getCPtr(item));
  }

  public Date get(uint n) {
    IntPtr cPtr = libsbmlPINVOKE.DateList_get(swigCPtr, n);
    Date ret = (cPtr == IntPtr.Zero) ? null : new Date(cPtr, false);
    return ret;
  }

  public void prepend(Date item) {
    libsbmlPINVOKE.DateList_prepend(swigCPtr, Date.getCPtr(item));
  }

  public Date remove(uint n) {
    IntPtr cPtr = libsbmlPINVOKE.DateList_remove(swigCPtr, n);
    Date ret = (cPtr == IntPtr.Zero) ? null : new Date(cPtr, false);
    return ret;
  }

  public uint getSize() {
    uint ret = libsbmlPINVOKE.DateList_getSize(swigCPtr);
    return ret;
  }

}

}
