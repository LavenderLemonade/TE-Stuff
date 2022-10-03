using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        //less20(18) → true
        //less20(19) → true
        //less20(20) → false
        [DataTestMethod]
        [DataRow(18,true)]
        [DataRow(19, true)]
        [DataRow(20, false)]

        [TestMethod]

        public void IsLessThanMultipleOf20(int n, bool expectedResult)
        {
            Less20 less20 = new Less20();

            bool result = less20.IsLessThanMultipleOf20(n);

            Assert.AreEqual(expectedResult, result);
        
        }
    }
}
