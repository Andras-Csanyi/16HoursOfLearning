namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class SwapPairsInLL_Should
{
    private readonly SwapPairsInLL swapper;

    public SwapPairsInLL_Should()
    {
        swapper = new SwapPairsInLL();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new[] { 1, 2, 3, 4 };
        int[] expectedResult = new int[] { 2, 1, 4, 3 };
        ListNode? head = PopulateLinkedList(input);

        // Act
        ListNode? result = swapper.SwapPairs(head);

        // Assert
        List<int> expectedList = expectedResult.ToList();
        List<int> resultList = ExtractValuesFromLL(result);
        resultList.Should().BeEquivalentTo(expectedList);
    }

    public ListNode? PopulateLinkedList(int[] values)
    {
        ListNode? head = null;
        ListNode? actualNode = null;
        for (int i = 0; i < values.Length; i++)
        {
            if (i == 0)
            {
                head = new ListNode(values[i]);
                actualNode = head;
            }
            else
            {
                actualNode.next = new ListNode(values[i]);
                actualNode = actualNode.next;
            }
        }

        return head;
    }

    public List<int> ExtractValuesFromLL(ListNode? head)
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