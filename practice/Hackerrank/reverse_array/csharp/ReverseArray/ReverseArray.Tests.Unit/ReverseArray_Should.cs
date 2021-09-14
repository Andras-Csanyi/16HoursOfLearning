using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace ReverseArray.Tests.Unit
{
    public class ReverseArray_Should
    {
        private ArrayReverser _arrayReverser;

        public ReverseArray_Should()
        {
            _arrayReverser = new ArrayReverser();
        }

        [Fact]
        public void Reverse()
        {
            List<int> input = new List<int>
            {
                1, 2, 3
            };
            List<int> expectedResult = new List<int>
            {
                3, 2, 1
            };
            List<int> result = _arrayReverser.Reverse(input);

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}