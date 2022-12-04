namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class LongestPalindrome_Should
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "babad";
        string expected = "bab";
        
        // Act
        string result = LongestPalindrome.FindPalindrome(s);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "cbbd";
        string expected = "bb";
        
        // Act
        string result = LongestPalindrome.FindPalindrome(s);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "v";
        string expected = "v";
        
        // Act
        string result = LongestPalindrome.FindPalindrome(s);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example4()
    {
        // Arrange
        string s = string.Empty;
        string expected = String.Empty;
        
        // Act
        string result = LongestPalindrome.FindPalindrome(s);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example5()
    {
        // Arrange
        string s = "iosfjghsolqwertyuioppoiuytrewqzxcvbnmmnbvcxzksgdfosjfghosghosbfladnhfklsjbdbvksjbfgflosjnd";
        string expected = "qwertyuioppoiuytrewq";
        
        // Act
        string result = LongestPalindrome.FindPalindrome(s);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example6()
    {
        // Arrange
        string s = "iosfjghsolqwertyuiopoiuytrewqqldkrndkghefsdarewvdfhfvgrbtugnmyonlkupjiyhjht vdfsfscwvdhfgsfcvd";
        string expected = "qwertyuiopoiuytrewq";
        
        // Act
        string result = LongestPalindrome.FindPalindrome(s);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example7()
    {
        // Arrange
        string s = "qwertyuiopasdfghjklzxcvbnmnbvcxzlkjhgfdsapoiuytrewq";
        string expected = "qwertyuiopasdfghjklzxcvbnmnbvcxzlkjhgfdsapoiuytrewq";
        
        // Act
        string result = LongestPalindrome.FindPalindrome(s);
        
        // Assert
        result.Should().Be(expected);
    }
}