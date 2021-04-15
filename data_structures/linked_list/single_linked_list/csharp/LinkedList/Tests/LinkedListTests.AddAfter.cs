using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace LinkedList.Tests
{
    public partial class LinkedListTests
    {
        [Fact]
        public async Task AddAfter_Should_Throw_WhenExistingNodeIsNull()
        {
            // Arrange
            SinglyLinkedList<Person> sut = new SinglyLinkedList<Person>();
            LinkedListNode<Person> personNode = null;

            // Action
            Action action = () => { sut.AddAfter(personNode, new LinkedListNode<Person>()); };

            // Assert
            action.Should().Throw<LinkedListException>();
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenExistingValueIsNull()
        {
            // Arrange
            SinglyLinkedList<Person> sut = new SinglyLinkedList<Person>();
            Person existingValue = null;

            // Action
            Action action = () => { sut.AddAfter(existingValue, new Person()); };

            // Assert
            action.Should().ThrowExactly<LinkedListException>();
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenNewNodeIsNull()
        {
            // Arrange
            SinglyLinkedList<Person> sut = new SinglyLinkedList<Person>();
            LinkedListNode<Person> existingPersonNode = new LinkedListNode<Person>();
            LinkedListNode<Person> newNode = null;

            // Action
            Action action = () => { sut.AddAfter(existingPersonNode, newNode); };

            // Assert
            action.Should().ThrowExactly<LinkedListException>();
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenNewValueIsNull()
        {
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenNoExistingNode()
        {
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenNoExistingValue()
        {
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenNoFirstNode()
        {
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenLinkedListIsEmpty()
        {
        }

        [Fact]
        public async Task AddAfter_Should_AddAfterTheSpecifiedExistingNode()
        {
        }
    }
}