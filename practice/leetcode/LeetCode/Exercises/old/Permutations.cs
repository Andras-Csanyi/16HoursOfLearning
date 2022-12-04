namespace Exercises.old;

public class Permutations
{
    private int[] numbers;
    private List<IList<int>> result = new List<IList<int>>();

    public IList<IList<int>> Permute(int[] nums)
    {
        numbers = nums;
        backtrack(0, numbers);

        return result;
    }

    public void backtrack(int actualPosition, int[] nums)
    {
        if (actualPosition == nums.Length)
        {
            result.Add(nums.ToList());
            return;
        }

        for (int i = actualPosition; i < nums.Length; i++)
        {
            // int[] tmpResult = numbers;
            Swap(nums, actualPosition, i);
            backtrack(actualPosition + 1, nums);
            Swap(nums, i, actualPosition);
        }
    }

    public void Swap(int[] numbers, int toBeReplacedIndex, int theReplaceItemIndex)
    {
        int bucket = numbers[toBeReplacedIndex];
        numbers[toBeReplacedIndex] = numbers[theReplaceItemIndex];
        numbers[theReplaceItemIndex] = bucket;
    }
}