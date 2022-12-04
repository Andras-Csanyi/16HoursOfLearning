namespace Exercises.old;

public class LetterCombinationsOfAPhoneNumber
{
    private Dictionary<string, string> letters = new Dictionary<string, string>
    {
        { "2", "abc" },
        { "3", "def" },
        { "4", "ghi" },
        { "5", "jkl" },
        { "6", "mno" },
        { "7", "pqrs" },
        { "8", "tuv" },
        { "9", "wxyz" },
    };

    private List<string> result = new List<string>();

    public IList<string> LetterCombinations(string digits)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            string lettersOfDigits = letters[digits[i].ToString()];
            CreateCombinations(lettersOfDigits);
        }

        return result;
    }

    private void CreateCombinations(string lettersOfDigits)
    {
        List<string> toBeAdded = new List<string>();
        if (!result.Any())
        {
            foreach (char t in lettersOfDigits)
            {
                toBeAdded.Add(t.ToString());
            }
        }
        else
        {
            foreach (string existingResult in result)
            {
                foreach (char lettersOfDigit in lettersOfDigits)
                {
                    toBeAdded.Add($"{existingResult}{lettersOfDigit}");
                }
            }
        }

        result = toBeAdded;
    }
}