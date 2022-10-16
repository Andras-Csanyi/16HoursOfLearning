namespace Exercises;

/// <summary>
///     https://leetcode.com/problems/3sum-closest
/// </summary>
public class ThreeSumClosest
{
    public static int Compute(int[] nums, int target)
    {
        List<int> sorted = nums.ToList();
        sorted.Sort();
        
        int result = 0;
        int distanceFromTarget = Int32.MaxValue;
        
        for (int mainPointer = 0; mainPointer < sorted.Count - 2; mainPointer++)
        {
            int leftPointer = mainPointer + 1;
            int rightPointer = sorted.Count - 1;

            while (leftPointer < rightPointer)
            {
                int mainPointerValue = sorted[mainPointer];
                int leftPointerValue = sorted[leftPointer];
                int rightPointerValue = sorted[rightPointer];

                int sum = sorted[mainPointer] + sorted[leftPointer] + sorted[rightPointer];
                int singleDistanceFromTarget = Math.Abs(target - sum);
                if (singleDistanceFromTarget < distanceFromTarget)
                {
                    distanceFromTarget = singleDistanceFromTarget;
                    result = sum;
                }

                if (sum < target)
                {
                    leftPointer++;
                }
                else
                {
                    rightPointer--;
                }
            }
        }

        return result;
    }
}