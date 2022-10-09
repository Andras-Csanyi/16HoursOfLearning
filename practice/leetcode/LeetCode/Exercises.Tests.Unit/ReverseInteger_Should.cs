namespace Exercises.Tests.Unit;

using FluentAssertions;
using Xunit;

public class ReverseInteger_Should
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int input = 123;
        int expected = 321;
        
        // Act
        int result = ReverseInteger.Reverse(input);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example2()
    {
        // Arrange
        int input = -123;
        int expected = -321;
        
        // Act
        int result = ReverseInteger.Reverse(input);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example3()
    {
        // Arrange
        int input = 120;
        int expected = 21;
        
        // Act
        int result = ReverseInteger.Reverse(input);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example4()
    {
        // Arrange
        int input = 10;
        int expected = 1;
        
        // Act
        int result = ReverseInteger.Reverse(input);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example5()
    {
        // Arrange
        int input = 100000000;
        int expected = 1;
        
        // Act
        int result = ReverseInteger.Reverse(input);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Example6()
    {
        // Arrange
        int input = 120300600;
        int expected = 6003021;
        
        // Act
        int result = ReverseInteger.Reverse(input);
        
        // Assert
        result.Should().Be(expected);
    }
}