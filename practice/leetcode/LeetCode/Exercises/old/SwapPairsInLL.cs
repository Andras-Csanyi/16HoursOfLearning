namespace Exercises.old;

public class SwapPairsInLL
{
    public ListNode SwapPairs(ListNode head)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode trace = null;
        ListNode first = null;
        ListNode second = null;
        ListNode firstAfterTheSwap = null;

        int counter = 0;
        while (dummy != null)
        {
            // find the trace, this is the node before the two going to be swapped
            if (counter == 0)
            {
                trace = dummy;
                counter++;
                dummy = dummy.next;
                continue;
            }

            // find the first from the two going to be swapped
            if (counter == 1)
            {
                first = dummy;
                counter++;
                dummy = dummy.next;
                continue;
            }

            // find the second from the two going to be swapped
            if (counter == 2)
            {
                second = dummy;
                firstAfterTheSwap = dummy.next;

                // swap the nodes
                trace.next = second;
                trace.next.next = first;

                if (trace.next.next.next != null)
                {
                    trace.next.next.next = firstAfterTheSwap;
                }

                if (firstAfterTheSwap == null)
                {
                    break;
                }

                // step the stuff ahead
                dummy = first;
                counter = 0;
            }
        }

        return dummy.next;
    }
}

public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}