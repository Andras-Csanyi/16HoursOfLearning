namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class PermutationUnique_Should
{
    private PermutationUnique _permutationUnique;

    public PermutationUnique_Should()
    {
        _permutationUnique = new PermutationUnique();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new[] { 1, 1, 2 };
        IList<IList<int>> expectedResult = new List<IList<int>>
        {
            new List<int> { 1, 1, 2 },
            new List<int> { 1, 2, 1 },
            new List<int> { 2, 1, 1 }
        };

        // Act
        IList<IList<int>> result = _permutationUnique.PermuteUnique(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] input = new[] { 1, 2, 3 };
        IList<IList<int>> expectedResult = new List<IList<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 1, 3, 2 },
            new List<int> { 2, 1, 3 },
            new List<int> { 2, 3, 1 },
            new List<int> { 3, 1, 2 },
            new List<int> { 3, 2, 1 },
        };

        // Act
        IList<IList<int>> result = _permutationUnique.PermuteUnique(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}