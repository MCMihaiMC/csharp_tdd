using Xunit;
using ODDService;

namespace ODDSericeTests
{
    public class ODDServiceTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsOddMethod_OddNumbers_ReturnTrue(int number)
        {
            var service = new OddServiceImplementation();
            var result = service.IsOdd(number);

            Assert.True(result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void IsOddMethod_EvenNumbers_ReturnFalse(int number)
        {
            var service = new OddServiceImplementation();
            var result = service.IsOdd(number);

            Assert.False(result);
        }

    }
}
