/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 *  Implementation of SBML's Parameter construct.
 <p>
 * A {@link Parameter} is used in SBML to define a symbol associated with a value;
 * this symbol can then be used in mathematical formulas in a model.  By
 * default, parameters have constant value for the duration of a
 * simulation, and for this reason are called <em>parameters</em> instead of 
 * <em>variables</em> in SBML, although it is crucial to understand that <em>SBML
 * parameters represent both concepts</em>.  Whether a given SBML
 * parameter is intended to be constant or variable is indicated by the
 * value of its 'constant' attribute.
 <p>
 * SBML's {@link Parameter} has a required attribute, 'id', that gives the
 * parameter a unique identifier by which other parts of an SBML model
 * definition can refer to it.  A parameter can also have an optional
 * 'name' attribute of type <code>string.</code>  Identifiers and names must be used
 * according to the guidelines described in the SBML specifications.
 <p>
 * The optional attribute 'value' determines the value (of type <code>double</code>)
 * assigned to the parameter.  A missing value for 'value' implies that
 * the value either is unknown, or to be obtained from an external source,
 * or determined by an initial assignment.  The unit of measurement
 * associated with the value of the parameter can be specified using the
 * optional attribute 'units'.  Here we only mention briefly some notable
 * points about the possible unit choices, but readers are urged to consult
 * the SBML specification documents for more information:
 * <ul>
 <p>
 * <li> In SBML Level&nbsp;3, there are no constraints on the units that
 * can be assigned to parameters in a model; there are also no units to
 * inherit from the enclosing {@link Model} object (unlike the case for, e.g.,
 * {@link Species} and {@link Compartment}).
 <p>
 * <li> In SBML Level&nbsp;2, the value assigned to the parameter's 'units'
 * attribute must be chosen from one of the following possibilities: one of
 * the base unit identifiers defined in SBML; one of the built-in unit
 * identifiers <code>'substance'</code>, <code>'time'</code>, <code>'volume'</code>, <code>'area'</code> or 
 * <code>'length'</code>; or the identifier of a new unit defined in the list of unit
 * definitions in the enclosing {@link Model} structure.  There are no constraints
 * on the units that can be chosen from these sets.  There are no default
 * units for parameters.
 * </ul>
 <p>
 * The {@link Parameter} structure has another boolean attribute named 'constant'
 * that is used to indicate whether the parameter's value can vary during a
 * simulation.  (In SBML Level&nbsp;3, the attribute is mandatory and must
 * be given a value; in SBML Levels below Level&nbsp;3, the attribute is
 * optional.)  A value of <code>true</code> indicates the parameter's value cannot be
 * changed by any construct except {@link InitialAssignment}.  Conversely, if the
 * value of 'constant' is <code>false</code>, other constructs in SBML, such as rules
 * and events, can change the value of the parameter.
 <p>
 * SBML Level&nbsp;3 uses a separate object class, {@link LocalParameter}, for
 * parameters that are local to a {@link Reaction}'s {@link KineticLaw}.  In Levels prior
 * to SBML Level&nbsp;3, the {@link Parameter} class is used both for definitions
 * of global parameters, as well as reaction-local parameters stored in a
 * list within {@link KineticLaw} objects.  {@link Parameter} objects that are local to a
 * reaction (that is, those defined within the {@link KineticLaw} structure of a
 * {@link Reaction}) cannot be changed by rules and therefore are <em>implicitly
 * always constant</em>; consequently, in SBML Level&nbsp;2, parameter
 * definitions within {@link Reaction} structures should <em>not</em> have their
 * 'constant' attribute set to <code>false.</code>
 <p>
 * What if a global parameter has its 'constant' attribute set to <code>false</code>,
 * but the model does not contain any rules, events or other constructs
 * that ever change its value over time?  Although the model may be
 * suspect, this situation is not strictly an error.  A value of <code>false</code>
 * for 'constant' only indicates that a parameter <em>can</em> change value, not
 * that it <em>must</em>.
 <p>
 * As with all other major SBML components, {@link Parameter} is derived from
 * {@link SBase}, and the methods defined on {@link SBase} are available on {@link Parameter}.
 <p>
 * @note The use of the term <em>parameter</em> in SBML sometimes leads to
 * confusion among readers who have a particular notion of what something
 * called 'parameter' should be.  It has been the source of heated debate,
 * but despite this, no one has yet found an adequate replacement term that
 * does not have different connotations to different people and hence leads
 * to confusion among <em>some</em> subset of users.  Perhaps it would have been
 * better to have two constructs, one called <em>constants</em> and the other
 * called <em>variables</em>.  The current approach in SBML is simply more
 * parsimonious, using a single {@link Parameter} construct with the boolean flag
 * 'constant' indicating which flavor it is.  In any case, readers are
 * implored to look past their particular definition of a <em>parameter</em> and
 * simply view SBML's {@link Parameter} as a single mechanism for defining both
 * constants and (additional) variables in a model.  (We write 
 * <em>additional</em> because the species in a model are usually considered to be
 * the central variables.)  After all, software tools are not required to
 * expose to users the actual names of particular SBML constructs, and
 * thus tools can present to their users whatever terms their designers
 * feel best matches their target audience.
 <p>
 * @see ListOfParameters
 */

public class Parameter extends SBase {
   private long swigCPtr;

   protected Parameter(long cPtr, boolean cMemoryOwn)
   {
     super(libsbmlJNI.Parameter_SWIGUpcast(cPtr), cMemoryOwn);
     swigCPtr = cPtr;
   }

   protected static long getCPtr(Parameter obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (Parameter obj)
   {
     long ptr = 0;

     if (obj != null)
     {
       ptr             = obj.swigCPtr;
       obj.swigCMemOwn = false;
     }

     return ptr;
   }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libsbmlJNI.delete_Parameter(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  
/**
   * Creates a new {@link Parameter} using the given SBML <code>level</code> and <code>version</code>
   * values.
   <p>
   * @param level a long integer, the SBML Level to assign to this {@link Parameter}
   <p>
   * @param version a long integer, the SBML Version to assign to this
   * {@link Parameter}
   <p>
   * @throws SBMLConstructorException 
   * Thrown if the given <code>level</code> and <code>version</code> combination, or this kind
   * of SBML object, are either invalid or mismatched with respect to the
   * parent {@link SBMLDocument} object.
   <p>
   * <p>
 * @note Upon the addition of a {@link Parameter} object to an {@link SBMLDocument}
 * (e.g., using {@link Model#addParameter(Parameter p)}), the SBML Level, SBML Version
 * and XML namespace of the document <em>override</em> the values used
 * when creating the {@link Parameter} object via this constructor.  This is
 * necessary to ensure that an SBML document is a consistent structure.
 * Nevertheless, the ability to supply the values at the time of creation
 * of a {@link Parameter} is an important aid to producing valid SBML.  Knowledge
 * of the intented SBML Level and Version determine whether it is valid
 * to assign a particular value to an attribute, or whether it is valid
 * to add an object to an existing {@link SBMLDocument}.
   */ public
 Parameter(long level, long version) throws org.sbml.libsbml.SBMLConstructorException {
    this(libsbmlJNI.new_Parameter__SWIG_0(level, version), true);
  }

  
/**
   * Creates a new {@link Parameter} using the given {@link SBMLNamespaces} object
   * <code>sbmlns</code>.
   <p>
   * <p>
 * The {@link SBMLNamespaces} object encapsulates SBML Level/Version/namespaces
 * information.  It is used to communicate the SBML Level, Version, and (in
 * Level&nbsp;3) packages used in addition to SBML Level&nbsp;3 Core.  A
 * common approach to using libSBML's {@link SBMLNamespaces} facilities is to create an
 * {@link SBMLNamespaces} object somewhere in a program once, then hand that object
 * as needed to object constructors that accept {@link SBMLNamespaces} as arguments. 
   <p>
   * It is worth emphasizing that although this constructor does not take
   * an identifier argument, in SBML Level&nbsp;2 and beyond, the 'id'
   * (identifier) attribute of a {@link Parameter} is required to have a value.
   * Thus, callers are cautioned to assign a value after calling this
   * constructor if no identifier is provided as an argument.  Setting the
   * identifier can be accomplished using the method
   * setId(String id).
   <p>
   * @param sbmlns an {@link SBMLNamespaces} object.
   <p>
   * @throws SBMLConstructorException 
   * Thrown if the given <code>level</code> and <code>version</code> combination, or this kind
   * of SBML object, are either invalid or mismatched with respect to the
   * parent {@link SBMLDocument} object.
   <p>
   * <p>
 * @note Upon the addition of a {@link Parameter} object to an {@link SBMLDocument}
 * (e.g., using {@link Model#addParameter(Parameter p)}), the SBML Level, SBML Version
 * and XML namespace of the document <em>override</em> the values used
 * when creating the {@link Parameter} object via this constructor.  This is
 * necessary to ensure that an SBML document is a consistent structure.
 * Nevertheless, the ability to supply the values at the time of creation
 * of a {@link Parameter} is an important aid to producing valid SBML.  Knowledge
 * of the intented SBML Level and Version determine whether it is valid
 * to assign a particular value to an attribute, or whether it is valid
 * to add an object to an existing {@link SBMLDocument}.
   */ public
 Parameter(SBMLNamespaces sbmlns) throws org.sbml.libsbml.SBMLConstructorException {
    this(libsbmlJNI.new_Parameter__SWIG_1(SBMLNamespaces.getCPtr(sbmlns), sbmlns), true);
  }

  
/**
   * Copy constructor; creates a copy of a {@link Parameter}.
   <p>
   * @param orig the {@link Parameter} instance to copy.
   <p>
   * @throws SBMLConstructorException 
   * Thrown if the argument <code>orig</code> is <code>null.</code>
   */ public
 Parameter(Parameter orig) throws org.sbml.libsbml.SBMLConstructorException {
    this(libsbmlJNI.new_Parameter__SWIG_2(Parameter.getCPtr(orig), orig), true);
  }

  
/**
   * Creates and returns a deep copy of this {@link Parameter}.
   <p>
   * @return a (deep) copy of this {@link Parameter}.
   */ public
 Parameter cloneObject() {
    long cPtr = libsbmlJNI.Parameter_cloneObject(swigCPtr, this);
    return (cPtr == 0) ? null : new Parameter(cPtr, true);
  }

  
/**
   * Initializes the fields of this {@link Parameter} object to 'typical' defaults
   * values.
   <p>
   * The SBML {@link Parameter} component has slightly different aspects and
   * default attribute values in different SBML Levels and Versions.  Many
   * SBML object classes defined by libSBML have an initDefaults() method
   * to set the values to certain common defaults, based mostly on what
   * they are in SBML Level&nbsp;2.  In the case of {@link Parameter}, this method
   * only sets the value of the 'constant' attribute to <code>true.</code>
   <p>
   * @see #getConstant()
   * @see #isSetConstant()
   * @see #setConstant(boolean flag)
   */ public
 void initDefaults() {
    libsbmlJNI.Parameter_initDefaults(swigCPtr, this);
  }

  
/**
   * Returns the value of the 'id' attribute of this {@link Parameter}.
   <p>
   * @return the id of this {@link Parameter}.
   */ public
 String getId() {
    return libsbmlJNI.Parameter_getId(swigCPtr, this);
  }

  
/**
   * Returns the value of the 'name' attribute of this {@link Parameter}.
   <p>
   * @return the name of this {@link Parameter}.
   */ public
 String getName() {
    return libsbmlJNI.Parameter_getName(swigCPtr, this);
  }

  
/**
   * Gets the numerical value of this {@link Parameter}.
   <p>
   * @return the value of the 'value' attribute of this {@link Parameter}, as a
   * number of type <code>double.</code>
   <p>
   * @note <b>It is crucial</b> that callers not blindly call
   * {@link Parameter#getValue()} without first using {@link Parameter#isSetValue()} to
   * determine whether a value has ever been set.  Otherwise, the value
   * return by {@link Parameter#getValue()} may not actually represent a value
   * assigned to the parameter.  The reason is simply that the data type
   * <code>double</code> in a program always has <em>some</em> value.  A separate test is
   * needed to determine whether the value is a true model value, or
   * uninitialized data in a computer's memory location.
   <p>
   * @see #isSetValue()
   * @see #setValue(double value)
   * @see #getUnits()
   */ public
 double getValue() {
    return libsbmlJNI.Parameter_getValue(swigCPtr, this);
  }

  
/**
   * Gets the units defined for this {@link Parameter}.
   <p>
   * The value of an SBML parameter's 'units' attribute establishes the
   * unit of measurement associated with the parameter's value.
   <p>
   * @return the value of the 'units' attribute of this {@link Parameter}, as a
   * string.  An empty string indicates that no units have been assigned.
   <p>
   * <p>
 * @note There is an important distinction to be made between <em>no units
 * assigned</em>, and assuming a value without units has any specific unit
 * such as <code>dimensionless</code>.  In SBML, default units are never
 * attributed to numbers, and numbers without units are not automatically
 * assumed to have the unit <code>dimensionless</code>.  Please consult the
 * relevant SBML specification document for a more in-depth explanation of
 * this topic and the SBML unit system.
   <p>
   * @see #isSetUnits()
   * @see #setUnits(String units)
   * @see #getValue()
   */ public
 String getUnits() {
    return libsbmlJNI.Parameter_getUnits(swigCPtr, this);
  }

  
/**
   * Gets the value of the 'constant' attribute of this {@link Parameter} instance.
   <p>
   * @return <code>true</code> if this {@link Parameter} is declared as being constant,
   * <code>false</code> otherwise.
   <p>
   * <p>
 * @note Readers who view the documentation for {@link LocalParameter} may be
 * confused about the presence of this method.  LibSBML derives
 * {@link LocalParameter} from {@link Parameter}; however, this does not precisely match
 * the object hierarchy defined by SBML Level&nbsp;3, where
 * {@link LocalParameter} is derived directly from {@link SBase} and not {@link Parameter}.  We
 * believe this arrangement makes it easier for libSBML users to program
 * applications that work with both SBML Level&nbsp;2 and SBML
 * Level&nbsp;3, but programmers should also keep in mind this difference
 * exists.  A side-effect of libSBML's scheme is that certain methods on
 * {@link LocalParameter} that are inherited from {@link Parameter} do not actually have
 * relevance to {@link LocalParameter} objects.  An example of this is the
 * methods pertaining to {@link Parameter}'s attribute 'constant' (i.e.,
 * isSetConstant(), setConstant(), and getConstant()).
   <p>
   * @see #isSetConstant()
   * @see #setConstant(boolean flag)
   */ public
 boolean getConstant() {
    return libsbmlJNI.Parameter_getConstant(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if this
   * {@link Parameter}'s 'id' attribute is set.
   <p>
   * @return <code>true</code> if the 'id' attribute of this {@link Parameter} is
   * set, <code>false</code> otherwise.
   */ public
 boolean isSetId() {
    return libsbmlJNI.Parameter_isSetId(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if this
   * {@link Parameter}'s 'name' attribute is set.
   <p>
   * @return <code>true</code> if the 'name' attribute of this {@link Parameter} is
   * set, <code>false</code> otherwise.
   */ public
 boolean isSetName() {
    return libsbmlJNI.Parameter_isSetName(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if the
   * 'value' attribute of this {@link Parameter} is set.
   <p>
   * In SBML definitions after SBML Level&nbsp;1 Version&nbsp;1,
   * parameter values are optional and have no defaults.  If a model read
   * from a file does not contain a setting for the 'value' attribute of a
   * parameter, its value is considered unset; it does not default to any
   * particular value.  Similarly, when a {@link Parameter} object is created in
   * libSBML, it has no value until given a value.  The
   * {@link Parameter#isSetValue()} method allows calling applications to
   * determine whether a given parameter's value has ever been set.
   <p>
   * In SBML Level&nbsp;1 Version&nbsp;1, parameters are required to have
   * values and therefore, the value of a {@link Parameter} <b>should always be
   * set</b>.  In Level&nbsp;1 Version&nbsp;2 and beyond, the value is
   * optional and as such, the 'value' attribute may or may not be set.
   <p>
   * @return <code>true</code> if the value of this {@link Parameter} is set,
   * <code>false</code> otherwise.
   <p>
   * @see #getValue()
   * @see #setValue(double value)
   */ public
 boolean isSetValue() {
    return libsbmlJNI.Parameter_isSetValue(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if the
   * 'units' attribute of this {@link Parameter} is set.
   <p>
   * @return <code>true</code> if the 'units' attribute of this {@link Parameter} is
   * set, <code>false</code> otherwise.
   <p>
   * <p>
 * @note There is an important distinction to be made between <em>no units
 * assigned</em>, and assuming a value without units has any specific unit
 * such as <code>dimensionless</code>.  In SBML, default units are never
 * attributed to numbers, and numbers without units are not automatically
 * assumed to have the unit <code>dimensionless</code>.  Please consult the
 * relevant SBML specification document for a more in-depth explanation of
 * this topic and the SBML unit system.
   */ public
 boolean isSetUnits() {
    return libsbmlJNI.Parameter_isSetUnits(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if the
   * 'constant' attribute of this {@link Parameter} is set.
   <p>
   * @return <code>true</code> if the 'constant' attribute of this {@link Parameter} is
   * set, <code>false</code> otherwise.
   <p>
   * <p>
 * @note Readers who view the documentation for {@link LocalParameter} may be
 * confused about the presence of this method.  LibSBML derives
 * {@link LocalParameter} from {@link Parameter}; however, this does not precisely match
 * the object hierarchy defined by SBML Level&nbsp;3, where
 * {@link LocalParameter} is derived directly from {@link SBase} and not {@link Parameter}.  We
 * believe this arrangement makes it easier for libSBML users to program
 * applications that work with both SBML Level&nbsp;2 and SBML
 * Level&nbsp;3, but programmers should also keep in mind this difference
 * exists.  A side-effect of libSBML's scheme is that certain methods on
 * {@link LocalParameter} that are inherited from {@link Parameter} do not actually have
 * relevance to {@link LocalParameter} objects.  An example of this is the
 * methods pertaining to {@link Parameter}'s attribute 'constant' (i.e.,
 * isSetConstant(), setConstant(), and getConstant()).
   <p>
   * @see #getConstant()
   * @see #setConstant(boolean flag)
   */ public
 boolean isSetConstant() {
    return libsbmlJNI.Parameter_isSetConstant(swigCPtr, this);
  }

  
/**
   * Sets the value of the 'id' attribute of this {@link Parameter}.
   <p>
   * The string <code>sid</code> is copied.
   <p>
   * <p>
 * SBML has strict requirements for the syntax of identifiers, that is, the
 * values of the 'id' attribute present on most types of SBML objects.
 * The following is a summary of the definition of the SBML identifier type 
 * <code>SId</code>, which defines the permitted syntax of identifiers.  We
 * express the syntax using an extended form of BNF notation: 
 * <pre style='margin-left: 2em; border: none; font-weight: bold; font-size: 13px; color: black'>
 * letter .= 'a'..'z','A'..'Z'
 * digit  .= '0'..'9'
 * idChar .= letter | digit | '_'
 * SId    .= ( letter | '_' ) idChar*
 * </pre>
 * The characters <code>(</code> and <code>)</code> are used for grouping, the
 * character <code>*</code> 'zero or more times', and the character
 * <code>|</code> indicates logical 'or'.  The equality of SBML identifiers is
 * determined by an exact character sequence match; i.e., comparisons must be
 * performed in a case-sensitive manner.  In addition, there are a few
 * conditions for the uniqueness of identifiers in an SBML model.  Please
 * consult the SBML specifications for the exact details of the uniqueness
 * requirements.
   <p>
   * @param sid the string to use as the identifier of this {@link Parameter}
   <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE }
   * </ul>
   */ public
 int setId(String sid) {
    return libsbmlJNI.Parameter_setId(swigCPtr, this, sid);
  }

  
/**
   * Sets the value of the 'name' attribute of this {@link Parameter}.
   <p>
   * The string in <code>name</code> is copied.
   <p>
   * @param name the new name for the {@link Parameter}
   <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE }
   * </ul>
   */ public
 int setName(String name) {
    return libsbmlJNI.Parameter_setName(swigCPtr, this, name);
  }

  
/**
   * Sets the 'value' attribute of this {@link Parameter} to the given <code>double</code>
   * value and marks the attribute as set.
   <p>
   * @param value a <code>double</code>, the value to assign
   <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * </ul>
   */ public
 int setValue(double value) {
    return libsbmlJNI.Parameter_setValue(swigCPtr, this, value);
  }

  
/**
   * Sets the 'units' attribute of this {@link Parameter} to a copy of the given
   * units identifier <code>units</code>.
   <p>
   * @param units a string, the identifier of the units to assign to this
   * {@link Parameter} instance
   <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE }
   * </ul>
   */ public
 int setUnits(String units) {
    return libsbmlJNI.Parameter_setUnits(swigCPtr, this, units);
  }

  
/**
   * Sets the 'constant' attribute of this {@link Parameter} to the given boolean
   * <code>flag</code>.
   <p>
   * @param flag a boolean, the value for the 'constant' attribute of this
   * {@link Parameter} instance
   <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE }
   *
   * </ul> <p>
   * <p>
 * @note Readers who view the documentation for {@link LocalParameter} may be
 * confused about the presence of this method.  LibSBML derives
 * {@link LocalParameter} from {@link Parameter}; however, this does not precisely match
 * the object hierarchy defined by SBML Level&nbsp;3, where
 * {@link LocalParameter} is derived directly from {@link SBase} and not {@link Parameter}.  We
 * believe this arrangement makes it easier for libSBML users to program
 * applications that work with both SBML Level&nbsp;2 and SBML
 * Level&nbsp;3, but programmers should also keep in mind this difference
 * exists.  A side-effect of libSBML's scheme is that certain methods on
 * {@link LocalParameter} that are inherited from {@link Parameter} do not actually have
 * relevance to {@link LocalParameter} objects.  An example of this is the
 * methods pertaining to {@link Parameter}'s attribute 'constant' (i.e.,
 * isSetConstant(), setConstant(), and getConstant()).
   <p>
   * @see #getConstant()
   * @see #isSetConstant()
   */ public
 int setConstant(boolean flag) {
    return libsbmlJNI.Parameter_setConstant(swigCPtr, this, flag);
  }

  
/**
   * Unsets the value of the 'name' attribute of this {@link Parameter}.
   <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED }
   * </ul>
   */ public
 int unsetName() {
    return libsbmlJNI.Parameter_unsetName(swigCPtr, this);
  }

  
/**
   * Unsets the 'value' attribute of this {@link Parameter} instance.
   <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   *
   * </ul> <p>
   * In SBML Level&nbsp;1 Version&nbsp;1, parameters are required to have
   * values and therefore, the value of a {@link Parameter} <b>should always be
   * set</b>.  In SBML Level&nbsp;1 Version&nbsp;2 and beyond, the value
   * is optional and as such, the 'value' attribute may or may not be set.
   */ public
 int unsetValue() {
    return libsbmlJNI.Parameter_unsetValue(swigCPtr, this);
  }

  
/**
   * Unsets the 'units' attribute of this {@link Parameter} instance.
   <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED }
   * </ul>
   */ public
 int unsetUnits() {
    return libsbmlJNI.Parameter_unsetUnits(swigCPtr, this);
  }

  
/**
   * Constructs and returns a {@link UnitDefinition} that corresponds to the units
   * of this {@link Parameter}'s value.
   <p>
   * Parameters in SBML have an attribute ('units') for declaring the units
   * of measurement intended for the parameter's value.  <b>No defaults are
   * defined</b> by SBML in the absence of a definition for 'units'.  This
   * method returns a {@link UnitDefinition} object based on the units declared for
   * this {@link Parameter} using its 'units' attribute, or it returns <code>null</code> if
   * no units have been declared.
   <p>
   * Note that unit declarations for {@link Parameter} objects are specified in
   * terms of the <em>identifier</em> of a unit (e.g., using setUnits()), but
   * <em>this</em> method returns a {@link UnitDefinition} object, not a unit
   * identifier.  It does this by constructing an appropriate
   * {@link UnitDefinition}.For SBML Level&nbsp;2 models, it will do this even when
   * the value of the 'units' attribute is one of the special SBML
   * Level&nbsp;2 unit identifiers <code>'substance'</code>, <code>'volume'</code>, <code>'area'</code>,
   * <code>'length'</code> or <code>'time'.</code>  Callers may find this useful in conjunction
   * with the helper methods provided by the {@link UnitDefinition} class for
   * comparing different {@link UnitDefinition} objects.
   <p>
   * @return a {@link UnitDefinition} that expresses the units of this 
   * {@link Parameter}, or <code>null</code> if one cannot be constructed.
   <p>
   * @note The libSBML system for unit analysis depends on the model as a
   * whole.  In cases where the {@link Parameter} object has not yet been added to
   * a model, or the model itself is incomplete, unit analysis is not
   * possible, and consequently this method will return <code>null.</code>
   <p>
   * @see #isSetUnits()
   */ public
 UnitDefinition getDerivedUnitDefinition() {
    long cPtr = libsbmlJNI.Parameter_getDerivedUnitDefinition__SWIG_0(swigCPtr, this);
    return (cPtr == 0) ? null : new UnitDefinition(cPtr, false);
  }

  
/**
   * Returns the libSBML type code for this SBML object.
   <p>
   * <p>
 * LibSBML attaches an identifying code to every kind of SBML object.  These
 * are integer constants known as <em>SBML type codes</em>.  The names of all
 * the codes begin with the characters &ldquo;<code>SBML_</code>&rdquo;. 
 * In the Java language interface for libSBML, the
 * type codes are defined as static integer constants in the interface class
 * {@link libsbmlConstants}.    Note that different Level&nbsp;3 
 * package plug-ins may use overlapping type codes; to identify the package
 * to which a given object belongs, call the <code>getPackageName()</code>
 * method on the object.
   <p>
   * @return the SBML type code for this object:
   * {@link  libsbmlConstants#SBML_PARAMETER SBML_PARAMETER} (default).
   <p>
   * <p>
 * @warning <span class='warning'>The specific integer values of the possible
 * type codes may be reused by different Level&nbsp;3 package plug-ins.
 * Thus, to identifiy the correct code, <strong>it is necessary to invoke
 * both getTypeCode() and getPackageName()</strong>.</span>
   <p>
   * @see #getElementName()
   * @see #getPackageName()
   */ public
 int getTypeCode() {
    return libsbmlJNI.Parameter_getTypeCode(swigCPtr, this);
  }

  
/**
   * Returns the XML element name of this object, which for {@link Parameter}, is
   * always <code>'parameter'.</code>
   <p>
   * @return the name of this element, i.e., <code>'parameter'.</code>
   */ public
 String getElementName() {
    return libsbmlJNI.Parameter_getElementName(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if
   * all the required attributes for this {@link Parameter} object
   * have been set.
   <p>
   * @note The required attributes for a {@link Parameter} object are:
   * <ul>
   * <li> 'id' (or 'name' in SBML Level&nbsp;1)
   * <li> 'value' (required in Level&nbsp;1, optional otherwise)
   *
   * </ul> <p>
   * @return a boolean value indicating whether all the required
   * attributes for this object have been defined.
   */ public
 boolean hasRequiredAttributes() {
    return libsbmlJNI.Parameter_hasRequiredAttributes(swigCPtr, this);
  }

  
/**
   * Renames all the <code>UnitSIdRef</code> attributes on this element.
   <p>
   * <p>
 * In SBML, unit definitions have identifiers of type <code>UnitSId</code>.  In
 * SBML Level&nbsp;3, an explicit data type called <code>UnitSIdRef</code> was
 * introduced for attribute values that refer to <code>UnitSId</code> values; in
 * previous Levels of SBML, this data type did not exist and attributes were
 * simply described to as 'referring to a unit identifier', but the effective
 * data type was the same as <code>UnitSIdRef</code> in Level&nbsp;3.  These and
 * other methods of libSBML refer to the type <code>UnitSIdRef</code> for all
 * Levels of SBML, even if the corresponding SBML specification did not
 * explicitly name the data type.
   <p>
   * This method works by looking at all unit identifier attribute values
   * (including, if appropriate, inside mathematical formulas), comparing the
   * unit identifiers to the value of <code>oldid</code>.  If any matches are found,
   * the matching identifiers are replaced with <code>newid</code>.  The method does
   * <em>not</em> descend into child elements.
   <p>
   * @param oldid the old identifier
   * @param newid the new identifier
   */ public
 void renameUnitSIdRefs(String oldid, String newid) {
    libsbmlJNI.Parameter_renameUnitSIdRefs(swigCPtr, this, oldid, newid);
  }

  
/** * @internal */ public
 void setCalculatingUnits(boolean calculatingUnits) {
    libsbmlJNI.Parameter_setCalculatingUnits(swigCPtr, this, calculatingUnits);
  }

}