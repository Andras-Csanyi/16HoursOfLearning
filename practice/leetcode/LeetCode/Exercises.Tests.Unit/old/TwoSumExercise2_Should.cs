namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class TwoSumExercise2_Should
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new[] { 2, 7, 11, 15 };
        int target = 9;
        int[] expected = new[] { 1, 2 };

        // Act
        int[] result = TwoSumExercise2.Compute(input, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] input = new[] { 2, 3, 4 };
        int target = 6;
        int[] expected = new[] { 1, 3 };

        // Act
        int[] result = TwoSumExercise2.Compute(input, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] input = new[] { -1, 0 };
        int target = -1;
        int[] expected = new[] { 1, 2 };

        // Act
        int[] result = TwoSumExercise2.Compute(input, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}