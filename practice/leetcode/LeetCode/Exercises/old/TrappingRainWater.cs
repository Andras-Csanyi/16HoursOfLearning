namespace Exercises.old;

public class TrappingRainWater
{
    public int Trap(int[] height)
    {
        Dictionary<int, int> partialResults = new Dictionary<int, int>();

        if (!height.Any())
        {
            return 0;
        }

        // from left to right
        // two pointers:
        // - highestElemenet
        //  - trackingPointer
        // check every element
        //  if actual is higher then previous move the highestElement pointer
        //  if actual is higher or equal to highestElement then
        //      calculate trapped water between actual and highestElement
        //          collect the results in a hashmap by every position - partial results
        //      move highestElement to actual
        // sum partials as a result

        int highestElementIndex = 0;

        for (int trackingIndex = 0; trackingIndex < height.Length - 1; trackingIndex++)
        {
            int trackingIndexHeightValue = height[trackingIndex];
            int highestElementIndexHeightValue = height[highestElementIndex];
            
            if (trackingIndexHeightValue >= highestElementIndexHeightValue)
            {
                if (trackingIndex - highestElementIndex > 1)
                {
                    for (int i = highestElementIndex + 1; i <= trackingIndex - 1; i++)
                    {
                        int lowest = Math.Min(height[trackingIndex], height[highestElementIndex]);
                        if (lowest != 0 && lowest < height[i])
                        {
                            throw new Exception();
                        }

                        partialResults[i] = lowest - height[i];
                    }

                    highestElementIndex = trackingIndex;
                    continue;
                }
            }

            if (trackingIndex > 0)
            {
                if (trackingIndexHeightValue > height[trackingIndex - 1] &&
                    trackingIndexHeightValue > highestElementIndexHeightValue)
                {
                    highestElementIndex = trackingIndex;
                }
            }
        }

        int sum = partialResults.Values.ToList().Sum();
        return sum;
    }
}