namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class ThreeSumClosest_Should
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new[] { -1, 2, 1, -4 };
        int target = 1;
        int expectedResult = 2;

        // Act
        int result = ThreeSumClosest.Compute(input, target);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] input = new[] { 0, 0, 0 };
        int target = 1;
        int expectedResult = 0;

        // Act
        int result = ThreeSumClosest.Compute(input, target);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] input = new[] { 1, 1, 1, 0 };
        int target = 100;
        int expectedResult = 3;

        // Act
        int result = ThreeSumClosest.Compute(input, target);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example4()
    {
        // Arrange
        int[] input = new[] { 1, 1, 1, 0 };
        int target = -100;
        int expectedResult = 2;

        // Act
        int result = ThreeSumClosest.Compute(input, target);

        // Assert
        result.Should().Be(expectedResult);
    }
}