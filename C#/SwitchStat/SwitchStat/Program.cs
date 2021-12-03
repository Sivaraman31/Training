using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Grade :");
            char grade =  Convert.ToChar(Console.ReadLine());
            
            switch (grade)

            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Superub..!");
                    break;
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better Luck Next Time..!");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
        }
    }
}