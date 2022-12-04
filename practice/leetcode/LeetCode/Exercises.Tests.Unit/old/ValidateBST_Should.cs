namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class ValidateBST_Should
{
    private ValidateBST _validateBst;

    public ValidateBST_Should()
    {
        _validateBst = new ValidateBST();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        TreeNode root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        bool expectedResult = true;

        // Act
        bool result = _validateBst.IsValidBST(root);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        TreeNode root = new TreeNode(5,
            new TreeNode(1), // 5's left 
            new TreeNode(4, // 5's right
                new TreeNode(3), // 4's left
                new TreeNode(6)) // 4's right 
        );
        bool expectedResult = false;

        // Act
        bool result = _validateBst.IsValidBST(root);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        TreeNode root = new TreeNode(2,
            new TreeNode(2), // 5's left 
            new TreeNode(2)
        );
        bool expectedResult = false;

        // Act
        bool result = _validateBst.IsValidBST(root);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example4()
    {
        // Arrange
        TreeNode root = new TreeNode(5,
            new TreeNode(4), // 5's left 
            new TreeNode(6, new TreeNode(3), new TreeNode(7))
        );
        bool expectedResult = false;

        // Act
        bool result = _validateBst.IsValidBST(root);

        // Assert
        result.Should().Be(expectedResult);
    }
}