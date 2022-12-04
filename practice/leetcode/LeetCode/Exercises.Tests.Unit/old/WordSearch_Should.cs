namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

public class WordSearch_Should
{
    private readonly ITestOutputHelper _helper;
    private WordSearch _search;

    public WordSearch_Should(ITestOutputHelper helper)
    {
        _search = new WordSearch();
        _helper = helper;
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new[] { 'A', 'B', 'C', 'D' },
            new[] { 'E', 'F', 'G', 'H' },
            new[] { 'I', 'J', 'K', 'L' }
        };
        string word = "ABCGKJ";
        bool expected = true;

        // Act
        bool result = _search.Exist(board, word);

        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new[] { 'A', 'B', 'C', 'E' },
            new[] { 'S', 'F', 'C', 'S' },
            new[] { 'A', 'D', 'E', 'E' }
        };
        string word = "SEE";
        bool expected = true;

        // Act
        bool result = _search.Exist(board, word);

        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example3()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new[] { 'A', 'B', 'C', 'E' },
            new[] { 'S', 'F', 'C', 'S' },
            new[] { 'A', 'D', 'E', 'E' }
        };
        string word = "ABCB";
        bool expected = false;

        // Act
        bool result = _search.Exist(board, word);

        // Assert
        result.Should().Be(expected);
    }
}