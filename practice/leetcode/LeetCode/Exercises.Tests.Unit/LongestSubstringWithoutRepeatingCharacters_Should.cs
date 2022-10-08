namespace Exercises.Tests.Unit;

using FluentAssertions;
using Xunit;

public class LongestSubstringWithoutRepeatingCharacters_Should
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "abcabcbb";
        int expectedResult = 3;
        
        // Act
        int result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "bbbbb";
        int expectedResult = 1;
        
        // Act
        int result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "pwwkew";
        int expectedResult = 3;
        
        // Act
        int result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example4()
    {
        // Arrange
        string s = "111111111111111111111111111111111111 qwertyuioplkjhgfdsazxcvbnm1111111111111111111111111111111111";
        int expectedResult = 28;
        
        // Act
        int result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example5()
    {
        // Arrange
        string s = " ";
        int expectedResult = 1;
        
        // Act
        int result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void Example6()
    {
        // Arrange
        string s = "abba";
        int expectedResult = 2;
        
        // Act
        int result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        
        // Assert
        result.Should().Be(expectedResult);
    }
}