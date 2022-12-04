namespace Exercises.old;

/// <summary>
/// https://leetcode.com/problems/longest-substring-without-repeating-characters/
/// </summary>
public class LongestSubstringWithoutRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        int leftPointer = 0;
        int rightPointer = 0;
        int maxWidthOfWindow = 0;
        char[] str = s.ToCharArray();
        Dictionary<int, int> positions = new Dictionary<int, int>();

        for (int i = 0; i < s.Length; i++, rightPointer++)
        {
            string ssss = s[rightPointer].ToString();
            if (!positions.TryAdd(str[rightPointer], rightPointer))
            {
                int occurence = positions[str[rightPointer]];
                if ((occurence + 1) > leftPointer)
                {
                    leftPointer = occurence + 1;
                }
                positions[str[rightPointer]] = rightPointer;
                if ((rightPointer - leftPointer + 1) > maxWidthOfWindow)
                {
                    maxWidthOfWindow = rightPointer - leftPointer + 1;
                }
            }
            else
            {
                if ((rightPointer - leftPointer + 1) > maxWidthOfWindow)
                {
                    maxWidthOfWindow = rightPointer - leftPointer + 1;
                }
            }
        }

        return maxWidthOfWindow;
    }
}