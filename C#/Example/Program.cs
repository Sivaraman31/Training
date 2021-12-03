using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n, i, m = 0;
            Console.WriteLine("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for(i = 2; i <= m; i++)
            {
                if(m % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    m = 1;
                    break;
                }
            }

            if (m == 0) Console.WriteLine("Number is Prime.");
        }
    }
}
