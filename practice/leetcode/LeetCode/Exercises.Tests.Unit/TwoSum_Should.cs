namespace Exercises.Tests.Unit;

using FluentAssertions;
using Xunit;

public class TwoSum_Should
{
    [Fact]
    public void Example1_Test()
    {
        // Arrange
        int[] nums = new[] { 2, 7, 11, 15 };
        int target = 9;
        int[] expectedResult = new[] { 0, 1 };

        // Act && Assert
        TwoSumExample.TwoSum_BruteForce(nums, target).Should().NotBeNull()
            .And.Equal(expectedResult);
    }
    
    [Fact]
    public void Example2_Test()
    {
        // Arrange
        int[] nums = new[] { 3, 2, 4 };
        int target = 6;
        int[] expectedResult = new[] { 1, 2 };

        // Act && Assert
        TwoSumExample.TwoSum_BruteForce(nums, target).Should().NotBeNull()
            .And.Equal(expectedResult);
    }
    
    [Fact]
    public void Example3_Test()
    {
        // Arrange
        int[] nums = new[] { 3, 3 };
        int target = 6;
        int[] expectedResult = new[] { 0, 1 };

        // Act && Assert
        TwoSumExample.TwoSum_BruteForce(nums, target).Should().NotBeNull()
            .And.Equal(expectedResult);
    }
    
    // One pass hashmap
    
    [Fact]
    public void OnePassHashmap_Example1_Test()
    {
        // Arrange
        int[] nums = new[] { 2, 7, 11, 15 };
        int target = 9;
        int[] expectedResult = new[] { 0, 1 };

        // Act && Assert
        TwoSumExample.TwoSum_OnePassHashMap(nums, target).Should().NotBeNull()
            .And.Equal(expectedResult);
    }
    
    [Fact]
    public void OnePassHashmap_Example2_Test()
    {
        // Arrange
        int[] nums = new[] { 3, 2, 4 };
        int target = 6;
        int[] expectedResult = new[] { 1, 2 };

        // Act && Assert
        TwoSumExample.TwoSum_OnePassHashMap(nums, target).Should().NotBeNull()
            .And.Equal(expectedResult);
    }
    
    [Fact]
    public void OnePassHashmap_Example3_Test()
    {
        // Arrange
        int[] nums = new[] { 3, 3 };
        int target = 6;
        int[] expectedResult = new[] { 0, 1 };

        // Act && Assert
        TwoSumExample.TwoSum_OnePassHashMap(nums, target).Should().NotBeNull()
            .And.Equal(expectedResult);
    }
    
    [Fact]
    public void OnePassHashmap_DuplicatedValues_Test()
    {
        // Arrange
        int[] nums = new[] { 1, 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 3, 7 };
        int target = 11;
        int[] expectedResult = new[] { 6, 12 };

        // Act && Assert
        TwoSumExample.TwoSum_OnePassHashMap(nums, target).Should().NotBeNull()
            .And.Equal(expectedResult);
    }
}