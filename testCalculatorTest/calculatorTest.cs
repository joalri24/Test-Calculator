using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testCalculator;

namespace testCalculatorTest
{
    [TestClass]
    public class calculatorTest
    {
        [TestMethod]
        public void SumOperation()
        {
            // Arrange
            float firstValue = 20;
            float secondValue = 4;
            Calculator calculator = new Calculator();
            calculator.operation = Calculator.Operators.sum;
            calculator.firstValue = firstValue;
            calculator.secondValue = secondValue;

            // Act
            float answer = calculator.Calculate();

            // Assert
            Assert.AreEqual(24f, answer);
        }

        [TestMethod]
        public void SubtractOperation()
        {
            // Arrange
            float firstValue = 20;
            float secondValue = 4;
            Calculator calculator = new Calculator();
            calculator.operation = Calculator.Operators.substraction;
            calculator.firstValue = firstValue;
            calculator.secondValue = secondValue;

            // Act
            float answer = calculator.Calculate();

            // Assert
            Assert.AreEqual(16f, answer);
        }

        [TestMethod]
        public void MultiplyOperation()
        {
            // Arrange
            float firstValue = 20;
            float secondValue = 4;
            Calculator calculator = new Calculator();
            calculator.operation = Calculator.Operators.multiplication;
            calculator.firstValue = firstValue;
            calculator.secondValue = secondValue;

            // Act
            float answer = calculator.Calculate();

            // Assert
            Assert.AreEqual(80f, answer);
        }

        [TestMethod]
        public void DivideOperation()
        {
            // Arrange
            float firstValue = 20;
            float secondValue = 4;
            Calculator calculator = new Calculator();
            calculator.operation = Calculator.Operators.division;
            calculator.firstValue = firstValue;
            calculator.secondValue = secondValue;

            // Act
            float answer = calculator.Calculate();

            // Assert
            Assert.AreEqual(5f, answer);
        }
    }
}
