using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmaxArray
{
    class Program
    {
        class element

        {
            public int min;
            public int max;
        }
        static element getMinMax(int []arr, int n)
        {
            element minmax = new element();
            int i;
            if (n==1){
                minmax.max = arr[0];
                minmax.min = arr[0];
                return minmax;
            }
            if (arr[0] > arr[1])
            {
                minmax.max = arr[0];
                minmax.min = arr[1];
            }
            else
            {
                minmax.max = arr[1];
                minmax.min = arr[0];
            }
            for (i = 2; i < n; i++)
            {
                if (arr[i] > minmax.max)
                {
                    minmax.max = arr[i];
                }
                else if (arr[i] < minmax.min)
                {
                    minmax.min = arr[i];
                }
            }
            return minmax;
        }
        static void Main(string[] args)
        {
            int[] arr = { 100, 2, 234, 563, 388 };
            int arr_size = 5;
            element minmax = getMinMax(arr, arr_size);
            Console.WriteLine("minimum element {0}", minmax.min);
            Console.WriteLine("maximum element {0}", minmax.max);
        }
    }
}
