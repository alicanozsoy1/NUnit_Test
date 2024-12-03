using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationLibrary.UnitTest
{
    internal class CalculatorParameterizedTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestCase(3, 5, 8)]
        [TestCase(-3, -5, -8)]
        [TestCase(0, 0, 0)]
        public void Add_ReturnsCorrectSum_WithDifferentInputs(int a, int b, int expected)
        {
            int result = _calculator.add(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        [TestCase(10, 0, 0, ExpectedResult = typeof(DivideByZeroException))]
        public void Divide_Tests(int a, int b, int expected)
        {
            if (b == 0)
            {
                Assert.Throws<DivideByZeroException>(() => _calculator.divide(a, b));
            }
            else
            {
                int result = _calculator.divide(a, b);
                Assert.AreEqual(expected, result);
            }
        }
    }
}
