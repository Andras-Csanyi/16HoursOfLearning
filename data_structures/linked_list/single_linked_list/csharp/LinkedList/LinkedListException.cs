using System;

namespace LinkedList
{
    public class LinkedListException : Exception
    {
        public LinkedListException()
        {
        }

        public LinkedListException(string? message) : base(message)
        {
        }
    }
}