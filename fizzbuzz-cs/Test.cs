using System;
using NUnit.Framework;
using fizzbuzz_csharp;

namespace fizzbuzztest_csharp
{
    [TestFixture()]
    public class FizzbuzzTest
    {
        [Test()]
        public void Play_Returns_Fizz()
        {
            // arrange
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            int c = 9;
            string expected = "Fizz";

            // act
            string actual = fizzbuzz.Play(c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Play_Returns_FizzBuzz()
        {
            // arrange
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            int d = 15;
            string expected = "FizzBuzz";

            // act
            string actual = fizzbuzz.Play(d);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Play_Returns_Buzz()
        {
            // arrange
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            int e = 10;
            string expected = "Buzz";

            // act
            string actual = fizzbuzz.Play(e);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}


