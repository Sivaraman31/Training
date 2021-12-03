using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, y, i = 1;
            Console.Write("Enter the Value Of Y :");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Value Of N :");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                y *= i;
                i++;
            }
            Console.WriteLine("Sum is :{0}", y);
        }
    }
}
