/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbml {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html Implementation of SBML's %Parameter construct.
 *
 * A Parameter is used in SBML to define a symbol associated with a value;
 * this symbol can then be used in mathematical formulas in a model.  By
 * default, parameters have constant value for the duration of a
 * simulation, and for this reason are called @em parameters instead of @em
 * variables in SBML, although it is crucial to understand that <em>SBML
 * parameters represent both concepts</em>.  Whether a given SBML
 * parameter is intended to be constant or variable is indicated by the
 * value of its 'constant' attribute.
 * 
 * SBML's Parameter has a required attribute, 'id', that gives the
 * parameter a unique identifier by which other parts of an SBML model
 * definition can refer to it.  A parameter can also have an optional
 * 'name' attribute of type @c string.  Identifiers and names must be used
 * according to the guidelines described in the SBML specifications.
 * 
 * The optional attribute 'value' determines the value (of type @c double)
 * assigned to the parameter.  A missing value for 'value' implies that
 * the value either is unknown, or to be obtained from an external source,
 * or determined by an initial assignment.  The unit of measurement
 * associated with the value of the parameter can be specified using the
 * optional attribute 'units'.  Here we only mention briefly some notable
 * points about the possible unit choices, but readers are urged to consult
 * the SBML specification documents for more information:
 * <ul>
 *
 * <li> In SBML Level&nbsp;3, there are no constraints on the units that
 * can be assigned to parameters in a model; there are also no units to
 * inherit from the enclosing Model object (unlike the case for, e.g.,
 * Species and Compartment).
 *
 * <li> In SBML Level&nbsp;2, the value assigned to the parameter's 'units'
 * attribute must be chosen from one of the following possibilities: one of
 * the base unit identifiers defined in SBML; one of the built-in unit
 * identifiers @c 'substance', @c 'time', @c 'volume', @c 'area' or @c
 * 'length'; or the identifier of a new unit defined in the list of unit
 * definitions in the enclosing Model structure.  There are no constraints
 * on the units that can be chosen from these sets.  There are no default
 * units for parameters.
 * </ul>
 *
 * The Parameter structure has another bool attribute named 'constant'
 * that is used to indicate whether the parameter's value can vary during a
 * simulation.  (In SBML Level&nbsp;3, the attribute is mandatory and must
 * be given a value; in SBML Levels below Level&nbsp;3, the attribute is
 * optional.)  A value of @c true indicates the parameter's value cannot be
 * changed by any construct except InitialAssignment.  Conversely, if the
 * value of 'constant' is @c false, other constructs in SBML, such as rules
 * and events, can change the value of the parameter.
 *
 * SBML Level&nbsp;3 uses a separate object class, LocalParameter, for
 * parameters that are local to a Reaction's KineticLaw.  In Levels prior
 * to SBML Level&nbsp;3, the Parameter class is used both for definitions
 * of global parameters, as well as reaction-local parameters stored in a
 * list within KineticLaw objects.  Parameter objects that are local to a
 * reaction (that is, those defined within the KineticLaw structure of a
 * Reaction) cannot be changed by rules and therefore are <em>implicitly
 * always constant</em>; consequently, in SBML Level&nbsp;2, parameter
 * definitions within Reaction structures should @em not have their
 * 'constant' attribute set to @c false.
 * 
 * What if a global parameter has its 'constant' attribute set to @c false,
 * but the model does not contain any rules, events or other constructs
 * that ever change its value over time?  Although the model may be
 * suspect, this situation is not strictly an error.  A value of @c false
 * for 'constant' only indicates that a parameter @em can change value, not
 * that it @em must.
 *
 * As with all other major SBML components, Parameter is derived from
 * SBase, and the methods defined on SBase are available on Parameter.
 * 
 * @note The use of the term @em parameter in SBML sometimes leads to
 * confusion among readers who have a particular notion of what something
 * called 'parameter' should be.  It has been the source of heated debate,
 * but despite this, no one has yet found an adequate replacement term that
 * does not have different connotations to different people and hence leads
 * to confusion among @em some subset of users.  Perhaps it would have been
 * better to have two constructs, one called @em constants and the other
 * called @em variables.  The current approach in SBML is simply more
 * parsimonious, using a single Parameter construct with the bool flag
 * 'constant' indicating which flavor it is.  In any case, readers are
 * implored to look past their particular definition of a @em parameter and
 * simply view SBML's Parameter as a single mechanism for defining both
 * constants and (additional) variables in a model.  (We write @em
 * additional because the species in a model are usually considered to be
 * the central variables.)  After all, software tools are not required to
 * expose to users the actual names of particular SBML constructs, and
 * thus tools can present to their users whatever terms their designers
 * feel best matches their target audience.
 *
 * @see ListOfParameters
 *
 *
 * 
 */

public class Parameter : SBase {
	private HandleRef swigCPtr;
	
	internal Parameter(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.Parameter_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.ParameterUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(Parameter obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (Parameter obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~Parameter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_Parameter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new Parameter using the given SBML @p level and @p version
   * values.
   *
   * @param level a long integer, the SBML Level to assign to this Parameter
   *
   * @param version a long integer, the SBML Version to assign to this
   * Parameter
   *
   * @throws @if python ValueError @else SBMLConstructorException @endif
   * Thrown if the given @p level and @p version combination, or this kind
   * of SBML object, are either invalid or mismatched with respect to the
   * parent SBMLDocument object.
   *
   * *
 * @note Upon the addition of a Parameter object to an SBMLDocument
 * (e.g., using Model::addParameter(@if java Parameter p@endif)), the SBML Level, SBML Version
 * and XML namespace of the document @em override the values used
 * when creating the Parameter object via this constructor.  This is
 * necessary to ensure that an SBML document is a consistent structure.
 * Nevertheless, the ability to supply the values at the time of creation
 * of a Parameter is an important aid to producing valid SBML.  Knowledge
 * of the intented SBML Level and Version determine whether it is valid
 * to assign a particular value to an attribute, or whether it is valid
 * to add an object to an existing SBMLDocument.
 *
   */ public
 Parameter(long level, long version) : this(libsbmlPINVOKE.new_Parameter__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new Parameter using the given SBMLNamespaces object
   * @p sbmlns.
   *
   * *
 *  
 * The SBMLNamespaces object encapsulates SBML Level/Version/namespaces
 * information.  It is used to communicate the SBML Level, Version, and (in
 * Level&nbsp;3) packages used in addition to SBML Level&nbsp;3 Core.  A
 * common approach to using libSBML's SBMLNamespaces facilities is to create an
 * SBMLNamespaces object somewhere in a program once, then hand that object
 * as needed to object constructors that accept SBMLNamespaces as arguments.
 *
 * 
   *
   * It is worth emphasizing that although this constructor does not take
   * an identifier argument, in SBML Level&nbsp;2 and beyond, the 'id'
   * (identifier) attribute of a Parameter is required to have a value.
   * Thus, callers are cautioned to assign a value after calling this
   * constructor if no identifier is provided as an argument.  Setting the
   * identifier can be accomplished using the method
   * @if java setId(String id)@else setId()@endif.
   *
   * @param sbmlns an SBMLNamespaces object.
   *
   * @throws @if python ValueError @else SBMLConstructorException @endif
   * Thrown if the given @p level and @p version combination, or this kind
   * of SBML object, are either invalid or mismatched with respect to the
   * parent SBMLDocument object.
   *
   * *
 * @note Upon the addition of a Parameter object to an SBMLDocument
 * (e.g., using Model::addParameter(@if java Parameter p@endif)), the SBML Level, SBML Version
 * and XML namespace of the document @em override the values used
 * when creating the Parameter object via this constructor.  This is
 * necessary to ensure that an SBML document is a consistent structure.
 * Nevertheless, the ability to supply the values at the time of creation
 * of a Parameter is an important aid to producing valid SBML.  Knowledge
 * of the intented SBML Level and Version determine whether it is valid
 * to assign a particular value to an attribute, or whether it is valid
 * to add an object to an existing SBMLDocument.
 *
   */ public
 Parameter(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_Parameter__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of a Parameter.
   * 
   * @param orig the Parameter instance to copy.
   * 
   * @throws @if python ValueError @else SBMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   */ public
 Parameter(Parameter orig) : this(libsbmlPINVOKE.new_Parameter__SWIG_2(Parameter.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this Parameter.
   * 
   * @return a (deep) copy of this Parameter.
   */ public new
 Parameter clone() {
    IntPtr cPtr = libsbmlPINVOKE.Parameter_clone(swigCPtr);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, true);
    return ret;
  }

  
/**
   * Initializes the fields of this Parameter object to 'typical' defaults
   * values.
   *
   * The SBML Parameter component has slightly different aspects and
   * default attribute values in different SBML Levels and Versions.  Many
   * SBML object classes defined by libSBML have an initDefaults() method
   * to set the values to certain common defaults, based mostly on what
   * they are in SBML Level&nbsp;2.  In the case of Parameter, this method
   * only sets the value of the 'constant' attribute to @c true.
   *
   * @see getConstant()
   * @see isSetConstant()
   * @see setConstant(@if java bool flag@endif)
   */ public
 void initDefaults() {
    libsbmlPINVOKE.Parameter_initDefaults(swigCPtr);
  }

  
/**
   * Returns the value of the 'id' attribute of this Parameter.
   * 
   * @return the id of this Parameter.
   */ public new
 string getId() {
    string ret = libsbmlPINVOKE.Parameter_getId(swigCPtr);
    return ret;
  }

  
/**
   * Returns the value of the 'name' attribute of this Parameter.
   * 
   * @return the name of this Parameter.
   */ public new
 string getName() {
    string ret = libsbmlPINVOKE.Parameter_getName(swigCPtr);
    return ret;
  }

  
/**
   * Gets the numerical value of this Parameter.
   * 
   * @return the value of the 'value' attribute of this Parameter, as a
   * number of type @c double.
   *
   * @note <b>It is crucial</b> that callers not blindly call
   * Parameter::getValue() without first using Parameter::isSetValue() to
   * determine whether a value has ever been set.  Otherwise, the value
   * return by Parameter::getValue() may not actually represent a value
   * assigned to the parameter.  The reason is simply that the data type
   * @c double in a program always has @em some value.  A separate test is
   * needed to determine whether the value is a true model value, or
   * uninitialized data in a computer's memory location.
   * 
   * @see isSetValue()
   * @see setValue(double value)
   * @see getUnits()
   */ public
 double getValue() {
    double ret = libsbmlPINVOKE.Parameter_getValue(swigCPtr);
    return ret;
  }

  
/**
   * Gets the units defined for this Parameter.
   *
   * The value of an SBML parameter's 'units' attribute establishes the
   * unit of measurement associated with the parameter's value.
   *
   * @return the value of the 'units' attribute of this Parameter, as a
   * string.  An empty string indicates that no units have been assigned.
   *
   * *
 * @note There is an important distinction to be made between <em>no units
 * assigned</em>, and assuming a value without units has any specific unit
 * such as <code>dimensionless</code>.  In SBML, default units are never
 * attributed to numbers, and numbers without units are not automatically
 * assumed to have the unit <code>dimensionless</code>.  Please consult the
 * relevant SBML specification document for a more in-depth explanation of
 * this topic and the SBML unit system.
 *
 *
   * 
   * @see isSetUnits()
   * @see setUnits(@if java String units@endif)
   * @see getValue()
   */ public
 string getUnits() {
    string ret = libsbmlPINVOKE.Parameter_getUnits(swigCPtr);
    return ret;
  }

  
/**
   * Gets the value of the 'constant' attribute of this Parameter instance.
   * 
   * @return @c true if this Parameter is declared as being constant,
   * @c false otherwise.
   *
   * *
 * @note Readers who view the documentation for LocalParameter may be
 * confused about the presence of this method.  LibSBML derives
 * LocalParameter from Parameter; however, this does not precisely match
 * the object hierarchy defined by SBML Level&nbsp;3, where
 * LocalParameter is derived directly from SBase and not Parameter.  We
 * believe this arrangement makes it easier for libSBML users to program
 * applications that work with both SBML Level&nbsp;2 and SBML
 * Level&nbsp;3, but programmers should also keep in mind this difference
 * exists.  A side-effect of libSBML's scheme is that certain methods on
 * LocalParameter that are inherited from Parameter do not actually have
 * relevance to LocalParameter objects.  An example of this is the
 * methods pertaining to Parameter's attribute 'constant' (i.e.,
 * isSetConstant(), setConstant(), and getConstant()).
 *
   * 
   * @see isSetConstant()
   * @see setConstant(@if java bool flag@endif)
   */ public
 bool getConstant() {
    bool ret = libsbmlPINVOKE.Parameter_getConstant(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * Parameter's 'id' attribute is set.
   *
   * @return @c true if the 'id' attribute of this Parameter is
   * set, @c false otherwise.
   */ public new
 bool isSetId() {
    bool ret = libsbmlPINVOKE.Parameter_isSetId(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * Parameter's 'name' attribute is set.
   *
   * @return @c true if the 'name' attribute of this Parameter is
   * set, @c false otherwise.
   */ public new
 bool isSetName() {
    bool ret = libsbmlPINVOKE.Parameter_isSetName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if the
   * 'value' attribute of this Parameter is set.
   *
   * In SBML definitions after SBML Level&nbsp;1 Version&nbsp;1,
   * parameter values are optional and have no defaults.  If a model read
   * from a file does not contain a setting for the 'value' attribute of a
   * parameter, its value is considered unset; it does not default to any
   * particular value.  Similarly, when a Parameter object is created in
   * libSBML, it has no value until given a value.  The
   * Parameter::isSetValue() method allows calling applications to
   * determine whether a given parameter's value has ever been set.
   *
   * In SBML Level&nbsp;1 Version&nbsp;1, parameters are required to have
   * values and therefore, the value of a Parameter <b>should always be
   * set</b>.  In Level&nbsp;1 Version&nbsp;2 and beyond, the value is
   * optional and as such, the 'value' attribute may or may not be set.
   *
   * @return @c true if the value of this Parameter is set,
   * @c false otherwise.
   *
   * @see getValue()
   * @see setValue(double value)
   */ public
 bool isSetValue() {
    bool ret = libsbmlPINVOKE.Parameter_isSetValue(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if the
   * 'units' attribute of this Parameter is set.
   *
   * @return @c true if the 'units' attribute of this Parameter is
   * set, @c false otherwise.
   *
   * *
 * @note There is an important distinction to be made between <em>no units
 * assigned</em>, and assuming a value without units has any specific unit
 * such as <code>dimensionless</code>.  In SBML, default units are never
 * attributed to numbers, and numbers without units are not automatically
 * assumed to have the unit <code>dimensionless</code>.  Please consult the
 * relevant SBML specification document for a more in-depth explanation of
 * this topic and the SBML unit system.
 *
 *
   */ public
 bool isSetUnits() {
    bool ret = libsbmlPINVOKE.Parameter_isSetUnits(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if the
   * 'constant' attribute of this Parameter is set.
   *
   * @return @c true if the 'constant' attribute of this Parameter is
   * set, @c false otherwise.
   *
   * *
 * @note Readers who view the documentation for LocalParameter may be
 * confused about the presence of this method.  LibSBML derives
 * LocalParameter from Parameter; however, this does not precisely match
 * the object hierarchy defined by SBML Level&nbsp;3, where
 * LocalParameter is derived directly from SBase and not Parameter.  We
 * believe this arrangement makes it easier for libSBML users to program
 * applications that work with both SBML Level&nbsp;2 and SBML
 * Level&nbsp;3, but programmers should also keep in mind this difference
 * exists.  A side-effect of libSBML's scheme is that certain methods on
 * LocalParameter that are inherited from Parameter do not actually have
 * relevance to LocalParameter objects.  An example of this is the
 * methods pertaining to Parameter's attribute 'constant' (i.e.,
 * isSetConstant(), setConstant(), and getConstant()).
 *
   *
   * @see getConstant()
   * @see setConstant(@if java bool flag@endif)
   */ public
 bool isSetConstant() {
    bool ret = libsbmlPINVOKE.Parameter_isSetConstant(swigCPtr);
    return ret;
  }

  
/**
   * Sets the value of the 'id' attribute of this Parameter.
   *
   * The string @p sid is copied.
   *
   * *
 * 
 * SBML has strict requirements for the syntax of identifiers, that is, the
 * values of the 'id' attribute present on most types of SBML objects.
 * The following is a summary of the definition of the SBML identifier type 
 * <code>SId</code>, which defines the permitted syntax of identifiers.  We
 * express the syntax using an extended form of BNF notation: 
 * <pre style='margin-left: 2em; border: none; font-weight: bold; font-size: 13px; color: black'>
 * letter ::= 'a'..'z','A'..'Z'
 * digit  ::= '0'..'9'
 * idChar ::= letter | digit | '_'
 * SId    ::= ( letter | '_' ) idChar*
 * </pre>
 * The characters <code>(</code> and <code>)</code> are used for grouping, the
 * character <code>*</code> 'zero or more times', and the character
 * <code>|</code> indicates logical 'or'.  The equality of SBML identifiers is
 * determined by an exact character sequence match; i.e., comparisons must be
 * performed in a case-sensitive manner.  In addition, there are a few
 * conditions for the uniqueness of identifiers in an SBML model.  Please
 * consult the SBML specifications for the exact details of the uniqueness
 * requirements.
 * 
 *
   *
   * @param sid the string to use as the identifier of this Parameter
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */ public new
 int setId(string sid) {
    int ret = libsbmlPINVOKE.Parameter_setId(swigCPtr, sid);
    return ret;
  }

  
/**
   * Sets the value of the 'name' attribute of this Parameter.
   *
   * The string in @p name is copied.
   *
   * @param name the new name for the Parameter
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */ public new
 int setName(string name) {
    int ret = libsbmlPINVOKE.Parameter_setName(swigCPtr, name);
    return ret;
  }

  
/**
   * Sets the 'value' attribute of this Parameter to the given @c double
   * value and marks the attribute as set.
   *
   * @param value a @c double, the value to assign
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   */ public
 int setValue(double value) {
    int ret = libsbmlPINVOKE.Parameter_setValue(swigCPtr, value);
    return ret;
  }

  
/**
   * Sets the 'units' attribute of this Parameter to a copy of the given
   * units identifier @p units.
   *
   * @param units a string, the identifier of the units to assign to this
   * Parameter instance
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */ public
 int setUnits(string units) {
    int ret = libsbmlPINVOKE.Parameter_setUnits(swigCPtr, units);
    return ret;
  }

  
/**
   * Sets the 'constant' attribute of this Parameter to the given bool
   * @p flag.
   *
   * @param flag a bool, the value for the 'constant' attribute of this
   * Parameter instance
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   *
   * *
 * @note Readers who view the documentation for LocalParameter may be
 * confused about the presence of this method.  LibSBML derives
 * LocalParameter from Parameter; however, this does not precisely match
 * the object hierarchy defined by SBML Level&nbsp;3, where
 * LocalParameter is derived directly from SBase and not Parameter.  We
 * believe this arrangement makes it easier for libSBML users to program
 * applications that work with both SBML Level&nbsp;2 and SBML
 * Level&nbsp;3, but programmers should also keep in mind this difference
 * exists.  A side-effect of libSBML's scheme is that certain methods on
 * LocalParameter that are inherited from Parameter do not actually have
 * relevance to LocalParameter objects.  An example of this is the
 * methods pertaining to Parameter's attribute 'constant' (i.e.,
 * isSetConstant(), setConstant(), and getConstant()).
 *
   *
   * @see getConstant()
   * @see isSetConstant()
   */ public
 int setConstant(bool flag) {
    int ret = libsbmlPINVOKE.Parameter_setConstant(swigCPtr, flag);
    return ret;
  }

  
/**
   * Unsets the value of the 'name' attribute of this Parameter.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */ public new
 int unsetName() {
    int ret = libsbmlPINVOKE.Parameter_unsetName(swigCPtr);
    return ret;
  }

  
/**
   * Unsets the 'value' attribute of this Parameter instance.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   *
   * In SBML Level&nbsp;1 Version&nbsp;1, parameters are required to have
   * values and therefore, the value of a Parameter <b>should always be
   * set</b>.  In SBML Level&nbsp;1 Version&nbsp;2 and beyond, the value
   * is optional and as such, the 'value' attribute may or may not be set.
   */ public
 int unsetValue() {
    int ret = libsbmlPINVOKE.Parameter_unsetValue(swigCPtr);
    return ret;
  }

  
/**
   * Unsets the 'units' attribute of this Parameter instance.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */ public
 int unsetUnits() {
    int ret = libsbmlPINVOKE.Parameter_unsetUnits(swigCPtr);
    return ret;
  }

  
/**
   * Constructs and returns a UnitDefinition that corresponds to the units
   * of this Parameter's value.
   *
   * Parameters in SBML have an attribute ('units') for declaring the units
   * of measurement intended for the parameter's value.  <b>No defaults are
   * defined</b> by SBML in the absence of a definition for 'units'.  This
   * method returns a UnitDefinition object based on the units declared for
   * this Parameter using its 'units' attribute, or it returns @c null if
   * no units have been declared.
   *
   * Note that unit declarations for Parameter objects are specified in
   * terms of the @em identifier of a unit (e.g., using setUnits()), but
   * @em this method returns a UnitDefinition object, not a unit
   * identifier.  It does this by constructing an appropriate
   * UnitDefinition.For SBML Level&nbsp;2 models, it will do this even when
   * the value of the 'units' attribute is one of the special SBML
   * Level&nbsp;2 unit identifiers @c 'substance', @c 'volume', @c 'area',
   * @c 'length' or @c 'time'.  Callers may find this useful in conjunction
   * with the helper methods provided by the UnitDefinition class for
   * comparing different UnitDefinition objects.
   *
   * @return a UnitDefinition that expresses the units of this 
   * Parameter, or @c null if one cannot be constructed.
   *
   * @note The libSBML system for unit analysis depends on the model as a
   * whole.  In cases where the Parameter object has not yet been added to
   * a model, or the model itself is incomplete, unit analysis is not
   * possible, and consequently this method will return @c null.
   *
   * @see isSetUnits()
   */ public
 UnitDefinition getDerivedUnitDefinition() {
    IntPtr cPtr = libsbmlPINVOKE.Parameter_getDerivedUnitDefinition__SWIG_0(swigCPtr);
    UnitDefinition ret = (cPtr == IntPtr.Zero) ? null : new UnitDefinition(cPtr, false);
    return ret;
  }

  
/**
   * Returns the libSBML type code for this SBML object.
   * 
   * *
 *  
 * LibSBML attaches an identifying code to every kind of SBML object.  These
 * are integer constants known as <em>SBML type codes</em>.  The names of all
 * the codes begin with the characters &ldquo;<code>SBML_</code>&rdquo;. 
 * @if clike The set of possible type codes for core elements is defined in
 * the enumeration #SBMLTypeCode_t, and in addition, libSBML plug-ins for
 * SBML Level&nbsp;3 packages define their own extra enumerations of type
 * codes (e.g., #SBMLLayoutTypeCode_t for the Level&nbsp;3 Layout
 * package).@endif@if java In the Java language interface for libSBML, the
 * type codes are defined as static integer constants in the interface class
 * {@link libsbmlConstants}.  @endif@if python In the Python language
 * interface for libSBML, the type codes are defined as static integer
 * constants in the interface class @link libsbml@endlink.@endif@if csharp In
 * the C# language interface for libSBML, the type codes are defined as
 * static integer constants in the interface class
 * @link libsbmlcs.libsbml@endlink.@endif  Note that different Level&nbsp;3 
 * package plug-ins may use overlapping type codes; to identify the package
 * to which a given object belongs, call the <code>getPackageName()</code>
 * method on the object.
 * 
 *
   *
   * @return the SBML type code for this object:
   * @link libsbmlcs.libsbml.SBML_PARAMETER SBML_PARAMETER@endlink (default).
   *
   * *
 * @warning <span class='warning'>The specific integer values of the possible
 * type codes may be reused by different Level&nbsp;3 package plug-ins.
 * Thus, to identifiy the correct code, <strong>it is necessary to invoke
 * both getTypeCode() and getPackageName()</strong>.</span>
 *
 *
   *
   * @see getElementName()
   * @see getPackageName()
   */ public new
 int getTypeCode() {
    int ret = libsbmlPINVOKE.Parameter_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object, which for Parameter, is
   * always @c 'parameter'.
   * 
   * @return the name of this element, i.e., @c 'parameter'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.Parameter_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if
   * all the required attributes for this Parameter object
   * have been set.
   *
   * @note The required attributes for a Parameter object are:
   * @li 'id' (or 'name' in SBML Level&nbsp;1)
   * @li 'value' (required in Level&nbsp;1, optional otherwise)
   *
   * @return a bool value indicating whether all the required
   * attributes for this object have been defined.
   */ public new
 bool hasRequiredAttributes() {
    bool ret = libsbmlPINVOKE.Parameter_hasRequiredAttributes(swigCPtr);
    return ret;
  }

  
/**
   * Renames all the @c UnitSIdRef attributes on this element.
   *
   * *
 * 
 * In SBML, unit definitions have identifiers of type <code>UnitSId</code>.  In
 * SBML Level&nbsp;3, an explicit data type called <code>UnitSIdRef</code> was
 * introduced for attribute values that refer to <code>UnitSId</code> values; in
 * previous Levels of SBML, this data type did not exist and attributes were
 * simply described to as 'referring to a unit identifier', but the effective
 * data type was the same as <code>UnitSIdRef</code> in Level&nbsp;3.  These and
 * other methods of libSBML refer to the type <code>UnitSIdRef</code> for all
 * Levels of SBML, even if the corresponding SBML specification did not
 * explicitly name the data type.
 * 
 *
   *
   * This method works by looking at all unit identifier attribute values
   * (including, if appropriate, inside mathematical formulas), comparing the
   * unit identifiers to the value of @p oldid.  If any matches are found,
   * the matching identifiers are replaced with @p newid.  The method does
   * @em not descend into child elements.
   * 
   * @param oldid the old identifier
   * @param newid the new identifier
   */ public
 void renameUnitSIdRefs(string oldid, string newid) {
    libsbmlPINVOKE.Parameter_renameUnitSIdRefs(swigCPtr, oldid, newid);
  }

  
/** */ /* libsbml-internal */ public
 void setCalculatingUnits(bool calculatingUnits) {
    libsbmlPINVOKE.Parameter_setCalculatingUnits(swigCPtr, calculatingUnits);
  }

}

}
