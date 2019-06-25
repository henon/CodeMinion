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

namespace Numpy
{
    public static partial class np
    {
        
        /// <summary>
        /// Compute the future value.
        /// 
        /// Notes
        /// 
        /// The future value is computed by solving the equation:
        /// 
        /// or, when rate == 0:
        /// 
        /// References
        /// </summary>
        /// <param name="rate">
        /// Rate of interest as decimal (not per cent) per period
        /// </param>
        /// <param name="nper">
        /// Number of compounding periods
        /// </param>
        /// <param name="pmt">
        /// Payment
        /// </param>
        /// <param name="pv">
        /// Present value
        /// </param>
        /// <param name="when">
        /// When payments are due (‘begin’ (1) or ‘end’ (0)).
        /// Defaults to {‘end’, 0}.
        /// </param>
        /// <returns>
        /// Future values.  If all input is scalar, returns a scalar float.  If
        /// any input is array_like, returns future values for each input element.
        /// If multiple inputs are array_like, they all must have the same shape.
        /// </returns>
        public static NDarray fv(NDarray rate, NDarray nper, NDarray pmt, NDarray pv, string @when = "end")
            => NumPy.Instance.fv(rate, nper, pmt, pv, @when:@when);
        
        /// <summary>
        /// Compute the present value.
        /// 
        /// Notes
        /// 
        /// The present value is computed by solving the equation:
        /// 
        /// or, when rate = 0:
        /// 
        /// for pv, which is then returned.
        /// 
        /// References
        /// </summary>
        /// <param name="rate">
        /// Rate of interest (per period)
        /// </param>
        /// <param name="nper">
        /// Number of compounding periods
        /// </param>
        /// <param name="pmt">
        /// Payment
        /// </param>
        /// <param name="fv">
        /// Future value
        /// </param>
        /// <param name="when">
        /// When payments are due (‘begin’ (1) or ‘end’ (0))
        /// </param>
        /// <returns>
        /// Present value of a series of payments or investments.
        /// </returns>
        public static NDarray pv(NDarray rate, NDarray nper, NDarray pmt, NDarray fv = null, string @when = "end")
            => NumPy.Instance.pv(rate, nper, pmt, fv:fv, @when:@when);
        
        /// <summary>
        /// Returns the NPV (Net Present Value) of a cash flow series.
        /// 
        /// Notes
        /// 
        /// Returns the result of: [G]
        /// 
        /// References
        /// </summary>
        /// <param name="rate">
        /// The discount rate.
        /// </param>
        /// <param name="values">
        /// The values of the time series of cash flows.  The (fixed) time
        /// interval between cash flow “events” must be the same as that for
        /// which rate is given (i.e., if rate is per year, then precisely
        /// a year is understood to elapse between each cash flow event).  By
        /// convention, investments or “deposits” are negative, income or
        /// “withdrawals” are positive; values must begin with the initial
        /// investment, thus values[0] will typically be negative.
        /// </param>
        /// <returns>
        /// The NPV of the input cash flow series values at the discount
        /// rate.
        /// </returns>
        public static float npv(ValueType rate, NDarray values)
            => NumPy.Instance.npv(rate, values);
        
        /// <summary>
        /// Compute the payment against loan principal plus interest.
        /// 
        /// Notes
        /// 
        /// The payment is computed by solving the equation:
        /// 
        /// or, when rate == 0:
        /// 
        /// for pmt.
        /// 
        /// Note that computing a monthly mortgage payment is only
        /// one use for this function.  For example, pmt returns the
        /// periodic deposit one must make to achieve a specified
        /// future balance given an initial deposit, a fixed,
        /// periodically compounded interest rate, and the total
        /// number of periods.
        /// 
        /// References
        /// </summary>
        /// <param name="rate">
        /// Rate of interest (per period)
        /// </param>
        /// <param name="nper">
        /// Number of compounding periods
        /// </param>
        /// <param name="pv">
        /// Present value
        /// </param>
        /// <param name="fv">
        /// Future value (default = 0)
        /// </param>
        /// <param name="when">
        /// When payments are due (‘begin’ (1) or ‘end’ (0))
        /// </param>
        /// <returns>
        /// Payment against loan plus interest.  If all input is scalar, returns a
        /// scalar float.  If any input is array_like, returns payment for each
        /// input element. If multiple inputs are array_like, they all must have
        /// the same shape.
        /// </returns>
        public static NDarray pmt(NDarray rate, NDarray nper, NDarray pv, NDarray fv = null, string @when = "end")
            => NumPy.Instance.pmt(rate, nper, pv, fv:fv, @when:@when);
        
        /// <summary>
        /// Compute the payment against loan principal.
        /// </summary>
        /// <param name="rate">
        /// Rate of interest (per period)
        /// </param>
        /// <param name="per">
        /// Amount paid against the loan changes.  The per is the period of
        /// interest.
        /// </param>
        /// <param name="nper">
        /// Number of compounding periods
        /// </param>
        /// <param name="pv">
        /// Present value
        /// </param>
        /// <param name="fv">
        /// Future value
        /// </param>
        /// <param name="when">
        /// When payments are due (‘begin’ (1) or ‘end’ (0))
        /// </param>
        public static void ppmt(NDarray rate, NDarray per, NDarray nper, NDarray pv, NDarray fv = null, string @when = "end")
            => NumPy.Instance.ppmt(rate, per, nper, pv, fv:fv, @when:@when);
        
        /// <summary>
        /// Compute the interest portion of a payment.
        /// 
        /// Notes
        /// 
        /// The total payment is made up of payment against principal plus interest.
        /// 
        /// pmt = ppmt + ipmt
        /// </summary>
        /// <param name="rate">
        /// Rate of interest as decimal (not per cent) per period
        /// </param>
        /// <param name="per">
        /// Interest paid against the loan changes during the life or the loan.
        /// The per is the payment period to calculate the interest amount.
        /// </param>
        /// <param name="nper">
        /// Number of compounding periods
        /// </param>
        /// <param name="pv">
        /// Present value
        /// </param>
        /// <param name="fv">
        /// Future value
        /// </param>
        /// <param name="when">
        /// When payments are due (‘begin’ (1) or ‘end’ (0)).
        /// Defaults to {‘end’, 0}.
        /// </param>
        /// <returns>
        /// Interest portion of payment.  If all input is scalar, returns a scalar
        /// float.  If any input is array_like, returns interest payment for each
        /// input element. If multiple inputs are array_like, they all must have
        /// the same shape.
        /// </returns>
        public static NDarray ipmt(NDarray rate, NDarray per, NDarray nper, NDarray pv, NDarray fv = null, string @when = "end")
            => NumPy.Instance.ipmt(rate, per, nper, pv, fv:fv, @when:@when);
        
        /// <summary>
        /// Return the Internal Rate of Return (IRR).
        /// 
        /// This is the “average” periodically compounded rate of return
        /// that gives a net present value of 0.0; for a more complete explanation,
        /// see Notes below.
        /// 
        /// decimal.Decimal type is not supported.
        /// 
        /// Notes
        /// 
        /// The IRR is perhaps best understood through an example (illustrated
        /// using np.irr in the Examples section below).  Suppose one invests 100
        /// units and then makes the following withdrawals at regular (fixed)
        /// intervals: 39, 59, 55, 20.  Assuming the ending value is 0, one’s 100
        /// unit investment yields 173 units; however, due to the combination of
        /// compounding and the periodic withdrawals, the “average” rate of return
        /// is neither simply 0.73/4 nor (1.73)^0.25-1.  Rather, it is the solution
        /// (for ) of the equation:
        /// 
        /// In general, for values ,
        /// irr is the solution of the equation: [G]
        /// 
        /// References
        /// </summary>
        /// <param name="values">
        /// Input cash flows per time period.  By convention, net “deposits”
        /// are negative and net “withdrawals” are positive.  Thus, for
        /// example, at least the first element of values, which represents
        /// the initial investment, will typically be negative.
        /// </param>
        /// <returns>
        /// Internal Rate of Return for periodic input values.
        /// </returns>
        public static float irr(NDarray values)
            => NumPy.Instance.irr(values);
        
        /// <summary>
        /// Modified internal rate of return.
        /// </summary>
        /// <param name="values">
        /// Cash flows (must contain at least one positive and one negative
        /// value) or nan is returned.  The first value is considered a sunk
        /// cost at time zero.
        /// </param>
        /// <param name="finance_rate">
        /// Interest rate paid on the cash flows
        /// </param>
        /// <param name="reinvest_rate">
        /// Interest rate received on the cash flows upon reinvestment
        /// </param>
        /// <returns>
        /// Modified internal rate of return
        /// </returns>
        public static float mirr(NDarray values, ValueType finance_rate, ValueType reinvest_rate)
            => NumPy.Instance.mirr(values, finance_rate, reinvest_rate);
        
        /// <summary>
        /// Compute the number of periodic payments.
        /// 
        /// decimal.Decimal type is not supported.
        /// 
        /// Notes
        /// 
        /// The number of periods nper is computed by solving the equation:
        /// 
        /// but if rate = 0 then:
        /// </summary>
        /// <param name="rate">
        /// Rate of interest (per period)
        /// </param>
        /// <param name="pmt">
        /// Payment
        /// </param>
        /// <param name="pv">
        /// Present value
        /// </param>
        /// <param name="fv">
        /// Future value
        /// </param>
        /// <param name="when">
        /// When payments are due (‘begin’ (1) or ‘end’ (0))
        /// </param>
        public static void nper(NDarray rate, NDarray pmt, NDarray pv, NDarray fv = null, string @when = "end")
            => NumPy.Instance.nper(rate, pmt, pv, fv:fv, @when:@when);
        
        /// <summary>
        /// Compute the rate of interest per period.
        /// 
        /// Notes
        /// 
        /// The rate of interest is computed by iteratively solving the
        /// (non-linear) equation:
        /// 
        /// for rate.
        /// 
        /// References
        /// 
        /// Wheeler, D. A., E. Rathke, and R. Weir (Eds.) (2009, May). Open Document
        /// Format for Office Applications (OpenDocument)v1.2, Part 2: Recalculated
        /// Formula (OpenFormula) Format - Annotated Version, Pre-Draft 12.
        /// Organization for the Advancement of Structured Information Standards
        /// (OASIS). Billerica, MA, USA. [ODT Document]. Available:
        /// http://www.oasis-open.org/committees/documents.php?wg_abbrev=office-formula
        /// OpenDocument-formula-20090508.odt
        /// </summary>
        /// <param name="nper">
        /// Number of compounding periods
        /// </param>
        /// <param name="pmt">
        /// Payment
        /// </param>
        /// <param name="pv">
        /// Present value
        /// </param>
        /// <param name="fv">
        /// Future value
        /// </param>
        /// <param name="when">
        /// When payments are due (‘begin’ (1) or ‘end’ (0))
        /// </param>
        /// <param name="guess">
        /// Starting guess for solving the rate of interest, default 0.1
        /// </param>
        /// <param name="tol">
        /// Required tolerance for the solution, default 1e-6
        /// </param>
        /// <param name="maxiter">
        /// Maximum iterations in finding the solution
        /// </param>
        public static void rate(NDarray nper, NDarray pmt, NDarray pv, NDarray fv, string @when = "end", double? guess = null, double? tol = null, int? maxiter = 100)
            => NumPy.Instance.rate(nper, pmt, pv, fv, @when:@when, guess:guess, tol:tol, maxiter:maxiter);
        
        
    }
}
