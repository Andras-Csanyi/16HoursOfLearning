namespace Exercises.Tests.Unit;

using FluentAssertions;
using Xunit;

public class ThreeSumExercise_Should
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new[] { -1, 0, 1, 2, -1, -4 };
        IList<IList<int>> expectedResult = new List<IList<int>>();
        IList<int> exp1 = new List<int>();
        exp1.Add(-1);
        exp1.Add(-1);
        exp1.Add(2);
        expectedResult.Add(exp1);
        IList<int> exp2 = new List<int>();
        exp2.Add(-1);
        exp2.Add(0);
        exp2.Add(1);
        expectedResult.Add(exp2);

        // Act
        IList<IList<int>> result = ThreeSumExercise.Compute(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] input = new[] { 0, 1, 1 };
        IList<IList<int>> expectedResult = new List<IList<int>>();

        // Act
        IList<IList<int>> result = ThreeSumExercise.Compute(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] input = new[] { 0, 0, 0 };
        IList<IList<int>> expectedResult = new List<IList<int>>
        {
            new List<int> { 0, 0, 0 }
        };

        // Act
        IList<IList<int>> result = ThreeSumExercise.Compute(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Example4()
    {
        // Arrange
        int[] input = new[] { 0, 0, 0, 0 };
        IList<IList<int>> expectedResult = new List<IList<int>>
        {
            new List<int> { 0, 0, 0 }
        };

        // Act
        IList<IList<int>> result = ThreeSumExercise.Compute(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Example5()
    {
        // Arrange
        int[] input = new[] { -2, 0, 1, 1, 2 };
        IList<IList<int>> expectedResult = new List<IList<int>>
        {
            new List<int> { -2, 0, 2 },
            new List<int> { -2, 1, 1 }
        };

        // Act
        IList<IList<int>> result = ThreeSumExercise.Compute(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}