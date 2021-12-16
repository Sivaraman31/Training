using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, sum = 0;
            Console.WriteLine("Enter a Number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
