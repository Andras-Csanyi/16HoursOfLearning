namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class Permutations_Should
{
    private Permutations _permutations;

    public Permutations_Should()
    {
        _permutations = new Permutations();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new[] { 1, 2, 3 };
        List<List<int>> expectedResult = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 1, 3, 2 },
            new List<int> { 2, 1, 3 },
            new List<int> { 2, 3, 1 },
            new List<int> { 3, 1, 2 },
            new List<int> { 3, 2, 1 }
        };
        
        // Act
        IList<IList<int>> result = _permutations.Permute(input);
        
        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] input = new[] { 0,1 };
        List<List<int>> expectedResult = new List<List<int>>
        {
            new List<int> { 0, 1 },
            new List<int> { 1, 0 },
        };
        
        // Act
        IList<IList<int>> result = _permutations.Permute(input);
        
        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}