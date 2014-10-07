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

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html Class of object that encapsulates the properties of an
 * SBML converter.
 * 
 * @htmlinclude libsbml-facility-only-warning.html
 * 
 * The properties of SBML converters are communicated using objects of
 * class ConversionProperties, and within such objects, individual options
 * are encapsulated using ConversionOption objects.  The ConversionProperties
 * class provides numerous methods for setting and getting options.
 *
 * ConversionProperties objects are also used to determine the target SBML
 * namespace when an SBML converter's behavior depends on the intended
 * Level+Version combination of SBML.  In addition, it is conceivable that
 * conversions may be affected by SBML Level&nbsp;3 packages being used
 * by an SBML document.  These, too, are communicated by the values of
 * the SBML namespaces set on a ConversionProperties object.
 *
 * @see ConversionOption
 * @see SBMLNamespaces
 */

public class ConversionProperties : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal ConversionProperties(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ConversionProperties obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ConversionProperties obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ConversionProperties() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ConversionProperties(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/** 
   * Constructor that initializes the conversion properties
   * with a specific SBML target namespace.
   * 
   * @param targetNS the target namespace to convert to
   */ public
 ConversionProperties(SBMLNamespaces targetNS) : this(libsbmlPINVOKE.new_ConversionProperties__SWIG_0(SBMLNamespaces.getCPtr(targetNS)), true) {
  }

  
/** 
   * Constructor that initializes the conversion properties
   * with a specific SBML target namespace.
   * 
   * @param targetNS the target namespace to convert to
   */ public
 ConversionProperties() : this(libsbmlPINVOKE.new_ConversionProperties__SWIG_1(), true) {
  }

  
/** 
   * Copy constructor.
   *
   * @param orig the object to copy.
   * 
   * @throws @if python ValueError @else SBMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   */ public
 ConversionProperties(ConversionProperties orig) : this(libsbmlPINVOKE.new_ConversionProperties__SWIG_2(ConversionProperties.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/** 
   * Creates and returns a deep copy of this ConversionProperties object.
   * 
   * @return a (deep) copy of this ConversionProperties object.
   */ public
 ConversionProperties clone() {
    IntPtr cPtr = libsbmlPINVOKE.ConversionProperties_clone(swigCPtr);
    ConversionProperties ret = (cPtr == IntPtr.Zero) ? null : new ConversionProperties(cPtr, true);
    return ret;
  }

  
/**
   * Returns the current target SBML namespace.
   *
   * @return the SBMLNamepaces object expressing the target namespace.
   */ public
 SBMLNamespaces getTargetNamespaces() {
	SBMLNamespaces ret
	    = (SBMLNamespaces) libsbml.DowncastSBMLNamespaces(libsbmlPINVOKE.ConversionProperties_getTargetNamespaces(swigCPtr), false);
	return ret;
}

  
/**
   * Returns @c true if the target SBML namespace has been set.
   * 
   * @return @c true if the target namespace has been set, @c false
   * otherwise.
   */ public
 bool hasTargetNamespaces() {
    bool ret = libsbmlPINVOKE.ConversionProperties_hasTargetNamespaces(swigCPtr);
    return ret;
  }

  
/** 
   * Sets the target namespace.
   * 
   * @param targetNS the target namespace to use.
   */ public
 void setTargetNamespaces(SBMLNamespaces targetNS) {
    libsbmlPINVOKE.ConversionProperties_setTargetNamespaces(swigCPtr, SBMLNamespaces.getCPtr(targetNS));
  }

  
/**
   * Returns the description string for a given option in this properties
   * object.
   * 
   * @param key the key for the option.
   * 
   * @return the description text of the option with the given key.
   */ public
 string getDescription(string key) {
    string ret = libsbmlPINVOKE.ConversionProperties_getDescription(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns the type of a given option in this properties object.
   * 
   * @param key the key for the option.
   * 
   * @return the type of the option with the given key.
   */ public
 int getType(string key) {
    int ret = libsbmlPINVOKE.ConversionProperties_getType(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns the ConversionOption object for a given key.
   * 
   * @param key the key for the option.
   * 
   * @return the option with the given key.
   */ public
 ConversionOption getOption(string key) {
    IntPtr cPtr = libsbmlPINVOKE.ConversionProperties_getOption(swigCPtr, key);
    ConversionOption ret = (cPtr == IntPtr.Zero) ? null : new ConversionOption(cPtr, false);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Adds a copy of the given option to this properties object.
   * 
   * @param option the option to add
   */ public
 void addOption(ConversionOption option) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_0(swigCPtr, ConversionOption.getCPtr(option));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, string value, int type, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_1(swigCPtr, key, value, type, description);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, string value, int type) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_2(swigCPtr, key, value, type);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, string value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_3(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_4(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the string value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, string value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_5(swigCPtr, key, value, description);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the bool value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, bool value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_7(swigCPtr, key, value, description);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the bool value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, bool value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_8(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the double value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, double value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_9(swigCPtr, key, value, description);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the double value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, double value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_10(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the float value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, float value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_11(swigCPtr, key, value, description);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the float value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, float value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_12(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the integer value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, int value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_13(swigCPtr, key, value, description);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   * 
   * @param key the key for the new option
   * @param value the integer value of that option
   * @param description (optional) the description for the option
   */ public
 void addOption(string key, int value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_14(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Removes the option with the given key from this properties object.
   * 
   * @param key the key for the new option to remove
   * @return the removed option
   */ public
 ConversionOption removeOption(string key) {
    IntPtr cPtr = libsbmlPINVOKE.ConversionProperties_removeOption(swigCPtr, key);
    ConversionOption ret = (cPtr == IntPtr.Zero) ? null : new ConversionOption(cPtr, false);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/** 
   * Returns @c true if this properties object contains an option with
   * the given key.
   * 
   * @param key the key of the option to find.
   * 
   * @return @c true if an option with the given @p key exists in
   * this properties object, @c false otherwise.
   */ public
 bool hasOption(string key) {
    bool ret = libsbmlPINVOKE.ConversionProperties_hasOption(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns the value of the given option as a string.
   * 
   * @param key the key for the option.
   * 
   * @return the string value of the option with the given key.
   */ public
 string getValue(string key) {
    string ret = libsbmlPINVOKE.ConversionProperties_getValue(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the value of the given option to a string.
   * 
   * @param key the key for the option
   * @param value the new value
   */ public
 void setValue(string key, string value) {
    libsbmlPINVOKE.ConversionProperties_setValue(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Returns the value of the given option as a Boolean.
   * 
   * @param key the key for the option.
   * 
   * @return the bool value of the option with the given key.
   */ public
 bool getBoolValue(string key) {
    bool ret = libsbmlPINVOKE.ConversionProperties_getBoolValue(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the value of the given option to a Boolean.
   * 
   * @param key the key for the option.
   * 
   * @param value the new Boolean value.
   */ public
 void setBoolValue(string key, bool value) {
    libsbmlPINVOKE.ConversionProperties_setBoolValue(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Returns the value of the given option as a @c double.
   * 
   * @param key the key for the option.
   * 
   * @return the double value of the option with the given key.
   */ public
 double getDoubleValue(string key) {
    double ret = libsbmlPINVOKE.ConversionProperties_getDoubleValue(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the value of the given option to a @c double.
   * 
   * @param key the key for the option.
   * 
   * @param value the new double value.
   */ public
 void setDoubleValue(string key, double value) {
    libsbmlPINVOKE.ConversionProperties_setDoubleValue(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Returns the value of the given option as a @c float.
   * 
   * @param key the key for the option.
   * 
   * @return the float value of the option with the given key.
   */ public
 float getFloatValue(string key) {
    float ret = libsbmlPINVOKE.ConversionProperties_getFloatValue(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the value of the given option to a @c float.
   * 
   * @param key the key for the option.
   * 
   * @param value the new float value.
   */ public
 void setFloatValue(string key, float value) {
    libsbmlPINVOKE.ConversionProperties_setFloatValue(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Returns the value of the given option as an integer.
   * 
   * @param key the key for the option.
   * 
   * @return the int value of the option with the given key.
   */ public
 int getIntValue(string key) {
    int ret = libsbmlPINVOKE.ConversionProperties_getIntValue(swigCPtr, key);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the value of the given option to an integer.
   * 
   * @param key the key for the option.
   * 
   * @param value the new integer value.
   */ public
 void setIntValue(string key, int value) {
    libsbmlPINVOKE.ConversionProperties_setIntValue(swigCPtr, key, value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
