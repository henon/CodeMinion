// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy.Models;
using Python.Included;

namespace Numpy
{
    public partial class NumPy
    {
        
        /// <summary>
        /// Returns True if cast between data types can occur according to the
        /// casting rule.  If from is a scalar or array scalar, also returns
        /// True if the scalar value can be cast without overflow or truncation
        /// to an integer.
        /// 
        /// Notes
        /// 
        /// Starting in NumPy 1.9, can_cast function now returns False in ‘safe’
        /// casting mode for integer/float dtype and string dtype if the string dtype
        /// length is not long enough to store the max integer/float value converted
        /// to a string. Previously can_cast in ‘safe’ mode returned True for
        /// integer/float dtype and a string dtype of any length.
        /// </summary>
        /// <param name="from_">
        /// Data type, scalar, or array to cast from.
        /// </param>
        /// <param name="to">
        /// Data type to cast to.
        /// </param>
        /// <param name="casting">
        /// Controls what kind of data casting may occur.
        /// </param>
        /// <returns>
        /// True if cast can occur according to the casting rule.
        /// </returns>
        public bool can_cast(Dtype from_, Dtype to, string casting = "safe")
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                from_,
                to,
            });
            var kwargs=new PyDict();
            if (casting!=null) kwargs["casting"]=ToPython(casting);
            dynamic py = __self__.InvokeMethod("can_cast", pyargs, kwargs);
            return ToCsharp<bool>(py);
        }
        
        /// <summary>
        /// Returns the data type with the smallest size and smallest scalar
        /// kind to which both type1 and type2 may be safely cast.
        /// The returned data type is always in native byte order.
        /// 
        /// This function is symmetric, but rarely associative.
        /// 
        /// Notes
        /// 
        /// Starting in NumPy 1.9, promote_types function now returns a valid string
        /// length when given an integer or float dtype as one argument and a string
        /// dtype as another argument. Previously it always returned the input string
        /// dtype, even if it wasn’t long enough to store the max integer/float value
        /// converted to a string.
        /// </summary>
        /// <param name="type1">
        /// First data type.
        /// </param>
        /// <param name="type2">
        /// Second data type.
        /// </param>
        /// <returns>
        /// The promoted data type.
        /// </returns>
        public Dtype promote_types(Dtype type1, Dtype type2)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                type1,
                type2,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("promote_types", pyargs, kwargs);
            return ToCsharp<Dtype>(py);
        }
        
        /// <summary>
        /// For scalar a, returns the data type with the smallest size
        /// and smallest scalar kind which can hold its value.  For non-scalar
        /// array a, returns the vector’s dtype unmodified.
        /// 
        /// Floating point values are not demoted to integers,
        /// and complex values are not demoted to floats.
        /// 
        /// Notes
        /// </summary>
        /// <param name="a">
        /// The value whose minimal data type is to be found.
        /// </param>
        /// <returns>
        /// The minimal data type.
        /// </returns>
        public Dtype min_scalar_type(NDarray a)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("min_scalar_type", pyargs, kwargs);
            return ToCsharp<Dtype>(py);
        }
        
        /*
        /// <summary>
        /// Returns the type that results from applying the NumPy
        /// type promotion rules to the arguments.
        /// 
        /// Type promotion in NumPy works similarly to the rules in languages
        /// like C++, with some slight differences.  When both scalars and
        /// arrays are used, the array’s type takes precedence and the actual value
        /// of the scalar is taken into account.
        /// 
        /// For example, calculating 3*a, where a is an array of 32-bit floats,
        /// intuitively should result in a 32-bit float output.  If the 3 is a
        /// 32-bit integer, the NumPy rules indicate it can’t convert losslessly
        /// into a 32-bit float, so a 64-bit float should be the result type.
        /// By examining the value of the constant, ‘3’, we see that it fits in
        /// an 8-bit integer, which can be cast losslessly into the 32-bit float.
        /// 
        /// Notes
        /// 
        /// The specific algorithm used is as follows.
        /// 
        /// Categories are determined by first checking which of boolean,
        /// integer (int/uint), or floating point (float/complex) the maximum
        /// kind of all the arrays and the scalars are.
        /// 
        /// If there are only scalars or the maximum category of the scalars
        /// is higher than the maximum category of the arrays,
        /// the data types are combined with promote_types
        /// to produce the return value.
        /// 
        /// Otherwise, min_scalar_type is called on each array, and
        /// the resulting data types are all combined with promote_types
        /// to produce the return value.
        /// 
        /// The set of int values is not a subset of the uint values for types
        /// with the same number of bits, something not reflected in
        /// min_scalar_type, but handled as a special case in result_type.
        /// </summary>
        /// <param name="arrays_and_dtypes">
        /// The operands of some operation whose result type is needed.
        /// </param>
        /// <returns>
        /// The result type.
        /// </returns>
        public Dtype result_type(list of arrays and dtypes arrays_and_dtypes)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                arrays_and_dtypes,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("result_type", pyargs, kwargs);
            return ToCsharp<Dtype>(py);
        }
        */
        
        /// <summary>
        /// Return a scalar type which is common to the input arrays.
        /// 
        /// The return type will always be an inexact (i.e. floating point) scalar
        /// type, even if all the arrays are integer arrays. If one of the inputs is
        /// an integer array, the minimum precision type that is returned is a
        /// 64-bit floating point dtype.
        /// 
        /// All input arrays except int64 and uint64 can be safely cast to the
        /// returned dtype without loss of information.
        /// </summary>
        /// <param name="array2">
        /// Input arrays.
        /// </param>
        /// <param name="array1">
        /// Input arrays.
        /// </param>
        /// <returns>
        /// Data type code.
        /// </returns>
        public Dtype common_type(NDarray array2, NDarray array1)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                array2,
                array1,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("common_type", pyargs, kwargs);
            return ToCsharp<Dtype>(py);
        }
        
        /// <summary>
        /// Return the scalar dtype or NumPy equivalent of Python type of an object.
        /// </summary>
        /// <param name="rep">
        /// The object of which the type is returned.
        /// </param>
        /// <param name="default">
        /// If given, this is returned for objects whose types can not be
        /// determined. If not given, None is returned for those objects.
        /// </param>
        /// <returns>
        /// The data type of rep.
        /// </returns>
        public Dtype obj2sctype(object rep, object @default = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                rep,
            });
            var kwargs=new PyDict();
            if (@default!=null) kwargs["default"]=ToPython(@default);
            dynamic py = __self__.InvokeMethod("obj2sctype", pyargs, kwargs);
            return ToCsharp<Dtype>(py);
        }
        
        /// <summary>
        /// Create a data type object.
        /// 
        /// A numpy array is homogeneous, and contains elements described by a
        /// dtype object. A dtype object can be constructed from different
        /// combinations of fundamental numeric types.
        /// </summary>
        /// <param name="align">
        /// Add padding to the fields to match what a C compiler would output
        /// for a similar C-struct. Can be True only if obj is a dictionary
        /// or a comma-separated string. If a struct dtype is being created,
        /// this also sets a sticky alignment flag isalignedstruct.
        /// </param>
        /// <param name="copy">
        /// Make a new copy of the data-type object. If False, the result
        /// may just be a reference to a built-in data-type object.
        /// </param>
        public void dtype(bool? align = null, bool? copy = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
            });
            var kwargs=new PyDict();
            if (align!=null) kwargs["align"]=ToPython(align);
            if (copy!=null) kwargs["copy"]=ToPython(copy);
            dynamic py = __self__.InvokeMethod("dtype", pyargs, kwargs);
        }
        
        /// <summary>
        /// Class to convert formats, names, titles description to a dtype.
        /// 
        /// After constructing the format_parser object, the dtype attribute is
        /// the converted data-type:
        /// dtype = format_parser(formats, names, titles).dtype
        /// </summary>
        /// <param name="formats">
        /// The format description, either specified as a string with
        /// comma-separated format descriptions in the form 'f8, i4, a5', or
        /// a list of format description strings  in the form
        /// ['f8', 'i4', 'a5'].
        /// </param>
        /// <param name="names">
        /// The field names, either specified as a comma-separated string in the
        /// form 'col1, col2, col3', or as a list or tuple of strings in the
        /// form ['col1', 'col2', 'col3'].
        /// An empty list can be used, in that case default field names
        /// (‘f0’, ‘f1’, …) are used.
        /// </param>
        /// <param name="titles">
        /// Sequence of title strings. An empty list can be used to leave titles
        /// out.
        /// </param>
        /// <param name="aligned">
        /// If True, align the fields by padding as the C-compiler would.
        /// Default is False.
        /// </param>
        /// <param name="byteorder">
        /// If specified, all the fields will be changed to the
        /// provided byte-order.  Otherwise, the default byte-order is
        /// used. For all available string specifiers, see dtype.newbyteorder.
        /// </param>
        public void format_parser(string[] formats, string[] names, string[] titles, bool? aligned = null, string byteorder = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                formats,
                names,
                titles,
            });
            var kwargs=new PyDict();
            if (aligned!=null) kwargs["aligned"]=ToPython(aligned);
            if (byteorder!=null) kwargs["byteorder"]=ToPython(byteorder);
            dynamic py = __self__.InvokeMethod("format_parser", pyargs, kwargs);
        }
        
        /// <summary>
        /// Machine limits for floating point types.
        /// 
        /// Notes
        /// 
        /// For developers of NumPy: do not instantiate this at the module level.
        /// The initial calculation of these parameters is expensive and negatively
        /// impacts import times.  These objects are cached, so calling finfo()
        /// repeatedly inside your functions is not a problem.
        /// </summary>
        /// <param name="dtype">
        /// Kind of floating point data-type about which to get information.
        /// </param>
        public void finfo(Dtype dtype)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                dtype,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("finfo", pyargs, kwargs);
        }
        
        /// <summary>
        /// Machine limits for integer types.
        /// </summary>
        /// <param name="int_type">
        /// The kind of integer data type to get information about.
        /// </param>
        public void iinfo(Dtype int_type)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                int_type,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("iinfo", pyargs, kwargs);
        }
        
        /// <summary>
        /// Diagnosing machine parameters.
        /// 
        /// References
        /// </summary>
        /// <param name="float_conv">
        /// Function that converts an integer or integer array to a float
        /// or float array. Default is float.
        /// </param>
        /// <param name="int_conv">
        /// Function that converts a float or float array to an integer or
        /// integer array. Default is int.
        /// </param>
        /// <param name="float_to_float">
        /// Function that converts a float array to float. Default is float.
        /// Note that this does not seem to do anything useful in the current
        /// implementation.
        /// </param>
        /// <param name="float_to_str">
        /// Function that converts a single float to a string. Default is
        /// lambda v:'%24.16e' %v.
        /// </param>
        /// <param name="title">
        /// Title that is printed in the string representation of MachAr.
        /// </param>
        public void MachAr(Delegate float_conv = null, Delegate int_conv = null, Delegate float_to_float = null, Delegate float_to_str = null, string title = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
            });
            var kwargs=new PyDict();
            if (float_conv!=null) kwargs["float_conv"]=ToPython(float_conv);
            if (int_conv!=null) kwargs["int_conv"]=ToPython(int_conv);
            if (float_to_float!=null) kwargs["float_to_float"]=ToPython(float_to_float);
            if (float_to_str!=null) kwargs["float_to_str"]=ToPython(float_to_str);
            if (title!=null) kwargs["title"]=ToPython(title);
            dynamic py = __self__.InvokeMethod("MachAr", pyargs, kwargs);
        }
        
        /// <summary>
        /// Determines whether the given object represents a scalar data-type.
        /// </summary>
        /// <param name="rep">
        /// If rep is an instance of a scalar dtype, True is returned. If not,
        /// False is returned.
        /// </param>
        /// <returns>
        /// Boolean result of check whether rep is a scalar dtype.
        /// </returns>
        public bool issctype(object rep)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                rep,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("issctype", pyargs, kwargs);
            return ToCsharp<bool>(py);
        }
        
        /// <summary>
        /// Returns True if first argument is a typecode lower/equal in type hierarchy.
        /// </summary>
        /// <param name="arg2">
        /// dtype or string representing a typecode.
        /// </param>
        /// <param name="arg1">
        /// dtype or string representing a typecode.
        /// </param>
        public bool issubdtype(Dtype arg2, Dtype arg1)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                arg2,
                arg1,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("issubdtype", pyargs, kwargs);
            return ToCsharp<bool>(py);
        }
        
        /// <summary>
        /// Determine if the first argument is a subclass of the second argument.
        /// </summary>
        /// <param name="arg2">
        /// Data-types.
        /// </param>
        /// <param name="arg1">
        /// Data-types.
        /// </param>
        /// <returns>
        /// The result.
        /// </returns>
        public bool issubsctype(Dtype arg2, Dtype arg1)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                arg2,
                arg1,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("issubsctype", pyargs, kwargs);
            return ToCsharp<bool>(py);
        }
        
        /*
        /// <summary>
        /// Determine if a class is a subclass of a second class.
        /// 
        /// issubclass_ is equivalent to the Python built-in issubclass,
        /// except that it returns False instead of raising a TypeError if one
        /// of the arguments is not a class.
        /// </summary>
        /// <param name="arg1">
        /// Input class. True is returned if arg1 is a subclass of arg2.
        /// </param>
        /// <param name="arg2">
        /// Input class. If a tuple of classes, True is returned if arg1 is a
        /// subclass of any of the tuple elements.
        /// </param>
        /// <returns>
        /// Whether arg1 is a subclass of arg2 or not.
        /// </returns>
        public bool issubclass_(class arg1, class or tuple of classes. arg2)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                arg1,
                arg2,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("issubclass_", pyargs, kwargs);
            return ToCsharp<bool>(py);
        }
        */
        
        /*
        /// <summary>
        /// Determine common type following standard coercion rules.
        /// </summary>
        /// <param name="array_types">
        /// A list of dtypes or dtype convertible objects representing arrays.
        /// </param>
        /// <param name="scalar_types">
        /// A list of dtypes or dtype convertible objects representing scalars.
        /// </param>
        /// <returns>
        /// The common data type, which is the maximum of array_types ignoring
        /// scalar_types, unless the maximum of scalar_types is of a
        /// different kind (dtype.kind). If the kind is not understood, then
        /// None is returned.
        /// </returns>
        public Dtype find_common_type(sequence array_types, sequence scalar_types)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                array_types,
                scalar_types,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("find_common_type", pyargs, kwargs);
            return ToCsharp<Dtype>(py);
        }
        */
        
        /// <summary>
        /// Return a description for the given data type code.
        /// </summary>
        /// <param name="char">
        /// Data type code.
        /// </param>
        /// <returns>
        /// Description of the input data type code.
        /// </returns>
        public string typename(string @char)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                @char,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("typename", pyargs, kwargs);
            return ToCsharp<string>(py);
        }
        
        /// <summary>
        /// Return the string representation of a scalar dtype.
        /// </summary>
        /// <param name="sctype">
        /// If a scalar dtype, the corresponding string character is
        /// returned. If an object, sctype2char tries to infer its scalar type
        /// and then return the corresponding string character.
        /// </param>
        /// <returns>
        /// The string character corresponding to the scalar type.
        /// </returns>
        public string sctype2char(object sctype)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                sctype,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("sctype2char", pyargs, kwargs);
            return ToCsharp<string>(py);
        }
        
        /// <summary>
        /// Return the character for the minimum-size type to which given types can
        /// be safely cast.
        /// 
        /// The returned type character must represent the smallest size dtype such
        /// that an array of the returned type can handle the data from an array of
        /// all types in typechars (or if typechars is an array, then its
        /// dtype.char).
        /// </summary>
        /// <param name="typechars">
        /// If a list of strings, each string should represent a dtype.
        /// If array_like, the character representation of the array dtype is used.
        /// </param>
        /// <param name="typeset">
        /// The set of characters that the returned character is chosen from.
        /// The default set is ‘GDFgdf’.
        /// </param>
        /// <param name="default">
        /// The default character, this is returned if none of the characters in
        /// typechars matches a character in typeset.
        /// </param>
        /// <returns>
        /// The character representing the minimum-size type that was found.
        /// </returns>
        public string mintypecode(string[] typechars, string[] typeset = null, string @default = "d")
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                typechars,
            });
            var kwargs=new PyDict();
            if (typeset!=null) kwargs["typeset"]=ToPython(typeset);
            if (@default!=null) kwargs["default"]=ToPython(@default);
            dynamic py = __self__.InvokeMethod("mintypecode", pyargs, kwargs);
            return ToCsharp<string>(py);
        }
        
    }
}
