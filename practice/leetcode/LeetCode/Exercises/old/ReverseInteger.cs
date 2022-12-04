namespace Exercises.old;

using System.Globalization;
using System.Text;

/// <summary>
///     https://leetcode.com/problems/reverse-integer/
/// </summary>
public class ReverseInteger
{
    public static int Reverse(int number)
    {
        bool isNegative = false;
        if (number < 0)
        {
            isNegative = true;
            number = number * -1;
        }

        char[] numbersList = number.ToString().ToCharArray();
        StringBuilder reversedNumbers = new StringBuilder();

        bool isLastZero = false;
        for (int i = numbersList.Length - 1; i >= 0; i--)
        {
            char ch = numbersList[i];

            if (i == numbersList.Length - 1)
            {
                if (numbersList[^1] == "0".ToCharArray()[0])
                {
                    isLastZero = true;
                }
            }

            if (numbersList[i] == "0".ToCharArray()[0])
            {
                if (!isLastZero)
                {
                    reversedNumbers.Append(numbersList[i]);
                }
            }
            else
            {
                reversedNumbers.Append(numbersList[i]);
                isLastZero = false;
            }
        }

        string reversedNumbersString = reversedNumbers.ToString();
        int result = 0;
        if (Int32.TryParse(reversedNumbersString, NumberStyles.Integer, null, out result))
        {
            if (isNegative)
            {
                return result * -1;
            }

            return result;
        }

        return 0;
    }
}