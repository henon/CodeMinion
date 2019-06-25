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
        /// Compute the bit-wise AND of two arrays element-wise.
        /// 
        /// Computes the bit-wise AND of the underlying binary representation of
        /// the integers in the input arrays. This ufunc implements the C/Python
        /// operator &amp;.
        /// </summary>
        /// <param name="x2">
        /// Only integer and boolean types are handled.
        /// </param>
        /// <param name="x1">
        /// Only integer and boolean types are handled.
        /// </param>
        /// <param name="out">
        /// A location into which the result is stored. If provided, it must have
        /// a shape that the inputs broadcast to. If not provided or None,
        /// a freshly-allocated array is returned. A tuple (possible only as a
        /// keyword argument) must have length equal to the number of outputs.
        /// </param>
        /// <param name="where">
        /// Values of True indicate to calculate the ufunc at that position, values
        /// of False indicate to leave the value in the output alone.
        /// </param>
        /// <returns>
        /// Result.
        /// This is a scalar if both x1 and x2 are scalars.
        /// </returns>
        public NDarray bitwise_and(NDarray x2, NDarray x1, NDarray @out = null, NDarray @where = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                x2,
                x1,
            });
            var kwargs=new PyDict();
            if (@out!=null) kwargs["out"]=ToPython(@out);
            if (@where!=null) kwargs["where"]=ToPython(@where);
            dynamic py = __self__.InvokeMethod("bitwise_and", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Compute the bit-wise OR of two arrays element-wise.
        /// 
        /// Computes the bit-wise OR of the underlying binary representation of
        /// the integers in the input arrays. This ufunc implements the C/Python
        /// operator |.
        /// </summary>
        /// <param name="x2">
        /// Only integer and boolean types are handled.
        /// </param>
        /// <param name="x1">
        /// Only integer and boolean types are handled.
        /// </param>
        /// <param name="out">
        /// A location into which the result is stored. If provided, it must have
        /// a shape that the inputs broadcast to. If not provided or None,
        /// a freshly-allocated array is returned. A tuple (possible only as a
        /// keyword argument) must have length equal to the number of outputs.
        /// </param>
        /// <param name="where">
        /// Values of True indicate to calculate the ufunc at that position, values
        /// of False indicate to leave the value in the output alone.
        /// </param>
        /// <returns>
        /// Result.
        /// This is a scalar if both x1 and x2 are scalars.
        /// </returns>
        public NDarray bitwise_or(NDarray x2, NDarray x1, NDarray @out = null, NDarray @where = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                x2,
                x1,
            });
            var kwargs=new PyDict();
            if (@out!=null) kwargs["out"]=ToPython(@out);
            if (@where!=null) kwargs["where"]=ToPython(@where);
            dynamic py = __self__.InvokeMethod("bitwise_or", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Compute the bit-wise XOR of two arrays element-wise.
        /// 
        /// Computes the bit-wise XOR of the underlying binary representation of
        /// the integers in the input arrays. This ufunc implements the C/Python
        /// operator ^.
        /// </summary>
        /// <param name="x2">
        /// Only integer and boolean types are handled.
        /// </param>
        /// <param name="x1">
        /// Only integer and boolean types are handled.
        /// </param>
        /// <param name="out">
        /// A location into which the result is stored. If provided, it must have
        /// a shape that the inputs broadcast to. If not provided or None,
        /// a freshly-allocated array is returned. A tuple (possible only as a
        /// keyword argument) must have length equal to the number of outputs.
        /// </param>
        /// <param name="where">
        /// Values of True indicate to calculate the ufunc at that position, values
        /// of False indicate to leave the value in the output alone.
        /// </param>
        /// <returns>
        /// Result.
        /// This is a scalar if both x1 and x2 are scalars.
        /// </returns>
        public NDarray bitwise_xor(NDarray x2, NDarray x1, NDarray @out = null, NDarray @where = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                x2,
                x1,
            });
            var kwargs=new PyDict();
            if (@out!=null) kwargs["out"]=ToPython(@out);
            if (@where!=null) kwargs["where"]=ToPython(@where);
            dynamic py = __self__.InvokeMethod("bitwise_xor", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Compute bit-wise inversion, or bit-wise NOT, element-wise.
        /// 
        /// Computes the bit-wise NOT of the underlying binary representation of
        /// the integers in the input arrays. This ufunc implements the C/Python
        /// operator ~.
        /// 
        /// For signed integer inputs, the two’s complement is returned.  In a
        /// two’s-complement system negative numbers are represented by the two’s
        /// complement of the absolute value. This is the most common method of
        /// representing signed integers on computers [1]. A N-bit
        /// two’s-complement system can represent every integer in the range
        ///  to .
        /// 
        /// Notes
        /// 
        /// bitwise_not is an alias for invert:
        /// 
        /// References
        /// </summary>
        /// <param name="x">
        /// Only integer and boolean types are handled.
        /// </param>
        /// <param name="out">
        /// A location into which the result is stored. If provided, it must have
        /// a shape that the inputs broadcast to. If not provided or None,
        /// a freshly-allocated array is returned. A tuple (possible only as a
        /// keyword argument) must have length equal to the number of outputs.
        /// </param>
        /// <param name="where">
        /// Values of True indicate to calculate the ufunc at that position, values
        /// of False indicate to leave the value in the output alone.
        /// </param>
        /// <returns>
        /// Result.
        /// This is a scalar if x is a scalar.
        /// </returns>
        public NDarray invert(NDarray x, NDarray @out = null, NDarray @where = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                x,
            });
            var kwargs=new PyDict();
            if (@out!=null) kwargs["out"]=ToPython(@out);
            if (@where!=null) kwargs["where"]=ToPython(@where);
            dynamic py = __self__.InvokeMethod("invert", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Shift the bits of an integer to the left.
        /// 
        /// Bits are shifted to the left by appending x2 0s at the right of x1.
        /// Since the internal representation of numbers is in binary format, this
        /// operation is equivalent to multiplying x1 by 2**x2.
        /// </summary>
        /// <param name="x1">
        /// Input values.
        /// </param>
        /// <param name="x2">
        /// Number of zeros to append to x1. Has to be non-negative.
        /// </param>
        /// <param name="out">
        /// A location into which the result is stored. If provided, it must have
        /// a shape that the inputs broadcast to. If not provided or None,
        /// a freshly-allocated array is returned. A tuple (possible only as a
        /// keyword argument) must have length equal to the number of outputs.
        /// </param>
        /// <param name="where">
        /// Values of True indicate to calculate the ufunc at that position, values
        /// of False indicate to leave the value in the output alone.
        /// </param>
        /// <returns>
        /// Return x1 with bits shifted x2 times to the left.
        /// This is a scalar if both x1 and x2 are scalars.
        /// </returns>
        public NDarray<int> left_shift(NDarray<int> x1, NDarray<int> x2, NDarray @out = null, NDarray @where = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                x1,
                x2,
            });
            var kwargs=new PyDict();
            if (@out!=null) kwargs["out"]=ToPython(@out);
            if (@where!=null) kwargs["where"]=ToPython(@where);
            dynamic py = __self__.InvokeMethod("left_shift", pyargs, kwargs);
            return ToCsharp<NDarray<int>>(py);
        }
        
        /// <summary>
        /// Shift the bits of an integer to the right.
        /// 
        /// Bits are shifted to the right x2.  Because the internal
        /// representation of numbers is in binary format, this operation is
        /// equivalent to dividing x1 by 2**x2.
        /// </summary>
        /// <param name="x1">
        /// Input values.
        /// </param>
        /// <param name="x2">
        /// Number of bits to remove at the right of x1.
        /// </param>
        /// <param name="out">
        /// A location into which the result is stored. If provided, it must have
        /// a shape that the inputs broadcast to. If not provided or None,
        /// a freshly-allocated array is returned. A tuple (possible only as a
        /// keyword argument) must have length equal to the number of outputs.
        /// </param>
        /// <param name="where">
        /// Values of True indicate to calculate the ufunc at that position, values
        /// of False indicate to leave the value in the output alone.
        /// </param>
        /// <returns>
        /// Return x1 with bits shifted x2 times to the right.
        /// This is a scalar if both x1 and x2 are scalars.
        /// </returns>
        public NDarray right_shift(NDarray x1, NDarray x2, NDarray @out = null, NDarray @where = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                x1,
                x2,
            });
            var kwargs=new PyDict();
            if (@out!=null) kwargs["out"]=ToPython(@out);
            if (@where!=null) kwargs["where"]=ToPython(@where);
            dynamic py = __self__.InvokeMethod("right_shift", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Packs the elements of a binary-valued array into bits in a uint8 array.
        /// 
        /// The result is padded to full bytes by inserting zero bits at the end.
        /// </summary>
        /// <param name="myarray">
        /// An array of integers or booleans whose elements should be packed to
        /// bits.
        /// </param>
        /// <param name="axis">
        /// The dimension over which bit-packing is done.
        /// None implies packing the flattened array.
        /// </param>
        /// <returns>
        /// Array of type uint8 whose elements represent bits corresponding to the
        /// logical (0 or nonzero) value of the input elements. The shape of
        /// packed has the same number of dimensions as the input (unless axis
        /// is None, in which case the output is 1-D).
        /// </returns>
        public NDarray packbits(NDarray myarray, int? axis = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                myarray,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = __self__.InvokeMethod("packbits", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Unpacks elements of a uint8 array into a binary-valued output array.
        /// 
        /// Each element of myarray represents a bit-field that should be unpacked
        /// into a binary-valued output array. The shape of the output array is either
        /// 1-D (if axis is None) or the same shape as the input array with unpacking
        /// done along the axis specified.
        /// </summary>
        /// <param name="myarray">
        /// Input array.
        /// </param>
        /// <param name="axis">
        /// The dimension over which bit-unpacking is done.
        /// None implies unpacking the flattened array.
        /// </param>
        /// <returns>
        /// The elements are binary-valued (0 or 1).
        /// </returns>
        public NDarray unpackbits(NDarray myarray, int? axis = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                myarray,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = __self__.InvokeMethod("unpackbits", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return the binary representation of the input number as a string.
        /// 
        /// For negative numbers, if width is not given, a minus sign is added to the
        /// front. If width is given, the two’s complement of the number is
        /// returned, with respect to that width.
        /// 
        /// In a two’s-complement system negative numbers are represented by the two’s
        /// complement of the absolute value. This is the most common method of
        /// representing signed integers on computers [1]. A N-bit two’s-complement
        /// system can represent every integer in the range
        ///  to .
        /// 
        /// Notes
        /// 
        /// binary_repr is equivalent to using base_repr with base 2, but about 25x
        /// faster.
        /// 
        /// References
        /// </summary>
        /// <param name="num">
        /// Only an integer decimal number can be used.
        /// </param>
        /// <param name="width">
        /// The length of the returned string if num is positive, or the length
        /// of the two’s complement if num is negative, provided that width is
        /// at least a sufficient number of bits for num to be represented in the
        /// designated form.
        /// 
        /// If the width value is insufficient, it will be ignored, and num will
        /// be returned in binary (num &gt; 0) or two’s complement (num &lt; 0) form
        /// with its width equal to the minimum number of bits needed to represent
        /// the number in the designated form. This behavior is deprecated and will
        /// later raise an error.
        /// </param>
        /// <returns>
        /// Binary representation of num or two’s complement of num.
        /// </returns>
        public string binary_repr(int num, int? width = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                num,
            });
            var kwargs=new PyDict();
            if (width!=null) kwargs["width"]=ToPython(width);
            dynamic py = __self__.InvokeMethod("binary_repr", pyargs, kwargs);
            return ToCsharp<string>(py);
        }
        
    }
}
