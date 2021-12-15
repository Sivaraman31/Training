using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveArray
{
    class Program
    {
        static void revArray(int[] arr,int S,int N)
        {
            int temp;
            while (S < N)
            {
                temp =arr[S];
                arr[S] = arr[N];
                arr[N] = temp;
                S++;
                N--;
            }
        }
        static void printArray(int[]arr,int size)
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+ "");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            printArray(arr, 9);
            revArray(arr, 0, 5);
            Console.WriteLine("Reverse Array is: ");
            printArray(arr, 9);
        }
    }
}
