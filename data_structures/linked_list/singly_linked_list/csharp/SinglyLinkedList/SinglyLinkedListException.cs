using System;

namespace LinkedList
{
    public class SinglyLinkedListException : Exception
    {
        public SinglyLinkedListException()
        {
        }

        public SinglyLinkedListException(string? message) : base(message)
        {
        }
    }
}