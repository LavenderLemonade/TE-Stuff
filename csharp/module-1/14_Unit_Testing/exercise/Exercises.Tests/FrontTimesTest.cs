using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]

    

    //frontTimes("Chocolate", 2) → "ChoCho"
    //frontTimes("Chocolate", 3) → "ChoChoCho"
    //frontTimes("Abc", 3) → "AbcAbcAbc"

    public class FrontTimesTest
    {

        [DataTestMethod()]
        [DataRow("Chocolate", 2, "ChoCho")]
        [DataRow("Chocolate", 3, "ChoChoCho")]
        [DataRow("Abc", 3, "AbcAbcAbc")]

        [TestMethod()]

        public void GenerateString(string str, int n, string expectedResults)
        {
            FrontTimes frontTimes = new FrontTimes();
            string result2 = frontTimes.GenerateString(str, n);
            Assert.AreEqual(expectedResults, result2);
        }
    }
}
