using System;
using NUnit.Framework;
using fizzbuzz_csharp;

namespace fizzbuzztest_csharp
{
    [TestFixture()]
    public class FizzbuzzTest
    {
        [Test()]
        public void Play_Returns_Fizzbuzz_Fizz_Buzz()
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

    }
}


