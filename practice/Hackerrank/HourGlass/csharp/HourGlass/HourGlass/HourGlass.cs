namespace HourGlass
{
    using System.Collections.Generic;
    using System.Linq;

    public class HourGlass
    {
        private readonly int[,] hourGlass;

        private List<int[]> hourGlassPattern = new List<int[]>()
        {
            new[] { 0, 0 },
            new[] { 0, 1 },
            new[] { 0, 2 },
            new[] { 1, 1 },
            new[] { 2, 0 },
            new[] { 2, 1 },
            new[] { 2, 2 },
        };

        private int maxHorizontal = 3;
        private int[] startingLines = { 0, 3 };

        public HourGlass(int[,] hourGlassArray)
        {
            hourGlass = hourGlassArray;
        }

        public int Count()
        {
            int hourGlassMax = 0;
            for (int startLineIndex = 0; startLineIndex < startingLines.Length; startLineIndex++)
            {
                int startLine = startingLines[startLineIndex];
                for (int horizontalIndex = 0; horizontalIndex < maxHorizontal; horizontalIndex++)
                {
                    int hourGlassSum = 0;
                    for (int patternIndex = 0; patternIndex < hourGlassPattern.Count; patternIndex++)
                    {
                        int[] singlePattern = hourGlassPattern.ElementAt(patternIndex);
                        int vIndex = horizontalIndex + singlePattern[0];
                        int hIndex = startLine + singlePattern[1];
                        int value = hourGlass[vIndex, hIndex];
                        hourGlassSum += value;
                    }

                    if (hourGlassMax > hourGlassSum)
                    {
                        hourGlassMax = hourGlassSum;
                    }
                }
            }

            return hourGlassMax;
        }
    }
}