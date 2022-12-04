namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class PopulateNextRightPointers_Should
{
    private PopulateNextRightPointers _populateNextRightPointers;

    public PopulateNextRightPointers_Should()
    {
        _populateNextRightPointers = new PopulateNextRightPointers();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        PopulateNextRightPointers.Node node = new PopulateNextRightPointers.Node(1,
            new PopulateNextRightPointers.Node(2,
                new PopulateNextRightPointers.Node(4),
                new PopulateNextRightPointers.Node(5),
                null),
            new PopulateNextRightPointers.Node(3,
                new PopulateNextRightPointers.Node(6),
                new PopulateNextRightPointers.Node(7),
                null),
            null
        );

        PopulateNextRightPointers.Node three = new PopulateNextRightPointers.Node(3);
        PopulateNextRightPointers.Node four = new PopulateNextRightPointers.Node(4);
        PopulateNextRightPointers.Node five = new PopulateNextRightPointers.Node(5);
        PopulateNextRightPointers.Node six = new PopulateNextRightPointers.Node(6);
        PopulateNextRightPointers.Node seven = new PopulateNextRightPointers.Node(7);
        PopulateNextRightPointers.Node two = new PopulateNextRightPointers.Node(2);
        PopulateNextRightPointers.Node one = new PopulateNextRightPointers.Node(1);

        six.next = seven;
        five.next = six;
        four.next = five;
        two.next = three;
        one.next = null;

        one.left = two;
        two.left = four;
        two.right = five;

        one.right = three;
        three.left = six;
        three.right = seven;

        // Act
        PopulateNextRightPointers.Node result = _populateNextRightPointers.Connect(node);

        // Assert
        result.Should().BeEquivalentTo(one);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        PopulateNextRightPointers.Node node = new PopulateNextRightPointers.Node(1,
            new PopulateNextRightPointers.Node(2,
                new PopulateNextRightPointers.Node(4),
                new PopulateNextRightPointers.Node(5),
                null),
            new PopulateNextRightPointers.Node(3,
                null,
                new PopulateNextRightPointers.Node(7),
                null),
            null
        );

        PopulateNextRightPointers.Node three = new PopulateNextRightPointers.Node(3);
        PopulateNextRightPointers.Node four = new PopulateNextRightPointers.Node(4);
        PopulateNextRightPointers.Node five = new PopulateNextRightPointers.Node(5);
        PopulateNextRightPointers.Node seven = new PopulateNextRightPointers.Node(7);
        PopulateNextRightPointers.Node two = new PopulateNextRightPointers.Node(2);
        PopulateNextRightPointers.Node one = new PopulateNextRightPointers.Node(1);

        five.next = seven;
        four.next = five;
        two.next = three;
        one.next = null;

        one.left = two;
        two.left = four;
        two.right = five;

        one.right = three;
        three.right = seven;

        // Act
        PopulateNextRightPointers.Node result = _populateNextRightPointers.Connect(node);

        // Assert
        result.Should().BeEquivalentTo(one);
    }
}