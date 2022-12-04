namespace Exercises.old;

using System.Text;

public class PermutationUnique
{
    private List<IList<int>> permutations = new List<IList<int>>();
    private HashSet<string> set = new HashSet<string>();

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Permutate(nums, 0);
        return permutations;
    }

    public void Permutate(int[] nums, int actualPosition)
    {
        if (actualPosition == nums.Length)
        {
            StringBuilder builder = new StringBuilder();
            foreach (int num in nums)
            {
                builder.Append(num);
            }

            if (set.Add(builder.ToString()))
            {
                permutations.Add(nums.ToList());
            }

            return;
        }

        for (int i = actualPosition; i < nums.Length; i++)
        {
            Swap(nums, actualPosition, i);
            Permutate(nums, actualPosition + 1);
            Swap(nums, i, actualPosition);
        }
    }

    public void Swap(int[] nums, int j, int k)
    {
        int bag = nums[j];
        nums[j] = nums[k];
        nums[k] = bag;
    }
}