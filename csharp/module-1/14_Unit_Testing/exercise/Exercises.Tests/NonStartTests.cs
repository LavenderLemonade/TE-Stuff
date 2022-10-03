using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        //GetPartialString("Hello", "There") → "ellohere"
        //GetPartialString("java", "code") → "avaode"
        //GetPartialString("shotl", "java") → "hotlava"

        [DataTestMethod]
        [DataRow("Hello", "There", "ellohere")]
        [DataRow("java", "code", "avaode")]
        [DataRow("shotl", "java", "hotlava")]

        [TestMethod]

        public void GetPartialString(string a, string b, string expectedResult)
        {
            NonStart nonStart = new NonStart();
            string result = nonStart.GetPartialString(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
