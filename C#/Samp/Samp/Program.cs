using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int totel;

            Console.WriteLine("Enter Frist Value:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Value:");
            num2 = Convert.ToInt32(Console.ReadLine());

            totel = num1 + num2;
            Console.WriteLine("Totel Is:" + totel);
            Console.ReadKey();
        }
    }
}
