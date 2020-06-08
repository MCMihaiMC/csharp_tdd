using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDDemo02
{
    public class NaturalNumbersCalculatorTests
    {
        [Fact]
        public void SubstractMethod_Numbers_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Substract(4, 3);

            Assert.Equal(1, result);
        }

        [Fact]
        public void SubstractMethod_SecondNumberLargerThanFirst_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Substract(4, 5);

            Assert.Equal(0, result);
        }

    }
}
