using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact=1,nNum;

            Console.Write("Input the number : ");
            nNum = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i <= nNum; i++)
            {
                fact = fact * i;
            }
               
            Console.Write("The Factorial of {0} is: {1}\n", nNum, fact);
        }
    }
}
