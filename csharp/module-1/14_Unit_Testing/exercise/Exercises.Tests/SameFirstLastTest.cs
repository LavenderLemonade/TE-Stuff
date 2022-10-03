using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    internal class SameFirstLastTest
    {
        //IsItTheSame([1, 2, 3]) → false
        //IsItTheSame([1, 2, 3, 1]) → true
        //IsItTheSame([1, 2, 1]) → true

        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, false)]
        [DataRow(new int[] { 1, 2, 3,1 }, true)]
        [DataRow(new int[] { 1, 2, 1 }, true)]

        [TestMethod]

        public void IsItTheSame(int[] nums, bool expectedResult)
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            bool result = sameFirstLast.IsItTheSame(nums);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
