namespace Exercises.Tests.Unit.graphs.disjointset;

using Exercises.graphs.disjointset;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

public class NumberOfProvincesDisjointSetShould
{
    private NumberOfProvincesDisjointSet _cut = new NumberOfProvincesDisjointSet();
    private ITestOutputHelper _helper;

    public NumberOfProvincesDisjointSetShould(ITestOutputHelper helper)
    {
        ArgumentNullException.ThrowIfNull(helper);
        _helper = helper;
    }

    /// <summary>
    /// nodes are connected to themselves and to the other one
    /// </summary>
    [Fact]
    public void First()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 1, 1 },
            new[] { 1, 1 },
        };
        int expectedResult = 1;

        // Act
        int result = _cut.FindCircleNum(input);

        // Assert
        result.Should().Be(expectedResult);
    }

    /// <summary>
    /// wrong input
    /// </summary>
    [Fact]
    public void Second()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 1 },
            new[] { 1, 0 },
            new[] { 1, 0, 1 },
            new[] { 1, 0 },
        };

        // Act
        Action action = () => { _cut.FindCircleNum(input); };

        // Assert
        action.Should().Throw<Exception>();
    }

    /// <summary>
    /// nodes connected only to themselves
    /// </summary>
    [Fact]
    public void Third()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 1, 0 },
            new[] { 0, 1 },
        };
        int expectedResult = 2;

        // Act
        int result = _cut.FindCircleNum(input);

        // Assert
        result.Should().Be(expectedResult);
    }

    /// <summary>
    /// nodes are connected only to themselves
    /// </summary>
    [Fact]
    public void Fourth()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 1, 0, 0 },
            new[] { 0, 1, 0 },
            new[] { 0, 0, 1 },
        };
        int expectedResult = 3;

        // Act
        int result = _cut.FindCircleNum(input);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    /// <summary>
    /// 0-1 are connected and to themselves
    /// 2 connected only to itself
    /// </summary>
    [Fact]
    public void Fifth()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 1, 1, 0 },
            new[] { 1, 1, 0 },
            new[] { 0, 0, 1 },
        };
        int expectedResult = 2;

        // Act
        int result = _cut.FindCircleNum(input);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    /// <summary>
    /// all connected and to themselves
    /// </summary>
    [Fact]
    public void Sixth()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 1, 1, 1 },
            new[] { 1, 1, 1 },
            new[] { 1, 1, 1 },
        };
        int expectedResult = 1;

        // Act
        int result = _cut.FindCircleNum(input);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    /// <summary>
    /// all connected but not themselves
    /// </summary>
    [Fact]
    public void Seventh()
    {
        // Arrange
        int[][] input = new[]
        {
            new[] { 0, 1, 1 },
            new[] { 1, 0, 1 },
            new[] { 1, 1, 0 },
        };
        int expectedResult = 1;

        // Act
        int result = _cut.FindCircleNum(input);

        // Assert
        result.Should().Be(expectedResult);
    }
}