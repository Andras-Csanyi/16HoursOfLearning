namespace Exercises.old;

/// <summary>
///     https://leetcode.com/problems/add-two-numbers/
/// </summary>
public class AddTwoNumbersExample
{
    public static LinkedList<int> FirstSolution(LinkedListNode<int> l1, LinkedListNode<int> l2)
    {
        // check input
        // create the result ll
        // traverse the lls
        // calculate the numbers and populate the arrays in reverse order
        // what if addition is more than 10?
        // what if there is no item in one of the lls?

        LinkedList<int> result = new LinkedList<int>();
        LinkedListNode<int> resultTrackingNode = null;
        int carryOver = 0;
        bool nextRound = true;

        while (nextRound)
        {
            int l1Val = 0;
            int l2Val = 0;

            if (l1 != null)
            {
                l1Val = l1.Value;
            }

            if (l2 != null)
            {
                l2Val = l2.Value;
            }

            int res = l1Val + l2Val;

            l1Val = 0;
            l2Val = 0;

            if (carryOver > 0)
            {
                res = res + 1;
                carryOver = 0;
            }

            LinkedListNode<int> actualOperationResultNode = null;
            if (res >= 10)
            {
                actualOperationResultNode = new LinkedListNode<int>(res - 10);
                carryOver = 1;
            }
            else
            {
                actualOperationResultNode = new LinkedListNode<int>(res);
            }

            if (result.Count == 0)
            {
                result.AddFirst(actualOperationResultNode);
                resultTrackingNode = result.First;
            }
            else
            {
                result.AddAfter(resultTrackingNode, actualOperationResultNode);
                resultTrackingNode = actualOperationResultNode;
            }

            if (l1?.Next != null)
            {
                l1 = l1.Next;
            }
            else
            {
                l1 = null;
            }

            if (l2?.Next != null)
            {
                l2 = l2.Next;
            }
            else
            {
                l2 = null;
            }

            if (l1?.Next == null && l2?.Next == null && carryOver == 0)
            {
                nextRound = false;
            }
        }

        return result;
    }
}