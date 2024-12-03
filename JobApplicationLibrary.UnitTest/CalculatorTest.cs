using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationLibrary.UnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;

        public void setup()
        {
            _calculator = new Calculator();
        }


        [Test]
        public void Add_ReturnsCorrectSum()
        {

            int result = _calculator.add(30, 50);
            Assert.AreEqual(80, result, "Add method did return the correct result sum.");

        }

        [Test]
        public void Subtract_ReturnsCorrectDifference()
        {
            int result = _calculator.subtract(10, 4);
            Assert.AreEqual(6, result, "Subtract method did return the correct difference.");
        }

    }
}
