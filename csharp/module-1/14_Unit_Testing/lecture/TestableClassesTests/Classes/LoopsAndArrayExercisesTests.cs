using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object

        [TestMethod]
        public void MiddleWayTest()
        {
            //Arrange
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();
            int[] firstInput = { 1, 2, 3 };
            int[] secondInput = { 4, 5, 6 };
            //Act
            int[] result = loopsAndArrayExercises.MiddleWay(firstInput, secondInput);
            //Assert
            int[] expectedResult = { 2, 5 };

            CollectionAssert.AreEqual(expectedResult, result);

            //let's do another one 
            int[] thirdInput = { 7, 7, 7 };
            int[] fourthInput = { 7, 8, 0 };

            int[] seemedResult = loopsAndArrayExercises.MiddleWay(thirdInput, fourthInput);

            int[] resultWeExpect = { 7, 8 };

            CollectionAssert.AreEqual(resultWeExpect, seemedResult);

            //let's make sure they're not empty 

            CollectionAssert.AllItemsAreNotNull(seemedResult);
        }


    }
}