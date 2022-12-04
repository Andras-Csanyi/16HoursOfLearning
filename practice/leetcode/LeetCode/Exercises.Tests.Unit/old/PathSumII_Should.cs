namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class PathSumII_Should
{
    private PathSumII _pathSum;

    public PathSumII_Should()
    {
        _pathSum = new PathSumII();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        PathSumII.TreeNode root = new PathSumII.TreeNode(5,
            // left side
            new PathSumII.TreeNode(4,
                null,
                new PathSumII.TreeNode(11, new PathSumII.TreeNode(7), new PathSumII.TreeNode(2))),
            // right side
            new PathSumII.TreeNode(8, new PathSumII.TreeNode(13),
                new PathSumII.TreeNode(4, new PathSumII.TreeNode(5), new PathSumII.TreeNode(1)))
        );
        int targetSum = 22;
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> { 5, 4, 11, 2 },
            new List<int> { 5, 8, 4, 5 },
        };

        // Act
        IList<IList<int>> result = _pathSum.PathSum(root, targetSum);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        PathSumII.TreeNode root = new PathSumII.TreeNode(1,
            // left side
            new PathSumII.TreeNode(2),
            // right side
            new PathSumII.TreeNode(3)
        );
        int targetSum = 5;
        IList<IList<int>> expected = new List<IList<int>>();

        // Act
        IList<IList<int>> result = _pathSum.PathSum(root, targetSum);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void Example3()
    {
        // Arrange
        PathSumII.TreeNode root = new PathSumII.TreeNode(1,
            // left side
            new PathSumII.TreeNode(2)
        );
        int targetSum = 0;
        IList<IList<int>> expected = new List<IList<int>>();

        // Act
        IList<IList<int>> result = _pathSum.PathSum(root, targetSum);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}