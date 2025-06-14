using System.Numbers;
 using Xunit;

namespace Numbers.Tests
{
    public class PrimeServiceTests
    {
        public readonly PrimeService _primeService;
        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime.");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimeLessThan10_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.True(result, $"{value} should be prime.");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_NonPrimeLessThan10_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime.");
        }
    }
}