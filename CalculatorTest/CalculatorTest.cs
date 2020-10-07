using NUnit.Framework;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Plus_When6and2_Then8()
        {
            Assert.AreEqual(8, Calculator.Calculator.Plus(6,2));
        }

        [Test]
        public void Minus_When6and2_Then4()
        {
            Assert.AreEqual(4, Calculator.Calculator.Minus(6,2));
        }
    }
}