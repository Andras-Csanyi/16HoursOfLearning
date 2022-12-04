namespace Exercises.Tests.Unit.old;

using Exercises.old;
using FluentAssertions;
using Xunit;

public class TrappingRainWater_Should
{
    private TrappingRainWater _trappingRainWater;

    public TrappingRainWater_Should()
    {
        _trappingRainWater = new TrappingRainWater();
    }

    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        int expectedOuput = 6;
        
        // Act
        int result = _trappingRainWater.Trap(input);
        
        // Assert
        result.Should().Be(expectedOuput);
    }
}