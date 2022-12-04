namespace Exercises.Tests.Unit.graphs.disjointset;

using Exercises.graphs.disjointset;
using FluentAssertions;
using Xunit;

public class ValidTreeDisjointSetShould
{
    private ValidTreeDisjointSet _sut = new ValidTreeDisjointSet();

    [Fact]
    public void First()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 0, 1 },
            new[] { 0, 2 },
            new[] { 0, 3 },
            new[] { 1, 4 }
        };
        int size = 5;
        bool expectedResult = true;

        // Act
        bool result = _sut.ValidTree(size, input);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Second()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 0, 1 },
            new[] { 1, 2 },
            new[] { 2, 3 },
            new[] { 1, 3 },
            new[] { 1, 4 }
        };
        int size = 5;
        bool expectedResult = false;

        // Act
        bool result = _sut.ValidTree(size, input);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Third()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 0, 1 },
            new[] { 2, 3 }
        };
        int size = 4;
        bool expectedResult = false;

        // Act
        bool result = _sut.ValidTree(size, input);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    /// <summary>
    /// This test checks the point where root node should be selected.
    /// Fuck you.
    /// </summary>
    [Fact]
    public void Fourth()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 1, 0 },
            new[] { 2, 0 }
        };
        int size = 3;
        bool expectedResult = true;

        // Act
        bool result = _sut.ValidTree(size, input);

        // Assert
        result.Should().Be(expectedResult);
    }
}