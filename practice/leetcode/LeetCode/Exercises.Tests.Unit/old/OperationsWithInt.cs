namespace Exercises.Tests.Unit.old;

using FluentAssertions;
using Xunit;

public class OperationsWithInt
{
    [Fact]
    public void DivideInteger()
    {
        int number = 1;
        int divider = 2;
        int result = number / divider;
        result.Should().Be(0).And.NotBe(1);
    }
    
    [Fact]
    public void DivideDecimal()
    {
        decimal number = 1m;
        decimal divider = 2m;
        decimal result = number / divider;
        result.Should().Be(0.5m);
    }

    [Fact]
    public void AdditionOfDecimalAndInteger()
    {
        decimal first = 1m;
        int second = 2;
        decimal result = first + second;
        result.Should().Be(3);
    }
    
    [Fact]
    public void AdditionOfDecimalAndInteger2()
    {
        decimal first = 1.5m;
        int second = 2;
        decimal result = first + second;
        result.Should().Be(3.5m);
    }
}