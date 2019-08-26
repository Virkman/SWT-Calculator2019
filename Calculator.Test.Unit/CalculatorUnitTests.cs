using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    class CalculatorUnitTests
    {
        private Calculator _calc;

        [SetUp]
        public void setup()
        {
            _calc = new Calculator();
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 5, 8)]
        [TestCase(7, 8, 15)]
        [TestCase(10, 50, 60)]
        [TestCase(12, 76, 88)]
        public void CalculatorAdd_ReturnTrue(double a, double b, double sum)
        {
            Assert.That(_calc.Add(a, b), Is.EqualTo(sum));
        }

        [TestCase(2, 1, 1)]
        [TestCase(5, 3, 2)]
        [TestCase(8, 7, 1)]
        [TestCase(50, 10, 40)]
        [TestCase(76, 12, 64)]
        public void CalculatorSubtract_ReturnTrue(double a, double b, double sum)
        {
            Assert.That(_calc.Subtract(a, b), Is.EqualTo(sum));
        }

        [TestCase(2, 1, 2)]
        [TestCase(5, 3, 15)]
        [TestCase(8, 7, 56)]
        [TestCase(50, 10, 500)]
        [TestCase(76, 12, 912)]
        public void CalculatorMultiply_ReturnTrue(double a, double b, double sum)
        {
            Assert.That(_calc.Multiply(a, b), Is.EqualTo(sum));
        }

        [TestCase(2, 1, 2)]
        [TestCase(5, 3, 125)]
        [TestCase(8, 7, 2097152)]
        [TestCase(50, 3, 125000)]
        [TestCase(5, 2, 25)]
        public void CalculatorPower_ReturnTrue(double a, double b, double sum)
        {
            Assert.That(_calc.Power(a, b), Is.EqualTo(sum));
        }
    }
}
