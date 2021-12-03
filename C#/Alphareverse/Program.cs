using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphareverse
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter character :");
            var ch = Console.ReadLine();

            var ans = string.Empty;
            int len = ch.Length;
            for (int i=0; i < len; i++)
            {
                ans += arr[25- Array.IndexOf(arr, ch[i])];
            }
            Console.WriteLine(ans);
        }
    }
}
