using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Math _math;

        //SetUp
        //TearDown: mostly used in integration testing

        [SetUp]
        public void SetUpMathInstance()
        {
            _math = new Math();
        }


        [Test]
        public void Add_WhenCalled_ReturnsAdditionOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }


        //instead of writing multiple test scenarios for a particular method we can make it general.
        //Here we'll use parameterized test method

        //public void Max_WhenFirstArgumentIsGreater_ReturnsFirstArgument()
        //{
        //    var result = _math.Max(3, 2);

        //    Assert.That(result, Is.EqualTo(3));
        //}

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnsGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        //[Test]
        //public void Max_WhenBothArgumentAreEqual_ReturnsSameArgument()
        //{
        //    var result = _math.Max(2, 2);

        //    Assert.That(result, Is.EqualTo(2));
        //}

        [Test]
        public void GetOddNumbers_LimitIsGreateerThanZero_ReturnsListOfOddNumbers()
        {
            var result = _math.GetOddNumbers(5);

            //too general
            //Assert.That(result, Is.Not.Empty);

            //checks whether the count is what we need
            //Assert.That(result.Count(), Is.EqualTo((3)));

            //more specific
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            //way more specific (elements with sequence)
            Assert.That(result, Is.EquivalentTo(new []{1,3,5}));
        }
    }
}
