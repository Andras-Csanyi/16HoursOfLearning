namespace HourGlass.Tests.Unit
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class HourGlass_Should
    {
        public static IEnumerable<Object[]> Data => new List<Object[]>()
        {
            new object[]
            {
                new int[,]
                {
                    { -9, -9, -9, 1, 1, 1 },
                    { 0, -9, 0, 4, 3, 2 },
                    { -9, -9, -9, 1, 2, 3 },
                    { 0, 0, 8, 6, 6, 0 },
                    { 0, 0, 0, -2, 0, 0 },
                    { 0, 0, 1, 2, 4, 0 }
                },
                28
            }
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void ReturnWithTheHighestAmountFromHourGlasses(
            int[,] hourGlassInput,
            int expectedResult)
        {
            // Arrange
            HourGlass hourGlass = new HourGlass(hourGlassInput);
            
            // Act
            int result = hourGlass.Count();
            
            // Assert
            result.Should().Be(expectedResult);
        }
    }
}