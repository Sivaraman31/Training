using System;

public class Reverse
{

    public static void Main(string[] args)
    {
        int n;
        string ans = "", s = "ramana";
        for (n = 6 - 1; n >= 0; n--)
        {
            ans += s[n];
        }
        Console.WriteLine(ans);
    }
}