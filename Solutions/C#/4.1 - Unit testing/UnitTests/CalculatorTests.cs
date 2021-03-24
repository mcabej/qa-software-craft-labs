using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Subtract_ValidString_CalculatesResult()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the subtract method
            int actual = calc.Subtract("20,5");

            // Assert: check the result was as expected
            int expected = 15;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_ValidString_NegativeSecondNumber_CalculatesResult()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the subtract method
            int actual = calc.Subtract("20,-5");

            // Assert: check the result was as expected
            int expected = 25;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_ValidString_NegativeFirstNumber_CalculatesResult()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the subtract method
            int actual = calc.Subtract("-20,5");

            // Assert: check the result was as expected
            int expected = -25;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_ValidString_BiggestInteger_CalculatesResult()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the subtract method
            int actual = calc.Subtract("2147483647,1");

            // Assert: check the result was as expected
            int expected = 2147483646;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Subtract_ParameterTooBigInteger_ThrowsError()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the subtract method
            // Assert: exception thrown
            Assert.Throws<OverflowException>(() =>
            {
                int actual = calc.Subtract("2147483648,1");
            });
        }

        [Test]
        public void Subtract_InvalidString_NoComma_ThrowsError()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the subtract method
            // Assert: exception thrown
            Assert.Throws<FormatException>(() =>
            {
                int actual = calc.Subtract("20 5");
            });
        }

        [Test]
        public void Subtract_InvalidString_NotNumber_ThrowsError()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the subtract method
            // Assert: exception thrown
            Assert.Throws<FormatException>(() =>
            {
                int actual = calc.Subtract("20,fred");
            });
        }

        [Test]
        public void Multiply_ValidString_CalculatesResult()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the multiply method
            int actual = calc.Multiply("20,5");

            // Assert: check the result was as expected
            int expected = 100;
            Assert.AreEqual(expected, actual);
        }

        // ... Could keep adding more tests in the same way...

        [Test]
        public void Divide_ValidString_CalculatesResult()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the divide method
            int actual = calc.Divide("20,5");

            // Assert: check the result was as expected
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_ByZero_ThrowsError()
        {
            // Arrange: make a calculator object
            Calculator calc = new Calculator();

            // Act: call the divide method
            // And assert: error is thrown
            Assert.Throws<DivideByZeroException>(() =>
            {
                int actual = calc.Divide("20,0");
            });
        }
    }
}
