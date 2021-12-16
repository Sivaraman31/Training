using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, m = 0, f = 0;
            Console.WriteLine("Enter The Number To Check Prime Or Not: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number Is Not Prime...");
                    f = 1;
                    break;
                }
            }
            if (f == 0)
            {
                Console.WriteLine("Number Is Prime..!");
            }
        }
    }
}
