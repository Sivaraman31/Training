using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Even = new int[4];
            Even[0] = 0;
            Even[1] = 2;
            Even[2] = 4;
            Even[3] = 6;

            int[] Odd = { 1, 3, 5, 7 };

            Console.WriteLine("Print Even Numbers :");
            for (int i = 0; i < Even.Length; i++)
            {
                Console.WriteLine(Even[i]);
            }

            Console.WriteLine("Print Odd Numbers :");
            for (int i = 0; i < Odd.Length; i++)
            {
                Console.WriteLine(Odd[i]);
            }
        }
    }
}
