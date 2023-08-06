namespace Exercises.Tests.Unit.graphs.DFS;

using Exercises.graphs.DFS;
using FluentAssertions;
using Xunit;

public class IsPathExistsBetweenTwoNodesShould
{
    private IsPathExistsBetweenTwoNodes _sut = new IsPathExistsBetweenTwoNodes();

    [Fact]
    public void First()
    {
        // Arrange
        int n = 3;
        int[][] input = new[]
        {
            new[] { 0, 1 },
            new[] { 1, 2 },
            new[] { 2, 0 },
        };
        int source = 0;
        int destination = 2;
        bool expectedResult = true;

        // Act
        bool result = _sut.ValidPath(n, input, source, destination);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Second()
    {
        // Arrange
        int n = 6;
        int[][] input = new[]
        {
            new[] { 0, 1 },
            new[] { 0, 2 },
            new[] { 3, 5 },
            new[] { 5, 4 },
            new[] { 4, 3 },
        };
        int source = 0;
        int destination = 5;
        bool expectedResult = false;

        // Act
        bool result = _sut.ValidPath(n, input, source, destination);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Third()
    {
        // Arrange
        int n = 1;
        int[][] input = new int[][] { };
        int source = 0;
        int destination = 0;
        bool expectedResult = true;

        // Act
        bool result = _sut.ValidPath(n, input, source, destination);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Fourth()
    {
        // Arrange
        int n = 10;
        int[][] input = new int[][]
        {
            new int[] { 4, 3 },
            new int[] { 1, 4 },
            new int[] { 4, 8 },
            new int[] { 1, 7 },
            new int[] { 6, 4 },
            new int[] { 4, 2 },
            new int[] { 7, 4 },
            new int[] { 4, 0 },
            new int[] { 0, 9 },
            new int[] { 5, 4 }
        };
        int source = 5;
        int destination = 9;
        bool expectedResult = true;

        // Act
        bool result = _sut.ValidPath(n, input, source, destination);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Fifth()
    {
        // Arrange
        int n = 10;
        int[][] input = new int[][]
        {
            new int[] { 0, 7 },
            new int[] { 0, 8 },
            new int[] { 6, 1 },
            new int[] { 2, 0 },
            new int[] { 0, 4 },
            new int[] { 5, 8 },
            new int[] { 4, 7 },
            new int[] { 1, 3 },
            new int[] { 3, 5 },
            new int[] { 6, 5 }
        };
        int source = 7;
        int destination = 5;
        bool expectedResult = true;

        // Act
        bool result = _sut.ValidPath(n, input, source, destination);

        // Assert
        result.Should().Be(expectedResult);
    }
}