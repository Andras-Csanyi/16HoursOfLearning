namespace Exercises.Tests.Unit;

using FluentAssertions;
using Xunit;

public class ContainerWithMostWater_Should
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] containers = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int expectedResult = 49;

        // Act
        int result = ContainerWithMostWater.Compute(containers);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] containers = new[] { 1, 1 };
        int expectedResult = 1;

        // Act
        int result = ContainerWithMostWater.Compute(containers);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] containers = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int expectedResult = 11;

        // Act
        int result = ContainerWithMostWater.Compute(containers);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Example4()
    {
        // Arrange
        int[] containers = new[] { 2, 3, 4, 5, 18, 17, 6 };
        int expectedResult = 17;

        // Act
        int result = ContainerWithMostWater.Compute(containers);

        // Assert
        result.Should().Be(expectedResult);
    }
}