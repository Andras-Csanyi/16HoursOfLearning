namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class AddTwoNumbersExample_Should
{
    [Fact]
    public void Solution1_Test1()
    {
        // Arrange
        int[] ll1 = new[] { 2, 4, 3 };
        int[] ll2 = new[] { 5, 6, 4 };
        int[] expected = new[] { 7, 0, 8 };

        // Act
        LinkedList<int> result = AddTwoNumbersExample.FirstSolution(
            new LinkedList<int>(ll1).First,
            new LinkedList<int>(ll2).First);

        // Assert
        result.Should().BeEquivalentTo(new LinkedList<int>(expected),
            options => options.WithStrictOrdering());
    }

    [Fact]
    public void Solution1_Test2()
    {
        // Arrange
        int[] ll1 = new[] { 0 };
        int[] ll2 = new[] { 0 };
        int[] expected = new[] { 0 };

        // Act
        LinkedList<int> result = AddTwoNumbersExample.FirstSolution(
            new LinkedList<int>(ll1).First,
            new LinkedList<int>(ll2).First);

        // Assert
        result.Should().BeEquivalentTo(new LinkedList<int>(expected),
            options => options.WithStrictOrdering());
    }

    [Fact]
    public void Solution1_Test3()
    {
        // Arrange
        int[] ll1 = new[] { 9, 9, 9, 9, 9, 9, 9 };
        int[] ll2 = new[] { 9, 9, 9, 9 };
        int[] expected = new[] { 8, 9, 9, 9, 0, 0, 0, 1 };

        // Act
        LinkedList<int> result = AddTwoNumbersExample.FirstSolution(
            new LinkedList<int>(ll1).First,
            new LinkedList<int>(ll2).First);

        // Assert
        result.Should().BeEquivalentTo(new LinkedList<int>(expected),
            options => options.WithStrictOrdering());
    }
}