namespace Exercises;

/// <summary>
///     https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
/// </summary>
public class TwoSumExercise2
{
    public static int[] Compute(int[] numbers, int target)
    {
        int[] result = new int[2];
        int leftPointer = 0;
        int rightPointer = numbers.Length - 1;
        while (leftPointer < rightPointer)
        {
            int sum = numbers[leftPointer] + numbers[rightPointer];

            if (sum == target)
            {
                result[0] = leftPointer + 1;
                result[1] = rightPointer + 1;
                return result;
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

        return Array.Empty<int>();
    }
}