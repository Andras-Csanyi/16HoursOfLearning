using FluentAssertions;
using Xunit;

namespace SalesByMatch.Unit.Tests
{
    public class SalesByMatch_Should
    {
        private ISockMerchant _sutBruteForce = new SalesByMatchBruteForce();
        private ISockMerchant _sutList = new SalesByMatchList();
        private ISockMerchant _sutByIteration = new SalesByMatchBySingleIteration();

        [Theory]
        [InlineData(new int[] {1, 2, 1, 2, 1, 3, 2}, 2)]
        [InlineData(new int[] {1, 2, 1, 2, 1, 3, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}, 2)]
        [InlineData(new int[] {1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10}, 10)]
        [InlineData(
            new int[] {1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10},
            10)]
        public void CountPairs_BruteForce(int[] socks, int expectedResult)
        {
            // Arrange

            // Action
            int result = _sutBruteForce.SockMerchant(socks);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new int[] {1, 2, 1, 2, 1, 3, 2}, 2)]
        [InlineData(new int[] {1, 2, 1, 2, 1, 3, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}, 2)]
        [InlineData(new int[] {1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10}, 10)]
        [InlineData(
            new int[] {1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10},
            10)]
        public void CountPairs_List(int[] socks, int expectedResult)
        {
            // Arrange

            // Action
            int result = _sutList.SockMerchant(socks);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new int[] {1, 2, 1, 2, 1, 3, 2}, 2)]
        [InlineData(new int[] {1, 2, 1, 2, 1, 3, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}, 2)]
        [InlineData(new int[] {1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10}, 10)]
        [InlineData(
            new int[] {1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10},
            10)]
        public void CountPairs_Iteration(int[] socks, int expectedResult)
        {
            // Arrange

            // Action
            int result = _sutByIteration.SockMerchant(socks);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}