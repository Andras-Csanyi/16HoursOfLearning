namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class SumNumbers_Should
{
    private SumNumbersExercise _sumNumbersExercise;

    public SumNumbers_Should()
    {
        _sumNumbersExercise = new SumNumbersExercise();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        SumNumbersExercise.TreeNode root = new SumNumbersExercise.TreeNode(1,
            new SumNumbersExercise.TreeNode(2),
            new SumNumbersExercise.TreeNode(3));
        
        int expected = 25;

        // Act
        int result = _sumNumbersExercise.SumNumbers(root);

        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        SumNumbersExercise.TreeNode root = new SumNumbersExercise.TreeNode(4,
            new SumNumbersExercise.TreeNode(9,
                new SumNumbersExercise.TreeNode(5),
                new SumNumbersExercise.TreeNode(1)),
            new SumNumbersExercise.TreeNode(0));
        
        int expected = 1026;

        // Act
        int result = _sumNumbersExercise.SumNumbers(root);

        // Assert
        result.Should().Be(expected);
    }
}