namespace LinkedList
{
    public class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        private SinglyLinkedListNode<T> _head = null;
        private SinglyLinkedListNode<T> _tail = null;
        private int _size = 0;

        private SinglyLinkedListNode<T> _nodes;

        public void AddAfter(SinglyLinkedListNode<T> existingNode, SinglyLinkedListNode<T> newNode)
        {
            throw new System.NotImplementedException();
        }

        public void AddAfter(T existingValue, T newValue)
        {
            throw new System.NotImplementedException();
        }

        public void AddBefore(SinglyLinkedListNode<T> existingNode, SinglyLinkedListNode<T> newNode)
        {
            throw new System.NotImplementedException();
        }

        public void AddBefore(T existingValue, T newValue)
        {
            throw new System.NotImplementedException();
        }

        public void Add(T newValue)
        {
            SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(newValue);
            Add(newNode);
        }

        public void Add(SinglyLinkedListNode<T> newValueNode)
        {
            if (_nodes == null)
            {
                _nodes = newValueNode;

                _head = newValueNode;
                newValueNode.IsHead(true);

                _tail = newValueNode;
                newValueNode.IsTail(true);
                _size++;
            }
            else
            {
                _nodes.AddTail(newValueNode);

                _tail = newValueNode;
                newValueNode.IsTail(true);

                _size++;
            }
        }

        public void AddLast(SinglyLinkedListNode<T> node)
        {
            throw new System.NotImplementedException();
        }

        public void AddLast(T value)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public void Contains(T value)
        {
            throw new System.NotImplementedException();
        }

        public T GetHead()
        {
            throw new System.NotImplementedException();
        }

        public T GetTail()
        {
            return _tail.GetValue();
        }

        public void CopyTo(T[] array, int startPosition)
        {
            throw new System.NotImplementedException();
        }

        public SinglyLinkedList<T>? Find(T value)
        {
            throw new System.NotImplementedException();
        }

        public SinglyLinkedList<T>? FindLast(T value)
        {
            throw new System.NotImplementedException();
        }
    }
}