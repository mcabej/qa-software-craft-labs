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
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Subtract("20,5");

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Subtract_ValidString_NegativeNumber_CalculatesResult()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Subtract("20,-5");

            // Assert
            Assert.AreEqual(25, result);
        }

        [Test]
        public void Subtract_ValidString_SpaceBetween_CalculatesResult()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Subtract("20  ,  5");

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Subtract_ValidString_ReturnNegative_CalculatesResult()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Subtract("5,20");

            // Assert
            Assert.AreEqual(-15, result);

        }

        [Test]
        public void Subtract_ValidString_MultipleValues_CalculatesResult()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Subtract("20,5,10,12");

            // Assert
            Assert.AreEqual(15, result);            
        }

        [Test]
        public void Multiply_ValidString_CalculatesResult()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Multiply("20,5");

            // Assert
            Assert.AreEqual(100, result);
        }

        [Test]
        public void Divide_ValidString_CalculatesResult()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Divide("20,5");

            // Assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void DivideByZero_ValidString_CalculatesResult()
        {
            // Arrange
            Calculator calc = new Calculator();

            int result = calc.Divide("20,0");
            // Act & Assert                      
            Assert.Fail("Cannot divide by zero", result);            
        }
    }
}
