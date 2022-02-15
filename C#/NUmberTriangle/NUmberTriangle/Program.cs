using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input A Number :");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width :");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            int row, col;
            for (row = 0; row < height; row++)
            {
                for (col = 0; col < width; col++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                width--;
            }
        }
    }
}
