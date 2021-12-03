using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, j;
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];
            int[,] d = new int[3, 3];
            Console.WriteLine("Reverse Order Numbers :\n");

            Console.WriteLine("Enter The Number Of Elements :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number Of Elements in the array a:\n", n);
            for (i = 0; i < n; i++)
            {
                for(j=0; j<n; j++)
                {
                    Console.Write("element s- [{0},{1}]", i, j);
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Enter The Number Of Elements in the array b:\n", n);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("elements- [{0},{1}]", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] * b[i, j];
                    d[i, j] = a[i, j] + b[i, j];

                }
            }             
            for (i = 0; i < n; i++)
            {
                Console.Write("\n \n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t ", c[i, j]);
                }
            }

            Console.WriteLine("\n \n Array Adding");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n \n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t ", d[i, j]);
                }
            }

        }
    }
}
