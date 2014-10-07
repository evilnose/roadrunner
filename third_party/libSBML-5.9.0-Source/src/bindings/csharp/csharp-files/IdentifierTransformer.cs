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

public class IdentifierTransformer : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal IdentifierTransformer(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(IdentifierTransformer obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (IdentifierTransformer obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~IdentifierTransformer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_IdentifierTransformer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public IdentifierTransformer() : this(libsbmlPINVOKE.new_IdentifierTransformer(), true) {
    SwigDirectorConnect();
  }

  public virtual int transform(SBase element) {
    int ret = (SwigDerivedClassHasMethod("transform", swigMethodTypes0) ? libsbmlPINVOKE.IdentifierTransformer_transformSwigExplicitIdentifierTransformer(swigCPtr, SBase.getCPtr(element)) : libsbmlPINVOKE.IdentifierTransformer_transform(swigCPtr, SBase.getCPtr(element)));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("transform", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateIdentifierTransformer_0(SwigDirectortransform);
    libsbmlPINVOKE.IdentifierTransformer_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(IdentifierTransformer));
    return hasDerivedMethod;
  }

  private int SwigDirectortransform(IntPtr element) {
    return transform((element == IntPtr.Zero) ? null : new SBase(element, false));
  }

  public delegate int SwigDelegateIdentifierTransformer_0(IntPtr element);

  private SwigDelegateIdentifierTransformer_0 swigDelegate0;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(SBase) };
}

}
