namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class LetterCombinationsOfAPhoneNumber_Should
{
    private LetterCombinationsOfAPhoneNumber _letterCombinationsOfAPhoneNumber;

    public LetterCombinationsOfAPhoneNumber_Should()
    {
        _letterCombinationsOfAPhoneNumber = new LetterCombinationsOfAPhoneNumber();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        string input = "23";
        IList<string> expectedResult = new List<string>
        {
            "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"
        };

        // Act
        IList<string> result = _letterCombinationsOfAPhoneNumber.LetterCombinations(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string input = "";
        IList<string> expectedResult = new List<string> { };

        // Act
        IList<string> result = _letterCombinationsOfAPhoneNumber.LetterCombinations(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        string input = "2";
        IList<string> expectedResult = new List<string> { "a", "b", "c" };

        // Act
        IList<string> result = _letterCombinationsOfAPhoneNumber.LetterCombinations(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Example4()
    {
        // Arrange
        string input = "234";
        IList<string> expectedResult = new List<string>
        {
            "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei",
            "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi"
        };

        // Act
        IList<string> result = _letterCombinationsOfAPhoneNumber.LetterCombinations(input);

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}