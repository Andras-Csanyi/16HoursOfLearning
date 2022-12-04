namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class RemoveTheNthElementFromEndOfTheLinkedList_Should
{
    private readonly RemoveTheNthElementFromEndOfTheLinkedList remove;

    public RemoveTheNthElementFromEndOfTheLinkedList_Should()
    {
        remove = new RemoveTheNthElementFromEndOfTheLinkedList();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new[] { 1, 2, 3, 4, 5 };
        int number = 2;
        int[] expectedResult = new[] { 1, 2, 3, 5 };
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? head = PopulateLinkedList(input);

        // Act
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? result = remove.RemoveNthFromEnd(head, number);

        // Assert
        List<int> expectedList = expectedResult.ToList();
        List<int> resultList = ExtractValuesFromLL(result);
        resultList.Should().BeEquivalentTo(expectedList);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] input = new[] { 1 };
        int number = 1;
        int[] expectedResult = new int[] { };
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? head = PopulateLinkedList(input);

        // Act
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? result = remove.RemoveNthFromEnd(head, number);

        // Assert
        List<int> expectedList = expectedResult.ToList();
        List<int> resultList = ExtractValuesFromLL(result);
        resultList.Should().BeEquivalentTo(expectedList);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] input = new[] { 1, 2 };
        int number = 1;
        int[] expectedResult = new int[] { 1 };
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? head = PopulateLinkedList(input);

        // Act
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? result = remove.RemoveNthFromEnd(head, number);

        // Assert
        List<int> expectedList = expectedResult.ToList();
        List<int> resultList = ExtractValuesFromLL(result);
        resultList.Should().BeEquivalentTo(expectedList);
    }
    
    /// this one targets the case when in the two pointer solution the second pointer
    /// points the the node which is before 1 place to the one should be removed
    /// (if the 1 before node is tracked you get some comfort as you don't have step back
    /// when the node is removed)
    [Fact]
    public void Example4()
    {
        // Arrange
        int[] input = new[] { 1, 2 };
        int number = 2;
        int[] expectedResult = new int[] { 2 };
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? head = PopulateLinkedList(input);

        // Act
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? result = remove.RemoveNthFromEnd(head, number);

        // Assert
        List<int> expectedList = expectedResult.ToList();
        List<int> resultList = ExtractValuesFromLL(result);
        resultList.Should().BeEquivalentTo(expectedList);
    }

    public RemoveTheNthElementFromEndOfTheLinkedList.ListNode? PopulateLinkedList(int[] values)
    {
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? head = null;
        RemoveTheNthElementFromEndOfTheLinkedList.ListNode? actualNode = null;
        for (int i = 0; i < values.Length; i++)
        {
            if (i == 0)
            {
                head = new RemoveTheNthElementFromEndOfTheLinkedList.ListNode(values[i]);
                actualNode = head;
            }
            else
            {
                actualNode.next = new RemoveTheNthElementFromEndOfTheLinkedList.ListNode(values[i]);
                actualNode = actualNode.next;
            }
        }

        return head;
    }

    public List<int> ExtractValuesFromLL(RemoveTheNthElementFromEndOfTheLinkedList.ListNode? head)
    {
        List<int> values = new List<int>();

        while (true)
        {
            if (head != null)
            {
                values.Add(head.val);
                if (head.next != null)
                {
                    head = head.next;
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }

        return values;
    }
}