using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Tests
{
    [TestFixture]
    class TriangleSolverTest
    {
        /// <summary>
        /// Test Case 1.0
        /// Description - Test case to pass dimensions and check if the method is working properly
        /// when the dimensions are forming a valid triangle and are equal, i.e. it should return equilateral triangle
        /// Input - 2,2,2
        /// Output - "Equilateral Triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_Input222_OutputEqui()
        {
            Assert.AreEqual("Equilateral Triangle", TriangleSolver.Analyze(2,2,2));
        }
        
        /// <summary>
        /// Test Case 2.0
        /// Description - Test case to pass dimensions and check if the method is working properly
        /// when the dimensions are forming a triangle and are different, i.e. it should return scalene triangle
        /// Input - 9,7,8
        /// Output - "Scalene Triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_Input978_OutputScalene()
        {
            Assert.AreEqual("Scalene Triangle", TriangleSolver.Analyze(9,7,8));
        }

        /// <summary>
        /// Test Case 3.0
        /// Description - Test case to pass dimensions and check if the method is working properly
        /// when the dimensions are forming a triangle and two of the sides are equal, i.e. it should return isosceles triangle
        /// Input - 2,2,3
        /// Output - "Isosceles  Triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_Input224_OutputScalene()
        {
            Assert.AreEqual("Isosceles Triangle", TriangleSolver.Analyze(2,2,3));
        }

        /// <summary>
        /// Test Case 4.0
        /// Description - Test case to pass dimensions and check if the method is working properly
        /// when the dimensions are not forming a triangle
        /// Input - 0,0,0
        /// Output - "Dimensions don't compose a triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_Input000_OutputInValid()
        {
            Assert.AreEqual("Dimensions don't compose a triangle", TriangleSolver.Analyze(0,0,0));
        }

        /// <summary>
        /// Test Case 5.0
        /// Description - Test case to pass negative dimensions and check if the method is working properly
        /// ,i.e. negative value cannot compose a triangle
        /// Input - -2,-2,-3
        /// Output - "Dimensions don't compose a triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_InputNeg223_OutputInValid()
        {
            Assert.AreEqual("Dimensions don't compose a triangle", TriangleSolver.Analyze(-2,-2,-3));
        }
        
        /// <summary>
        /// Test Case 6.0
        /// Description - Test case to pass one negative dimension and two positive with same magnitude 
        /// and check that it is not giving output as equilateral triangle, as a valid triangle 
        /// cannot comprise of a negative dimension
        /// Input - -2,2,2
        /// Output - "Dimensions don't compose a triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_InputNeg2_22_OutputInValid()
        {
            Assert.AreEqual("Dimensions don't compose a triangle", TriangleSolver.Analyze(-2,2,2));
        }
        
        /// <summary>
        /// Test Case 7.0
        /// Description - Test case to check that even if two of the sides are equal,
        /// it should not always return a isosceles triangle.
        /// First it needs to check that that the sides clear the conditions of forming 
        /// a triangle.
        /// Input - 2,2,4
        /// Output - "Dimensions don't compose a triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_Input224_OutputInValid()
        {
            Assert.AreEqual("Dimensions don't compose a triangle", TriangleSolver.Analyze(2,2,4));
        }
        
        /// <summary>
        /// Test Case 8.0
        /// Description - Test case to check that even if all the sides are different,
        /// it should not always return a scalene triangle.
        /// First it needs to check that that the sides clear the conditions of forming 
        /// a triangle.
        /// Input - 1,2,3
        /// Output - "Dimensions don't compose a triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_Input123_OutputInValid()
        {
            Assert.AreEqual("Dimensions don't compose a triangle", TriangleSolver.Analyze(1,2,3));
        }

    }
}
