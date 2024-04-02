namespace kata;
using System.Collections.Generic;

// https://www.codewars.com/kata/5259b20d6021e9e14c0010d4/train/csharp

public static class ReverseWords
{
    public static string Run(string str)
    {
        var sp = str.Split(" ");
        var rvl = new List<string>();

        foreach (var word in sp)
        {
            var rv = new List<char>();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                rv.Add(word[i]);
            }
            rvl.Add(string.Join("", rv));
        }

        return string.Join(" ", rvl);
    }
}
