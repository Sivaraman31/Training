using System;

public class Reverse
{

    public static void Main(string[] args)
    {
        int n;
        string ans = "", s;

        s = Convert.ToString(Console.ReadLine());
        
        for (n = s.Length - 1; n >= 0; n--)
        {
            ans += s[n];
        }
        Console.WriteLine(ans);
    }
}