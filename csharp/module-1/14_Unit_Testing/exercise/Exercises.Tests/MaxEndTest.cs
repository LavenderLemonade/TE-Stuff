using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEndTest
    {

        //MakeArray([1, 2, 3]) → [3, 3, 3]
        //MakeArray([11, 5, 9]) → [11, 11, 11]
        //MakeArray([2, 11, 3]) → [3, 3, 3]

        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 })]
        [DataRow(new int[] { 11, 5, 9 }, new int[] { 11, 11, 11 })]
        [DataRow(new int[] { 2, 11, 3 }, new int[] { 3, 3, 3 })]

        [TestMethod]

        public void MakeArray(int[] nums, int[] expectedResult)
        {
            MaxEnd3 maxy = new MaxEnd3();
            int[] result = maxy.MakeArray(nums);
            CollectionAssert.AreEqual(expectedResult, result);

        }





    }
}
