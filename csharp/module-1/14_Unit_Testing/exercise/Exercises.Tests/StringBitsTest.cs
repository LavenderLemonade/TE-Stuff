using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        //GetBits("Hello") → "Hlo"
        //GetBits("Hi") → "H"
        //GetBits("Heeololeo") → "Hello"

        [DataTestMethod]
        [DataRow("Hello", "Hlo")]
        [DataRow("Hi", "H")]
        [DataRow("Heeololeo", "Hello")]

        [TestMethod]

        public void GetBits(string str, string expectedResults)
        {
            StringBits stringBits = new StringBits();
            string result = stringBits.GetBits(str);
            Assert.AreEqual(expectedResults, result);
        }
    }
}
