namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class SameTree_Should
{
    private SameTree _sameTree;

    public SameTree_Should()
    {
        _sameTree = new SameTree();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        SameTree.TreeNode theOne = new SameTree.TreeNode(1, new SameTree.TreeNode(2), new SameTree.TreeNode(3));
        SameTree.TreeNode theOther = new SameTree.TreeNode(1, new SameTree.TreeNode(2), new SameTree.TreeNode(3));
        bool expectedResult = true;
        
        // Act
        bool result = _sameTree.IsSameTree(theOne, theOther);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        SameTree.TreeNode theOne = new SameTree.TreeNode(1, new SameTree.TreeNode(2), null);
        SameTree.TreeNode theOther = new SameTree.TreeNode(1, null, new SameTree.TreeNode(2));
        bool expectedResult = false;
        
        // Act
        bool result = _sameTree.IsSameTree(theOne, theOther);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example3()
    {
        // Arrange
        SameTree.TreeNode theOne = new SameTree.TreeNode(1, new SameTree.TreeNode(2), new SameTree.TreeNode(1));
        SameTree.TreeNode theOther = new SameTree.TreeNode(1, new SameTree.TreeNode(1), new SameTree.TreeNode(2));
        bool expectedResult = false;
        
        // Act
        bool result = _sameTree.IsSameTree(theOne, theOther);

        // Assert
        result.Should().Be(expectedResult);
    }
}