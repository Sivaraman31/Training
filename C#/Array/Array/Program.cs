using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Print(int[] x)
        {
            int i;
          
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}   ", x[i]);

            }
           
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i;

            for(i=0; i<5; i++)
            {
                Console.Write("Elements- {0} ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(a);
            Print(a);

            
        }
    }
}
