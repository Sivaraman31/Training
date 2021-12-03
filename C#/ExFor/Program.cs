using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.Write("Display the multiplication table:\n\n");
            
            Console.Write("Which Table You Want: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1}  = {2} ", n, i, n * i);
            }
        }
    }
}
