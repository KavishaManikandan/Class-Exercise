using NUnit.Framework;
using DemoApp;
using System;

namespace DemoApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ReturnsCorrectSum()
        {
            Assert.AreEqual(8, _calculator.Add(5, 3));
        }

        [Test]
        public void Subtract_ReturnsCorrectDifference()
        {
            Assert.AreEqual(2, _calculator.Subtract(5, 3));
        }

        [Test]
        public void Multiply_ReturnsCorrectProduct()
        {
            Assert.AreEqual(15, _calculator.Multiply(5, 3));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
        }

        [Test]
        public void Divide_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(2, _calculator.Divide(10, 5));
        }
    }
}
