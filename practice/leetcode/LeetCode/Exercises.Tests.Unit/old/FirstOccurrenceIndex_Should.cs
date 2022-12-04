namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class FirstOccurrenceIndex_Should
{
    private FirstOccurrenceIndex _firstOccurrenceIndex;

    public FirstOccurrenceIndex_Should()
    {
        _firstOccurrenceIndex = new FirstOccurrenceIndex();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        string needle = "sad";
        string haystack = "sadbutsad";
        int expectedResult = 0;
        
        // Act
        int result = _firstOccurrenceIndex.StrStr(haystack, needle);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        string needle = "leeto";
        string haystack = "leetcode";
        int expectedResult = -1;
        
        // Act
        int result = _firstOccurrenceIndex.StrStr(haystack, needle);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example3()
    {
        // Arrange
        string needle = "l";
        string haystack = "leeto";
        int expectedResult = 0;
        
        // Act
        int result = _firstOccurrenceIndex.StrStr(haystack, needle);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example4()
    {
        // Arrange
        string needle = "aaa";
        string haystack = "aaaa";
        int expectedResult = 0;
        
        // Act
        int result = _firstOccurrenceIndex.StrStr(haystack, needle);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example5()
    {
        // Arrange
        string needle = "aaaa";
        string haystack = "aaa";
        int expectedResult = -1;
        
        // Act
        int result = _firstOccurrenceIndex.StrStr(haystack, needle);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example6()
    {
        // Arrange
        string needle = "issipi";
        string haystack = "mississippi";
        int expectedResult = -1;
        
        // Act
        int result = _firstOccurrenceIndex.StrStr(haystack, needle);
        
        // Assert
        result.Should().Be(expectedResult);
    }
}