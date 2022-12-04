namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class FlattenBST_Should
{
    private FlattenBST _flattenBst;

    public FlattenBST_Should()
    {
        _flattenBst = new FlattenBST();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        FlattenBST.TreeNode rootNode = new FlattenBST.TreeNode(1,
            new FlattenBST.TreeNode(2,
                new FlattenBST.TreeNode(3),
                new FlattenBST.TreeNode(4)),
            new FlattenBST.TreeNode(5, new FlattenBST.TreeNode(6)));

        FlattenBST.TreeNode expected = new FlattenBST.TreeNode(1,
            null,
            new FlattenBST.TreeNode(2,
                null,
                new FlattenBST.TreeNode(3,
                    null,
                    new FlattenBST.TreeNode(4,
                        null,
                        new FlattenBST.TreeNode(5,
                            null,
                            new FlattenBST.TreeNode(6))))));

        // Act
        FlattenBST.TreeNode result = _flattenBst.Flatten(rootNode);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        FlattenBST.TreeNode rootNode = new FlattenBST.TreeNode(1);

        FlattenBST.TreeNode expected = new FlattenBST.TreeNode(1);

        // Act
        FlattenBST.TreeNode result = _flattenBst.Flatten(rootNode);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}