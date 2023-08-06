namespace Exercises.Tests.Unit.graphs.DFS;

using Exercises.graphs.DFS;
using FluentAssertions;
using Xunit;

public class DAGAllPathsToNodeShould
{
    private DAGAllPathsToNode _sut = new DAGAllPathsToNode();

    [Fact]
    public void First()
    {
        // Arrange
        int[][] input = new[]
        {
            new int[] { 1, 2 },
            new int[] { 3 },
            new int[] { 3 },
            new int[] { }
        };
        IList<IList<int>> expectedResult = new List<IList<int>>
        {
            new List<int> { 0, 1, 3 },
            new List<int> { 0, 2, 3 },
        };

        // Action
        IList<IList<int>> result = _sut.AllPathsSourceTarget(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Second()
    {
        // Arrange
        int[][] input = new[]
        {
            new int[] { 4, 3, 1 },
            new int[] { 3, 2, 4 },
            new int[] { 3 },
            new int[] { 4 },
            new int[] { }
        };
        IList<IList<int>> expectedResult = new List<IList<int>>
        {
            new List<int> { 0, 4 },
            new List<int> { 0, 3, 4 },
            new List<int> { 0, 1, 3, 4 },
            new List<int> { 0, 1, 2, 3, 4 },
            new List<int> { 0, 1, 4 },
        };

        // Action
        IList<IList<int>> result = _sut.AllPathsSourceTarget(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}