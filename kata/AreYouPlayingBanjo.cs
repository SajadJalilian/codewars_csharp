namespace kata;

// https://www.codewars.com/kata/53af2b8861023f1d88000832/train/csharp

public static class AreYouPlayingBanjo
{

    public static string Run(string str)
    {
        char firstLetter = str[0];
        return firstLetter == 'r' || firstLetter == 'R'
            ? str + " plays banjo"
            : str + " does not play banjo";
    }
}
