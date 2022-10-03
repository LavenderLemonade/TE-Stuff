using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        //GetLucky([0, 2, 4]) → true
        //GetLucky([1, 2, 3]) → false
        //GetLucky([1, 2, 4]) → false
        [DataTestMethod]
        [DataRow(new int[] {0,2,4}, true)]
        [DataRow(new int[] { 1, 2, 3 }, false)]
        [DataRow(new int[] { 1, 2, 4 }, false)]

        [TestMethod]

        public void GetLucky(int[] nums, bool expectedResult)
        {
            Lucky13 luckyBoi = new Lucky13();
            bool result = luckyBoi.GetLucky(nums);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
