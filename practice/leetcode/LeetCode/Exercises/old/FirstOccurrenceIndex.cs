namespace Exercises.old;

public class FirstOccurrenceIndex
{
    public int StrStr(string haystack, string needle)
    {
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                for (int j = 0; j <= needle.Length - 1; j++)
                {
                    if (i + j < haystack.Length
                        && haystack[i + j] == needle[j])
                    {
                        if (j == needle.Length - 1)
                        {
                            return i;
                        }
                    }
                    else
                    {
                        // i = +j - 1;
                        break;
                    }
                }
            }
        }

        return -1;
    }
}