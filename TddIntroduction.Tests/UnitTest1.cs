﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddIntroduction.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void When_15_Expect_Fuzzbuzz()
        {
            int i = 15;

            FizzBuzz fb = new FizzBuzz();

            string x = fb.Query(i);
            Assert.AreEqual(x, "FizzBuzz");
        }

        [TestMethod]
        public void When_Dvidable_By_15_Expect_Fuzzbuzz()
        {
            int i = 15;

            FizzBuzz fb = new FizzBuzz();

            string x = fb.Query(i);
            Assert.AreEqual(x, "FizzBuzz");
        }

        [TestMethod]
        public void When_Not_3_And_Not_5_Return_Number()
        {
            int i = 4;

            FizzBuzz fb = new FizzBuzz();

            string x = fb.Query(i);
            Assert.AreEqual(x, i.ToString());
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
        public void When_Divideble_By_5_Expect_Buzz()
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

        [TestMethod]
        public void When_Dvidable_By_i3_Expect_Fizz()
        {
            int i = 6;

            FizzBuzz fb = new FizzBuzz();

            string x = fb.Query(i);
            Assert.AreEqual(x, "Fizz");
        }
    }

    public class FizzBuzz
    {
        public string Query(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                return "FizzBuzz";
            if (i % 3 == 0)
                return "Fizz";
            if (i % 5 == 0)
                return "Buzz";
            if (i != 3 && i != 5)
                return i.ToString();
            return "Buh";
        }
    }
}
