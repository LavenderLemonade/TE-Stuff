using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class AnimalGroupNameTest
    {
        [TestMethod]

        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "Herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * GetHerd("giraffe") → "Tower"
         * GetHerd("") -> "unknown"
         * GetHerd("walrus") -> "unknown"
         * GetHerd("Rhino") -> "Crash"
         * GetHerd("rhino") -> "Crash"
         * GetHerd("elephants") -> "unknown"
         *
         */

        public void GetHerdTest()
        {
            //Arrange 

            //Act

            //Assert
        }
    }
}
