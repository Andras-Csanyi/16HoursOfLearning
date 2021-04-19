namespace LinkedList
{
    /// <summary>
    /// Interface of LinkedList data structure.
    ///
    /// It can store <see cref="T">type</see>.
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public interface ISinglyLinkedList<T>
    {
        /// <summary>
        /// Adds the specified node after the specified already existing node.
        ///
        /// If node exist in multiple instances then it will add the first occasions.
        /// Question: how to compare?
        /// 
        /// </summary>
        /// <param name="existingNode">The node which after the node will be inserted.</param>
        /// <param name="newNode">The new node will be added to.</param>
        void AddAfter(SinglyLinkedListNode<T> existingNode, SinglyLinkedListNode<T> newNode);

        /// <summary>
        /// Adds the specified value after the specified already existing value.
        ///
        /// If value exists in multiple instances in the linked list then the new
        /// value will be added to the first occasion.
        /// Question: how to compare?
        /// 
        /// </summary>
        /// <param name="existingValue">The existing value which after the new value will be inserted</param>
        /// <param name="newValue">The new value which will be added.</param>
        void AddAfter(T existingValue, T newValue);

        /// <summary>
        /// Adds the specified node before the existing node.
        /// </summary>
        /// <param name="existingNode">The node before to which the new node going to be inserted.</param>
        /// <param name="newNode">The new node.</param>
        void AddBefore(SinglyLinkedListNode<T> existingNode, SinglyLinkedListNode<T> newNode);

        /// <summary>
        /// Adds the specified value before a specified, already existing value.
        /// </summary>
        /// <param name="existingValue">The specified existing value.</param>
        /// <param name="newValue">The new value.</param>
        void AddBefore(T existingValue, T newValue);

        /// <summary>
        /// Adds the specified value to the Singly Linked list as last item.
        ///
        /// This method is basically an alias to <see cref="AddLast(LinkedList.SinglyLinkedListNode{T})"/>.
        /// </summary>
        /// <param name="newValue">The new value.</param>
        void Add(T newValue);

        /// <summary>
        /// Adds the specified value to the Singly Linked list as last item.
        ///
        /// This method is basically an alias to <see cref="AddLast(LinkedList.SinglyLinkedListNode{T})"/>.
        /// </summary>
        /// <param name="newValueNode">The new value node.</param>
        void Add(SinglyLinkedListNode<T> newValueNode);

        /// <summary>
        /// Adds the specified node as last item.
        /// </summary>
        /// <param name="node">The node will be added.</param>
        void AddLast(SinglyLinkedListNode<T> node);

        /// <summary>
        /// Adds the specified value as last item.
        /// </summary>
        /// <param name="value">The specified value.</param>
        void AddLast(T value);

        /// <summary>
        /// Removes all item from linked list.
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines whether the specified value is in the linked list.
        /// </summary>
        /// <param name="value">The value we are looking for.</param>
        void Contains(T value);

        /// <summary>
        /// Returns the head of the Singly linked list.
        /// </summary>
        /// <returns>
        /// The head of the linked list.
        /// </returns>
        T GetHead();

        /// <summary>
        /// Returns the tail of the singly linked list.
        /// </summary>
        /// <returns>
        /// The tail of the singly linked list.
        /// </returns>
        T GetTail();

        /// <summary>
        /// Copies linked list into the specified array from the specified position as one dimension array.
        ///
        /// The array must be integer indexed.
        /// </summary>
        /// <param name="array">The array the linked list will be copied to.</param>
        /// <param name="startPosition">The position where the copy starts.</param>
        void CopyTo(T[] array, int startPosition);

        /// <summary>
        /// Finds the first occasion of the value in the linked list.
        /// It returns the first occasion of the value in the linked list.
        /// If there is no value then it returns null.
        /// </summary>
        /// <param name="value">The value we are looking for.</param>
        /// <returns>The linked list or null.</returns>
        SinglyLinkedList<T>? Find(T value);

        /// <summary>
        /// Find the last occasion of the value in the linked list.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <returns>The linked list node contains the value or null.</returns>
        SinglyLinkedList<T>? FindLast(T value);
    }
}