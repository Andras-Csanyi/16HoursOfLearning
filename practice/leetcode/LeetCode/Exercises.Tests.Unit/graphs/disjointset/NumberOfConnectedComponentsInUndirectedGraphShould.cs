namespace Exercises.Tests.Unit.graphs.disjointset;

using Exercises.graphs.disjointset;
using FluentAssertions;
using Xunit;

public class NumberOfConnectedComponentsInUndirectedGraphShould
{
    private NumberOfConnectedComponentsInUndirectedGraph _sut = new NumberOfConnectedComponentsInUndirectedGraph();

    [Fact]
    public void First()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 0, 1 },
            new[] { 1, 2 },
            new[] { 3, 4 },
        };
        int edges = 5;
        int expectedResult = 2;

        // Act
        int result = _sut.CountComponents(edges, input);

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
            new[] { 3, 4 },
        };
        int edges = 5;
        int expectedResult = 1;

        // Act
        int result = _sut.CountComponents(edges, input);

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
            new[] { 1, 2 },
            new[] { 0, 2 },
            new[] { 3, 4 },
        };
        int edges = 5;
        int expectedResult = 2;

        // Act
        int result = _sut.CountComponents(edges, input);

        // Assert
        result.Should().Be(expectedResult);
    }

    /// <summary>
    /// This test again deals with selecting root,
    /// which assumes that the input parameters are exchangeable
    /// fuck you!
    /// </summary>
    [Fact]
    public void Fourth()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 1, 0 },
            new[] { 2, 0 },
        };
        int edges = 3;
        int expectedResult = 1;

        // Act
        int result = _sut.CountComponents(edges, input);

        // Assert
        result.Should().Be(expectedResult);
    }
}