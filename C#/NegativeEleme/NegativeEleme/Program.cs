using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeEleme
{
    class Program
    {
        static void rearrange(int[]arr,int n)
        {
            int j = 0, temp;
            for(int i=0; i<n; i++)
            {
                if (arr[i] < 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
        }
        static void printArray(int[]arr,int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 8, -7, -8, 10, -2, 2, -5, 0, -1 };
            int n = arr.Length;
            rearrange(arr, n);
            printArray(arr, n);
        }
    }
}
