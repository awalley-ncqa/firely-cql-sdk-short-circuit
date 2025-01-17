using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summaray>
		///define "BetweenIntTrue":
		///	( 4 between 2 and 6 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void BetweenIntTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "BetweenIntTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqTrueTrue":
		///	( true = true ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqTrueTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqTrueTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqTrueFalse":
		///	( true = false ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqTrueFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqTrueFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqFalseFalse":
		///	( false = false ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqFalseFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqFalseFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqFalseTrue":
		///	( false = true ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqFalseTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqFalseTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqNullNull":
		///	( null = null ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqNullNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqTrueNull":
		///	( true = null ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqTrueNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqTrueNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqNullTrue":
		///	( null = true ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqNullTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqNullTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqInt1Int1":
		///	( 1 = 1 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqInt1Int1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqInt1Int1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqInt1Int2":
		///	( 1 = 2 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqInt1Int2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqInt1Int2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqStringAStringA":
		///	( 'a' = 'a' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqStringAStringA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqStringAStringA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqStringAStringB":
		///	( 'a' = 'b' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqStringAStringB_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqStringAStringB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqFloat1Float1":
		///	( 1.0 = 1.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqFloat1Float1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqFloat1Float1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqFloat1Float2":
		///	( 1.0 = 2.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqFloat1Float2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqFloat1Float2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqFloat1Int1":
		///	( 1.0 = 1 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqFloat1Int1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqFloat1Int1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleEqFloat1Int2":
		///	( 1.0 = 2 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleEqFloat1Int2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleEqFloat1Int2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "QuantityEqCM1CM1":
		///	( 1'cm' = 1'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void QuantityEqCM1CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "QuantityEqCM1CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "QuantityEqCM1M01":
        ///	( 1'cm' = 0.01'm' ) = true
        /// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void QuantityEqCM1M01_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "QuantityEqCM1M01"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "QuantityEqDiffPrecision":
		///	( 2.0'cm' = 2.00'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void QuantityEqDiffPrecision_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "QuantityEqDiffPrecision"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleEqJohnJohn":
		///	( Tuple { Id : 1, Name : 'John' } = Tuple { Id : 1, Name : 'John' } ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleEqJohnJohn_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleEqJohnJohn"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleEqJohnJane":
		///	( Tuple { Id : 1, Name : 'John' } = Tuple { Id : 2, Name : 'Jane' } ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleEqJohnJane_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleEqJohnJane"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleEqJohn1John2":
		///	( Tuple { Id : 1, Name : 'John' } = Tuple { Id : 2, Name : 'John' } ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleEqJohn1John2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleEqJohn1John2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleEqDateTimeTrue":
		///	( Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) } = Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) } ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleEqDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleEqDateTimeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleEqDateTimeFalse":
		///	( Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) } = Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 5, 0, 0, 0) } ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleEqDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleEqDateTimeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleEqTimeTrue":
		///	( Tuple { timeId: 55, TheTime: @T05:15:15.541 } = Tuple { timeId: 55, TheTime: @T05:15:15.541 } ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleEqTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleEqTimeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleEqTimeFalse":
		///	( Tuple { timeId: 55, TheTime: @T05:15:15.541 } = Tuple { timeId: 55, TheTime: @T05:15:15.540 } ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleEqTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleEqTimeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeEqTodayToday":
		///	( Today() = Today() ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeEqTodayToday_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeEqTodayToday"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeEqTodayYesterday":
		///	( Today() = Today() - 1 days ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeEqTodayYesterday_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeEqTodayYesterday"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeEqJanJan":
		///	( DateTime(2014, 1, 5, 5, 0, 0, 0, 0) = DateTime(2014, 1, 5, 5, 0, 0, 0, 0) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeEqJanJan_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeEqJanJan"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeEqJanJuly":
		///	( DateTime(2014, 1, 5, 5, 0, 0, 0, 0) = DateTime(2014, 7, 5, 5, 0, 0, 0, 0) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeEqJanJuly_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeEqJanJuly"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeEqNull":
		///	( DateTime(null) = DateTime(null) ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeEqNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeEqNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "DateTimeUTC":
		///	( @2014-01-25T14:30:14.559+01:00 = @2014-01-25T14:30:14.559+01:00 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeUTC_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeUTC"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeEq10A10A":
		///	( @T10:00:00.000 = @T10:00:00.000 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeEq10A10A_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeEq10A10A"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeEq10A10P":
		///	( @T10:00:00.000 = @T22:00:00.000 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeEq10A10P_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeEq10A10P"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterZZ":
		///	( 0 > 0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterZZ_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterZZ"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterZ1":
		///	( 0 > 1 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterZ1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterZ1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterZNeg1":
		///	( 0 > -1 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterZNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterZNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterDecZZ":
		///	( 0.0 > 0.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterDecZZ_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterDecZZ"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterDecZ1":
		///	( 0.0 > 1.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterDecZ1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterDecZ1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterDecZNeg1":
		///	( 0.0 > -1.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterDecZNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterDecZNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterCM0CM0":
		///	( 0'cm' > 0'cm' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterCM0CM0_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterCM0CM0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterCM0CM1":
		///	( 0'cm' > 1'cm' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterCM0CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterCM0CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterCM0NegCM1":
		///	( 0'cm' > -1'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterCM0NegCM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterCM0NegCM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterM1CM1":
		///	( 1'm' > 1'cm' ) = true
		/// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterM1CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterM1CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "GreaterM1CM10":
        ///	( 1'm' > 10'cm' ) = true
        /// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterM1CM10_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterM1CM10"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterAA":
		///	( 'a' > 'a' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterAA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterAB":
		///	( 'a' > 'b' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterAB_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterAB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterBA":
		///	( 'b' > 'a' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterBA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterBA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterAThanAA":
		///	( 'a' > 'aa' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterAThanAA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterAThanAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterAAThanA":
		///	( 'aa' > 'a' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterAAThanA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterAAThanA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterJackJill":
		///	( 'Jack' > 'Jill' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterJackJill_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterJackJill"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeGreaterTrue":
		///	( DateTime(2012, 2, 12) > DateTime(2012, 2, 10) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeGreaterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeGreaterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeGreaterFalse":
		///	( DateTime(2012, 2, 12) > DateTime(2012, 2, 13) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeGreaterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeGreaterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeGreaterTrue":
		///	( @T10:00:00.001 > @T10:00:00.000 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeGreaterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeGreaterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeGreaterFalse":
		///	( @T10:00:00.000 > @T10:00:00.001 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeGreaterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeGreaterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyGreaterNull":
		///	( DateTime(2014) > DateTime(2014, 2, 15) ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyGreaterNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyGreaterNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyGreaterTrue":
		///	( DateTime(2015) > DateTime(2014, 2, 15) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyGreaterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyGreaterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyGreaterFalse":
		///	( DateTime(2013) > DateTime(2014, 2, 15) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyGreaterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyGreaterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualZZ":
		///	( 0 >= 0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualZZ_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualZZ"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualZ1":
		///	( 0 >= 1 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualZ1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualZ1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualZNeg1":
		///	( 0 >= -1 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualZNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualZNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualDecZZ":
		///	( 0.0 >= 0.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualDecZZ_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualDecZZ"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualDecZ1":
		///	( 0.0 >= 1.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualDecZ1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualDecZ1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualDecZNeg1":
		///	( 0.0 >= -1.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualDecZNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualDecZNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualCM0CM0":
		///	( 0'cm' >= 0'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualCM0CM0_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualCM0CM0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualCM0CM1":
		///	( 0'cm' >= 1'cm' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualCM0CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualCM0CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualCM0NegCM1":
		///	( 0'cm' >= -1'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualCM0NegCM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualCM0NegCM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualM1CM1":
		///	( 1'm' >= 1'cm' ) = true
		/// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualM1CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualM1CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "GreaterOrEqualM1CM10":
        ///	( 1'm' >= 10'cm' ) = true
        /// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualM1CM10_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualM1CM10"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualAA":
		///	( 'a' >= 'a' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualAA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualAB":
		///	( 'a' >= 'b' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualAB_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualAB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualBA":
		///	( 'b' >= 'a' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualBA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualBA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualAThanAA":
		///	( 'a' >= 'aa' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualAThanAA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualAThanAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualAAThanA":
		///	( 'aa' >= 'a' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualAAThanA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualAAThanA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "GreaterOrEqualJackJill":
		///	( 'Jack' >= 'Jill' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void GreaterOrEqualJackJill_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "GreaterOrEqualJackJill"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeGreaterEqTrue":
		///	( DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 10, 0, 0, 0, 0) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeGreaterEqTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeGreaterEqTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeGreaterEqTrue2":
		///	( DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 12, 0, 0, 0, 0) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeGreaterEqTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeGreaterEqTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeGreaterEqFalse":
		///	( DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 13, 0, 0, 0, 0) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeGreaterEqFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeGreaterEqFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeGreaterEqTrue":
		///	( @T10:00:00.001 >= @T10:00:00.000 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeGreaterEqTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeGreaterEqTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeGreaterEqTrue2":
		///	( @T10:00:00.000 >= @T10:00:00.000 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeGreaterEqTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeGreaterEqTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeGreaterEqFalse":
		///	( @T10:00:00.000 >= @T10:00:00.001 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeGreaterEqFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeGreaterEqFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyGreaterEqualNull":
		///	( DateTime(2014) >= DateTime(2014, 2, 15) ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyGreaterEqualNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyGreaterEqualNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyGreaterEqualTrue":
		///	( DateTime(2015) >= DateTime(2014, 2, 15) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyGreaterEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyGreaterEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyGreaterEqualFalse":
		///	( DateTime(2013) >= DateTime(2014, 2, 15) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyGreaterEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyGreaterEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessZZ":
		///	( 0 < 0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessZZ_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessZZ"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessZ1":
		///	( 0 < 1 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessZ1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessZ1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessZNeg1":
		///	( 0 < -1 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessZNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessZNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessDecZZ":
		///	( 0.0 < 0.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessDecZZ_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessDecZZ"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessDecZ1":
		///	( 0.0 < 1.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessDecZ1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessDecZ1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessDecZNeg1":
		///	( 0.0 < -1.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessDecZNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessDecZNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessCM0CM0":
		///	( 0'cm' < 0'cm' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessCM0CM0_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessCM0CM0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessCM0CM1":
		///	( 0'cm' < 1'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessCM0CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessCM0CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessCM0NegCM1":
		///	( 0'cm' < -1'cm' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessCM0NegCM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessCM0NegCM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "LessM1CM1":
        ///	( 1'm' < 1'cm' ) = false
        /// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessM1CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessM1CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "LessM1CM10":
        ///	( 1'm' < 10'cm' ) = false
        /// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessM1CM10_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessM1CM10"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessAA":
		///	( 'a' < 'a' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessAA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessAB":
		///	( 'a' < 'b' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessAB_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessAB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessBA":
		///	( 'b' < 'a' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessBA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessBA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessAThanAA":
		///	( 'a' < 'aa' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessAThanAA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessAThanAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessAAThanA":
		///	( 'aa' < 'a' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessAAThanA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessAAThanA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessJackJill":
		///	( 'Jack' < 'Jill' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessJackJill_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessJackJill"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeLessTrue":
		///	( DateTime(2012, 2, 9) < DateTime(2012, 2, 10) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeLessTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeLessTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeLessFalse":
		///	( DateTime(2012, 2, 14) < DateTime(2012, 2, 13) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeLessFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeLessFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeLessTrue":
		///	( @T10:00:00.001 < @T10:00:00.002 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeLessTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeLessTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeLessFalse":
		///	( @T10:10:00.000 < @T10:00:00.001 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeLessFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeLessFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyLessNull":
		///	( DateTime(2014) < DateTime(2014, 2, 15) ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyLessNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyLessNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyLessTrue":
		///	( DateTime(2013) < DateTime(2014, 2, 15) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyLessTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyLessTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyLessFalse":
		///	( DateTime(2015) < DateTime(2014, 2, 15) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyLessFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyLessFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualZZ":
		///	( 0 <= 0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualZZ_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualZZ"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualZ1":
		///	( 0 <= 1 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualZ1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualZ1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualZNeg1":
		///	( 0 <= -1 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualZNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualZNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualDecZZ":
		///	( 0.0 <= 0.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualDecZZ_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualDecZZ"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualDecZ1":
		///	( 0.0 <= 1.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualDecZ1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualDecZ1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualDecZNeg1":
		///	( 0.0 <= -1.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualDecZNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualDecZNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualCM0CM0":
		///	( 0'cm' <= 0'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualCM0CM0_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualCM0CM0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualCM0CM1":
		///	( 0'cm' <= 1'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualCM0CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualCM0CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualCM0NegCM1":
		///	( 0'cm' <= -1'cm' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualCM0NegCM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualCM0NegCM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "LessOrEqualM1CM1":
        ///	( 1'm' <= 1'cm' ) = false
        /// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualM1CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualM1CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualM1CM10":
		///	( 1'm' <= 10'cm' ) = false
		/// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualM1CM10_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualM1CM10"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualAA":
		///	( 'a' <= 'a' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualAA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualAB":
		///	( 'a' <= 'b' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualAB_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualAB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualBA":
		///	( 'b' <= 'a' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualBA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualBA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualAThanAA":
		///	( 'a' <= 'aa' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualAThanAA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualAThanAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualAAThanA":
		///	( 'aa' <= 'a' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualAAThanA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualAAThanA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LessOrEqualJackJill":
		///	( 'Jack' <= 'Jill' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void LessOrEqualJackJill_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "LessOrEqualJackJill"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeLessEqTrue":
		///	( DateTime(2012, 2, 9, 0, 0, 0, 0) <= DateTime(2012, 2, 10, 0, 0, 0, 0) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeLessEqTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeLessEqTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeLessEqTrue2":
		///	( DateTime(2012, 2, 12, 0, 0, 0, 0) <= DateTime(2012, 2, 12, 0, 0, 0, 0) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeLessEqTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeLessEqTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeLessEqFalse":
		///	( DateTime(2012, 2, 12, 1, 0, 0, 0) <= DateTime(2012, 2, 12, 0, 0, 0, 0) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeLessEqFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeLessEqFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeLessEqTrue":
		///	( @T10:00:00.001 <= @T10:00:00.002 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeLessEqTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeLessEqTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeLessEqTrue2":
		///	( @T10:00:00.000 <= @T10:00:00.000 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeLessEqTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeLessEqTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeLessEqFalse":
		///	( @T10:00:00.002 <= @T10:00:00.001 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeLessEqFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeLessEqFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyLessEqualNull":
		///	( DateTime(2014) <= DateTime(2014, 2, 15) ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyLessEqualNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyLessEqualNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyLessEqualTrue":
		///	( DateTime(2013) <= DateTime(2014, 2, 15) ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyLessEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyLessEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UncertaintyLessEqualFalse":
		///	( DateTime(2015) <= DateTime(2014, 2, 15) ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void UncertaintyLessEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "UncertaintyLessEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTrueTrue":
		///	( true ~ true ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTrueTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTrueTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTrueFalse":
		///	( true ~ false ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTrueFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTrueFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivFalseFalse":
		///	( false ~ false ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivFalseFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivFalseFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivFalseTrue":
		///	( false ~ true ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivFalseTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivFalseTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivNullNull":
		///	( null ~ null ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivNullNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTrueNull":
		///	( true ~ null ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTrueNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTrueNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivNullTrue":
		///	( null ~ true ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivNullTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivNullTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivInt1Int1":
		///	( 1 ~ 1 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivInt1Int1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivInt1Int1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivInt1Int2":
		///	( 1 ~ 2 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivInt1Int2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivInt1Int2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivStringAStringA":
		///	( 'a' ~ 'a' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivStringAStringA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivStringAStringA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivStringAStringB":
		///	( 'a' ~ 'b' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivStringAStringB_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivStringAStringB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivFloat1Float1":
		///	( 1.0 ~ 1.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivFloat1Float1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivFloat1Float1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivFloat1Float2":
		///	( 1.0 ~ 2.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivFloat1Float2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivFloat1Float2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivFloat1Int1":
		///	( 1.0 ~ 1 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivFloat1Int1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivFloat1Int1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivFloat1Int2":
		///	( 1.0 ~ 2 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivFloat1Int2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivFloat1Int2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivEqCM1CM1":
		///	( 1'cm' ~ 1'cm' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivEqCM1CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivEqCM1CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "EquivEqCM1M01":
        ///	( 1'cm' ~ 0.01'm' ) = true
        /// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivEqCM1M01_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivEqCM1M01"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTupleJohnJohn":
		///	( Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 1, Name : 'John' } ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTupleJohnJohn_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTupleJohnJohn"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTupleJohnJohnWithNulls":
		///	( Tuple { Id : 1, Name : 'John', Position: null } ~ Tuple { Id : 1, Name : 'John', Position: null } ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTupleJohnJohnWithNulls_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTupleJohnJohnWithNulls"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTupleJohnJane":
		///	( Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 2, Name : 'Jane' } ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTupleJohnJane_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTupleJohnJane"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTupleJohn1John2":
		///	( Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 2, Name : 'John' } ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTupleJohn1John2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTupleJohn1John2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivDateTimeTodayToday":
		///	( Today() ~ Today() ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivDateTimeTodayToday_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivDateTimeTodayToday"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivDateTimeTodayYesterday":
		///	( Today() ~ Today() - 1 days ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivDateTimeTodayYesterday_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivDateTimeTodayYesterday"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTime10A10A":
		///	( @T10:00:00.000 ~ @T10:00:00.000 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTime10A10A_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTime10A10A"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivTime10A10P":
		///	( @T10:00:00.000 ~ @T22:00:00.000 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void EquivTime10A10P_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "EquivTime10A10P"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqTrueTrue":
		///	( true != true ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqTrueTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqTrueTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqTrueFalse":
		///	( true != false ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqTrueFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqTrueFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqFalseFalse":
		///	( false != false ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqFalseFalse_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqFalseFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqFalseTrue":
		///	( false != true ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqFalseTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqFalseTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqNullNull":
		///	( null != null ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqNullNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqTrueNull":
		///	( true != null ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqTrueNull_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqTrueNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqNullTrue":
		///	( null != true ) = null
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqNullTrue_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqNullTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqInt1Int1":
		///	( 1 != 1 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqInt1Int1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqInt1Int1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqInt1Int2":
		///	( 1 != 2 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqInt1Int2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqInt1Int2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqStringAStringA":
		///	( 'a' != 'a' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqStringAStringA_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqStringAStringA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqStringAStringB":
		///	( 'a' != 'b' ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqStringAStringB_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqStringAStringB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqFloat1Float1":
		///	( 1.0 != 1.0 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqFloat1Float1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqFloat1Float1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqFloat1Float2":
		///	( 1.0 != 2.0 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqFloat1Float2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqFloat1Float2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqFloat1Int1":
		///	( 1.0 != 1 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqFloat1Int1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqFloat1Int1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SimpleNotEqFloat1Int2":
		///	( 1.0 != 2 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void SimpleNotEqFloat1Int2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "SimpleNotEqFloat1Int2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "QuantityNotEqCM1CM1":
		///	( 1'cm' != 1'cm' ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void QuantityNotEqCM1CM1_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "QuantityNotEqCM1CM1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "QuantityNotEqCM1M01":
        ///	( 1'cm' != 0.01'm' ) = false
        /// </summary>
        [Ignore(NotSupported)]
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void QuantityNotEqCM1M01_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "QuantityNotEqCM1M01"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleNotEqJohnJohn":
		///	( Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 1, Name : 'John' } ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleNotEqJohnJohn_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleNotEqJohnJohn"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleNotEqJohnJane":
		///	( Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 2, Name : 'Jane' } ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleNotEqJohnJane_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleNotEqJohnJane"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TupleNotEqJohn1John2":
		///	( Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 2, Name : 'John' } ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TupleNotEqJohn1John2_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TupleNotEqJohn1John2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeNotEqTodayToday":
		///	( Today() != Today() ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeNotEqTodayToday_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeNotEqTodayToday"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeNotEqTodayYesterday":
		///	( Today() != Today() - 1 days ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void DateTimeNotEqTodayYesterday_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "DateTimeNotEqTodayYesterday"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeNotEq10A10A":
		///	( @T10:00:00.000 != @T10:00:00.000 ) = false
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeNotEq10A10A_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeNotEq10A10A"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeNotEq10A10P":
		///	( @T10:00:00.000 != @T22:00:00.000 ) = true
		/// </summary>
        [TestCategory("CqlComparisonOperatorsTest")]
        [TestMethod]
        public void TimeNotEq10A10P_Test()
        {
            var lambda = LambdasByTestName["CqlComparisonOperatorsTest", "TimeNotEq10A10P"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
