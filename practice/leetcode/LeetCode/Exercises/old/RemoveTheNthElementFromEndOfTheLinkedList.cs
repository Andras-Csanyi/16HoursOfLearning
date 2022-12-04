namespace Exercises.old;

public class RemoveTheNthElementFromEndOfTheLinkedList
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode endFindingPointer = dummy;
        ListNode operationLocatingPointer = dummy;
        int counter = 1;

        for (int i = 1; i < n + 1; i++)
        {
            endFindingPointer = endFindingPointer.next;
        }

        while (endFindingPointer.next != null)
        {
            endFindingPointer = endFindingPointer.next;
            operationLocatingPointer = operationLocatingPointer.next;
        }

        operationLocatingPointer.next = operationLocatingPointer.next.next;
        return dummy.next;
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
}