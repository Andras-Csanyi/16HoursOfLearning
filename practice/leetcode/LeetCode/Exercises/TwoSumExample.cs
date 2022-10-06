namespace Exercises;

/// <summary>
/// https://leetcode.com/problems/two-sum/
/// </summary>
public class TwoSumExample
{
    public static int[]? TwoSum_BruteForce(int[] nums, int target)
    {
        if (!nums.Any())
        {
            return null;
        }

        for (int firstPointer = 0; firstPointer < nums.Length; firstPointer++)
        {
            for (int secondPointer = 1; secondPointer < nums.Length; secondPointer++)
            {
                if (nums[firstPointer] + nums[secondPointer] == target)
                {
                    return new int[] { firstPointer, secondPointer };
                }
            }
        }

        return null;
    }

    public static int[]? TwoSum_OnePassHashMap(int[] nums, int target)
    {
        if (!nums.Any())
        {
            return null;
        }

        Dictionary<int, int> numbers = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numbers.ContainsKey(complement) && numbers[complement] != i)
            {
                return new int[] { numbers[complement], i };
            }
            
            numbers[nums[i]] =  i;
        }

        return null;
    }
}