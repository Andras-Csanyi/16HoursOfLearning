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
        public async Task Throw_WhenInputValueIsNull()
        {
            // Arrange
            Person person = null;

            // Action
            Action action = () => { _sut.Add(person); };

            // Assert
            action.Should().ThrowExactly<SinglyLinkedListException>();
        }

        [Fact]
        public async Task Throw_WhenInputValueNodeIsNull()
        {
            // Arrange
            SinglyLinkedListNode<Person> personNode = null;

            // Action
            Action action = () => { _sut.Add(personNode); };

            // Assert
            action.Should().ThrowExactly<SinglyLinkedListException>();
        }

        [Fact]
        public async Task Add_ValueToAsTail()
        {
            // Arrange
            Person person_first = new Person("first", "first", 1);
            Person person_second = new Person("second", "second", 2);
            _sut.Add(person_first);

            // Action
            _sut.Add(person_second);

            // Assert
            _sut.GetTail().Should().Be(person_second);
        }

        [Fact]
        public async Task Add_ValueNodeToAsTail()
        {
            // Arrange
            Person person_first = new Person("first", "first", 1);
            SinglyLinkedListNode<Person> first_node = new SinglyLinkedListNode<Person>(person_first);

            Person person_second = new Person("second", "second", 2);
            SinglyLinkedListNode<Person> second_node = new SinglyLinkedListNode<Person>(person_second);

            _sut.Add(first_node);

            // Action
            _sut.Add(second_node);

            // Assert
            _sut.GetTail().Should().Be(person_second);
        }
    }
}