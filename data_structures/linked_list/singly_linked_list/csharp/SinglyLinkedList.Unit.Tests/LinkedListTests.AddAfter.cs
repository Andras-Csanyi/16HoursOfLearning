using System;
using System.Threading.Tasks;
using FluentAssertions;
using LinkedList;
using Xunit;

namespace SinglyLinkedList.Unit.Tests
{
    public partial class LinkedListTests
    {
        [Fact]
        public async Task AddAfter_Should_Throw_WhenExistingNodeIsNull()
        {
            // Arrange
            SinglyLinkedListNode<Person> personNode = null;

            // Action
            Action action = () => { _sut.AddAfter(personNode, new SinglyLinkedListNode<Person>()); };

            // Assert
            action.Should().Throw<SinglyLinkedListException>();
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenExistingValueIsNull()
        {
            // Arrange
            Person existingValue = null;

            // Action
            Action action = () => { _sut.AddAfter(existingValue, new Person()); };

            // Assert
            action.Should().ThrowExactly<SinglyLinkedListException>();
        }

        [Fact]
        public async Task AddAfter_Should_Throw_WhenNewNodeIsNull()
        {
            // Arrange
            SinglyLinkedListNode<Person> existingPersonNode = new SinglyLinkedListNode<Person>();
            SinglyLinkedListNode<Person> newNode = null;

            // Action
            Action action = () => { _sut.AddAfter(existingPersonNode, newNode); };

            // Assert
            action.Should().ThrowExactly<SinglyLinkedListException>();
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