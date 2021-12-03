using System;

namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Firstname :\t");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter Your LastName :\t");
            string LastName = Console.ReadLine();

            Console.WriteLine("hai {0},{1}", FirstName, LastName);
        }
    }
}
