using System;
using System.Collections.Generic;

public class Test
{
	public static void Main()
	{
		string s;
		s = Convert.ToString(Console.ReadLine());
		List<string> words = new List<string>();
		string word = "";

		foreach (var i in s)
		{
			if (i != '.')
			{
				word += i;
			}
			else
			{
				words.Add(ReverseString(word));
				word = "";
			}
		}

		words.Add(ReverseString(word));

		for (int i = 0; i < words.Count; i++)
		{
			if (i != (words.Count - 1))
			{
				Console.Write(words[i] + '.');
			}
			else
			{
				Console.Write(words[i]);
			}
		}
		Console.WriteLine("\n");
	}


	public static string ReverseString(string word)
	{
		string reversedWord = "";

		for (int i = word.Length - 1; i >= 0; i--)
		{
			reversedWord += word[i];
		}

		return reversedWord;
	}
}
