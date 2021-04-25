namespace LinkedList
{
    public class SinglyLinkedListNode<T>
    {
        private readonly SinglyLinkedListNode<T> _next = null;
        private bool _isTail = false;
        private bool _isHead = false;

        public SinglyLinkedListNode()
        {
        }

        public SinglyLinkedListNode(T value)
        {
            _value = value;
        }

        private readonly T _value;

        public T GetValue()
        {
            return _value;
        }

        public void AddTail<T>(SinglyLinkedListNode<T> newValueNode)
        {
            if (_next == null)
            {
                IsTail(true);
            }
            else
            {
                _next.AddTail<T>(newValueNode);
            }
        }

        public void IsHead(bool isHead)
        {
            _isHead = isHead;
        }

        public void IsTail(bool isTail)
        {
            _isTail = isTail;
        }
    }
}