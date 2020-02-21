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
        /// when all the dimensions are forming a valid triangle and are equal, i.e. it should return equilateral triangle
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
        /// when all the dimensions are forming a triangle and are different, i.e. it should return scalene triangle
        /// Input - 9,7,8
        /// Output - "Scalene Triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_Input978_OutputScalene()
        {
            Assert.AreEqual("Scalene Triangle", TriangleSolver.Analyze(9,7,8));
        }

        /// <summary>
        /// Test Case 2.0
        /// Description - Test case to pass dimensions and check if the method is working properly
        /// when all the dimensions are forming a triangle and two of the sides are equal, i.e. it should return isosceles triangle
        /// Input - 2,2,3
        /// Output - "Isosceles  Triangle"
        /// </summary>
        [TestCase]
        public void TestAnalyze_Input224_OutputScalene()
        {
            Assert.AreEqual("Isosceles Triangle", TriangleSolver.Analyze(2,2,3));
        }
    }
}
