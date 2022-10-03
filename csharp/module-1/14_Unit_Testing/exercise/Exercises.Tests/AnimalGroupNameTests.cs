using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]

    public class AnimalGroupNameTests
    {
        [DataTestMethod]
        [DataRow("rhino", "Crash")]
        [DataRow("giraffe", "Tower")]
        [DataRow("elephant", "Herd")]
        [DataRow("lion", "Pride")]
        [DataRow("crow", "Murder")]
        [DataRow("pigeon", "Kit")]
        [DataRow("flamingo", "Pat")]
        [DataRow("deer", "Herd")]
        [DataRow("dog", "Pack")]
        [DataRow("crocodile", "Float")]


[TestMethod()]

        public void GetHerdTest(string animalName, string expectedOutput)
        {
            //Arrange
            AnimalGroupName animalia = new AnimalGroupName();
            //Act
            string output = animalia.GetHerd(animalName);
            //Assert
            Assert.AreEqual(expectedOutput, output);
            
        }












    }
}
