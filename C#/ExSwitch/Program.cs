using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Grade :");
            char grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    {
                        Console.WriteLine("Excellent..!");
                        break;
                    }
                case 'B':
                case 'C':
                    {
                        Console.WriteLine("Well Done...");
                        break;
                    }
                case 'D':
                    {
                        Console.WriteLine("You Pass");
                        break;
                    }
                case 'F':
                    Console.WriteLine("Please Prepare Next Exam");
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Grade");
                        break;
                    }
            }
            Console.WriteLine("Your grade is  {0}", grade);
            Console.WriteLine("\n");
           
        }
    }
}
