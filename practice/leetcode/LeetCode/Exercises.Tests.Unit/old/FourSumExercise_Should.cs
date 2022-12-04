namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class FourSumExercise_Should
{
    private readonly FourSumExercise fourSum;

    public FourSumExercise_Should()
    {
        fourSum = new FourSumExercise();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new[] { 1, 0, -1, 0, -2, 2 };
        int target = 0;
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> { -2, -1, 1, 2 },
            new List<int> { -2, 0, 0, 2 },
            new List<int> { -1, 0, 0, 1 }
        };

        // Act
        IList<IList<int>> result = fourSum.FourSum(input, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}