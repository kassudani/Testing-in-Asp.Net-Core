using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {

        [Test]
        [TestCase(15,"FizzBuzz")]
        [TestCase(3,"Fizz")]
        [TestCase(5,"Buzz")]
        [TestCase(2,"2")]
        public void GetOutput_WhenCalled_ReturnsExpectedOutput(int a, string expected)
        {
            var result = FizzBuzz.GetOutput(a);
            Assert.That(result, Is.EqualTo(expected));
        }


        //[Test]
        //public void GetOutput_DivisibleBy3And5_ReturnsStringFizzBuzz()
        //{
        //    var result = FizzBuzz.GetOutput(15);

        //    Assert.That(result,Is.EqualTo("FizzBuzz"));
        //}

        //[Test]
        //public void GetOutput_DivisibleBy3_ReturnsStringFizz()
        //{
        //    var result = FizzBuzz.GetOutput(9);
        //    Assert.That(result, Is.EqualTo("Fizz"));
        //}

        //[Test]
        //public void GetOutput_DivisibleBy5_ReturnsStringBuzz()
        //{
        //    var result = FizzBuzz.GetOutput(5);
        //    Assert.That(result, Is.EqualTo("Buzz"));
        //}

        //[Test]
        //public void GetOutput_DivisibleByNone_ReturnsTheNumber()
        //{
        //    var result = FizzBuzz.GetOutput(2);
        //    Assert.That(result,Is.EqualTo("2"));
        //}
    }
}
