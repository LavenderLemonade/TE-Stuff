using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class StringExercisesTests
    {
        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        [TestMethod]

        public void MakeAbbaTest()
        {
            //Arrange 

            StringExercises stringExercises = new StringExercises();

            string a = "yo";
            string b = "hey";

            //Act

            string c = stringExercises.MakeAbba(a, b);
            //Assert
            string whatIWant = a + b + b + a;
            Assert.AreEqual(whatIWant, c);

            
        }

        [TestMethod]

        public void MakeAbbaTestKnownFailure()
        {
            //trying this again I guess 
            StringExercises otherStringExercises = new StringExercises();
            string d = "me";
            string e = "gusta";
            string secondResult = otherStringExercises.MakeAbba(d, e);
            string whatWeWant = d + e + e + d;

            Assert.AreEqual(whatWeWant, secondResult, "You might've swapped stuff my guy.");
        }

    }
}