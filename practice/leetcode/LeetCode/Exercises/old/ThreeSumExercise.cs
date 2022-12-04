namespace Exercises.old;

public class ThreeSumExercise
{
    public static IList<IList<int>> Compute(int[] nums)
    {
        List<int> sortedNums = nums.ToList();
        sortedNums.Sort();
        IList<IList<int>> result = new List<IList<int>>();
        Dictionary<IList<int>, IList<int>> checkHashMap = new Dictionary<IList<int>, IList<int>>();
        UniqeShit comparer = new UniqeShit();

        for (int mainPointer = 0; mainPointer < nums.Length - 1; mainPointer++)
        {
            int leftPointer = mainPointer + 1;
            int rightPointer = nums.Length - 1;
            while (leftPointer < rightPointer)
            {
                int mainPointerValue = sortedNums[mainPointer];
                int leftValue = sortedNums[leftPointer];
                int rightValue = sortedNums[rightPointer];

                if (leftValue + rightValue + mainPointerValue == 0)
                {
                    if (leftPointer != rightPointer &&
                        leftPointer != mainPointer &&
                        mainPointer != rightPointer)
                    {
                        List<int> tmpResult = new List<int>();
                        tmpResult.Add(mainPointerValue);
                        tmpResult.Add(leftValue);
                        tmpResult.Add(rightValue);
                        if (!result.Contains(tmpResult, comparer))
                        {
                            result.Add(tmpResult);
                        }
                    }
                }

                if (leftValue + rightValue < Math.Abs(mainPointerValue))
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

    public class UniqeShit : IEqualityComparer<IList<int>>
    {
        public bool Equals(IList<int> x, IList<int> y)
        {
            if (x.SequenceEqual(y))
            {
                return true;
            }

            return false;
        }

        public int GetHashCode(IList<int> obj)
        {
            throw new NotImplementedException();
        }
    }
}