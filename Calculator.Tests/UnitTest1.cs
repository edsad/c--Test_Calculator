using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }

        [Fact]
        public void SubtractTwoIntegers()
        {
            int difference = _calculator.Subtract(50, 30);

            Assert.Equal(difference, 20);
        }

        [Fact]
        public void MultiplyTwoIntegers()
        {
            int times = _calculator.Multiply(12, 10);

            Assert.Equal(times, 120);
        }

        [Fact]
        public void DivideTwoIntegers()
        {
            int division = _calculator.Divide(144, 12);

            Assert.Equal(division, 12);
        }
    }
}
