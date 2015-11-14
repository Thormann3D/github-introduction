using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddIntroduction.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void When_Not_3_And_Not_5_Return_Number()
        {
            int i = 4;

            FizzBuzz fb = new FizzBuzz();

            string x = fb.Query(i);
        }

        [TestMethod]
        public void When_5_Expect_Buzz()
        {
            int i = 5;

            FizzBuzz fb = new FizzBuzz();

            string x = fb.Query(i);
            Assert.AreEqual(x, "Buzz");
        }
        [TestMethod]
        public void When_3_Expect_Fizz()
        {
            int i = 3;

            FizzBuzz fb = new FizzBuzz();

            string x = fb.Query(i);
            Assert.AreEqual(x, "Fizz");
        }
    }

    internal class FizzBuzz
    {
        internal string Query(int i)
        {
            if (i == 3)
                return "Fizz";
            if (i == 5)
                return "Buzz";
            return "Buh";
        }
    }
}
