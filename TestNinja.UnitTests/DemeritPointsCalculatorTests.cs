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
    class DemeritPointsCalculatorTests
    {

        [Test]
        [TestCase(-1)]
        [TestCase(303)]
        public void CalculateDemeritPoints_SpeedLessThan0OrGreaterThan300_ThrowsOutOfRangeException(int a)
        {
            var calculator = new DemeritPointsCalculator(); 
            Assert.That(() => calculator.CalculateDemeritPoints(a),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }


        //[Test]
        //public void CalculateDemeritPoints_SpeedLessThan0_ThrowsOutOfRangeException()
        //{
        //    var calculator = new DemeritPointsCalculator();

        //    //calculator.CalculateDemeritPoints(-1)

        //    Assert.That(() => calculator.CalculateDemeritPoints(-1),
        //        Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        //}

        //[Test]
        //public void CalculateDemeritPoints_SpeedGreaterThan300_ThrowsOutOfRangeException()
        //{
        //    var calculator = new DemeritPointsCalculator();

        //    //calculator.CalculateDemeritPoints(-1)

        //    Assert.That(() => calculator.CalculateDemeritPoints(301),
        //        Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        //}


        [Test]
        [TestCase(63,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(300,47)]
        [TestCase(80,3)]
        [TestCase(65,0)]
        public void CalculateDemeritPoints_(int speed, int expected)
        {
            var calculator = new DemeritPointsCalculator();
            var result = calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expected));
        }
    }

}
