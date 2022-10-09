namespace Exercises;

public class LongestPalindrome
{
    public static string FindPalindrome(string s)
    {
        string result = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            decimal len1 = Find(s, i, i);
            decimal len2 = Find(s, i, i + 1);
            decimal higherLength = Math.Max(len1, len2);

            if (higherLength > result.Length)
            {
                decimal leftCrop = 0;
                if (i - (higherLength / 2 - 1) >= 0)
                {
                    leftCrop = i - (higherLength / 2 - 1);
                }

                decimal rightCrop = higherLength;

                int leftCropInteger = Decimal.ToInt32(leftCrop);
                int rightCropInteger = Decimal.ToInt32(rightCrop);
                string tempResult = s.Substring(leftCropInteger, rightCropInteger);
                result = tempResult;
            }
        }

        return result;
    }

    public static decimal Find(string s, decimal left, decimal right)
    {
        // int leftInternal = left;
        // int rightInternal = right;
        while (left >= 0
               && right < s.Length
               && s[Decimal.ToInt32(left)] == s[Decimal.ToInt32(right)])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}