namespace kata;

// https://www.codewars.com/kata/52fba66badcd10859f00097e/train/csharp

public static class DisemvowelTrolls
{
    static char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    public static string Run(string str)
    {
        var result = new List<char>();
        foreach (var c in str)
        {
            if (IsVowel(c)) continue;
            result.Add(c);
        }
        return string.Join("", result);
    }

    private static bool IsVowel(char c)
    {

        foreach (var v in vowels)
        {
            if (c == v) return true;
        }

        return false;
    }
}
