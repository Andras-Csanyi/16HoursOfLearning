namespace Exercises.old;

public class FourSumExercise
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        int pointerLeft = 0;
        int pointerRight = 0;
        int movingPointerLeft = 0;
        int movingPointerRight = nums.Length - 1;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            pointerLeft = i;
            pointerRight = i + 1;
            movingPointerLeft = pointerRight + 1;
            
            int pointerLeftValue = nums[pointerLeft];
            int pointerRightValue = nums[pointerRight];
            int movingPointerLeftValue = nums[movingPointerLeft];
            int movingPointerRightValue = nums[movingPointerRight];
            
            int threeSumDiff = target - (pointerLeftValue + pointerRightValue + movingPointerLeftValue);
            int allPointerSum = pointerLeftValue + pointerRightValue + movingPointerLeftValue + movingPointerRightValue;
            if (threeSumDiff != 0 || allPointerSum != target)
            {
                while (movingPointerLeft < movingPointerRight)
                {
                    movingPointerLeftValue = nums[movingPointerLeft];
                    movingPointerRightValue = nums[movingPointerRight];
                    
                    int res = movingPointerLeftValue + movingPointerRightValue;
                    if (res == threeSumDiff)
                    {
                        IList<int> singleResult = new List<int>
                        {
                            nums[pointerLeft],
                            nums[pointerRight],
                            nums[movingPointerLeft],
                            nums[movingPointerRight]
                        };
                        if (!result.Contains(singleResult))
                        {
                            result.Add(singleResult);
                        }
                    }

                    if (res < threeSumDiff)
                    {
                        movingPointerLeft++;
                    }
                    else
                    {
                        movingPointerRight--;
                    }
                }
            }
        }

        return result;
    }
}