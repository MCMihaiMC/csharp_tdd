using Xunit;

namespace TddDemo01
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculator_AddMethod_Numbers_Success()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Calculator_SubstractMethod_Numbers_Success()
        {
            var calculator = new Calculator();
            var result = calculator.Substract(5, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Calculator_MultiplyMethod_Numbers_Success()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(3, 2);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Calculator_DivideMethod_Numbers_Success()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(6, 2);

            Assert.Equal(3, result);
        }
    }
}
