using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseArray
{
    public class ArrayReverser
    {
        /// <summary>
        /// Reverses list.
        /// In the background it uses Array.Reverse()
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public List<int> Reverse(List<int> inputArray)
        {
            inputArray.Reverse();
            return inputArray;
        }
    }
}