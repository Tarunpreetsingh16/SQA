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
        [TestCase]
        public void TestAnalyze()
        {
            Assert.AreEqual("Equilateral Triangle", TriangleSolver.Analyze(2,2,2));
        }
    }
}
