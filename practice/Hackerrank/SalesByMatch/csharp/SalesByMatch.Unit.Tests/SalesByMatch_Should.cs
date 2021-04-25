using FluentAssertions;
using Xunit;

namespace SalesByMatch.Unit.Tests
{
    public class SalesByMatch_Should
    {
        private SalesByMatch _sut = new SalesByMatch();

        [Theory]
        [InlineData(new int[]{1,2,1,2,1,3,4}, 2)]
        public void CountPairs(int[] socks, int expectedResult)
        {
            // Arrange

            // Action
            int result = _sut.sockMerchant(socks);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}