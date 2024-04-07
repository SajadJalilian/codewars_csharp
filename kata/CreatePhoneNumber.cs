namespace kata;

// https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp

public static class CreatePhoneNumber
{
    public static string Run(int[] numbers)
    {
        return $"({string.Join("", numbers[0..3])}) {string.Join("", numbers[3..6])}-{string.Join("", numbers[6..])}";
    }
}
