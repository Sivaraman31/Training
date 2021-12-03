using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExIfelse
{
    class Program
    {
        static void Main(string[] args)
        {
            // If else
            /* 
            
            Console.WriteLine("Enter A Number :");
            int num = Convert.ToInt32(Console.ReadLine());

            
              if (num % 2 == 0)
              {
                  Console.WriteLine("It Is Even Number");
              }
              else
              {
                  Console.WriteLine("It Is Odd Number");
              }  */

            //If else-if 

            Console.WriteLine("Enter Your Mark :");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("Wrong Number");
            }
            else if (num >= 0 && num < 40)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 40 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }

        }
    }
}
