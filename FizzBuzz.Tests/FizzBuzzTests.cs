using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;


namespace FizzBuzz.Tests
{
    
    [TestClass]
    public class FizzBuzzTests
    {
        public FizzBuzzTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

       
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
       
        FizzBuzzlogic objFizzBuzz = new FizzBuzzlogic();

        [TestMethod]
        public void ComputeFizzForMultipleOfThree()
        {
            Assert.IsTrue(objFizzBuzz.GetFizzBuzz(3).Contains("Fizz"));
        }

        [TestMethod]
        public void ComputeBuzzForMultipleOfFive()
        {
            Assert.IsTrue(objFizzBuzz.GetFizzBuzz(5).Contains("Buzz"));
        }

        [TestMethod]
        public void ComputeFizzBuzzForMultipleOfFiveAndThree()
        {
            Assert.IsTrue(objFizzBuzz.GetFizzBuzz(300).Contains("FizzBuzz"));
        }

        [TestMethod]
        public void DisplayValueForNonMultipleInput()
        {
            Assert.IsTrue(objFizzBuzz.GetFizzBuzz(1).Contains("1"));
        }
    }
}
