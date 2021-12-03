using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Printarray(int[] arr)
        {
            Console.WriteLine("\n Elements Of Array Is :\n");
            foreach(int i in arr)
            {
                Console.Write("\t {0}", i);
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 2, 6, 9, 3, 5 };
            int[] arr2 = new int[5];
            int len, rank;
            bool fixedsize,read_only;
            
            len = arr1.Length;
            Console.WriteLine("Length is:\t{0}", len);

            rank = arr1.Rank;
            Console.WriteLine("Rank is:\t{0}", rank);

            fixedsize = arr1.IsFixedSize;
            Console.WriteLine("Fixed Size Is:\t{0}", fixedsize);

            read_only = arr1.IsReadOnly;
            Console.WriteLine("Read Only:\t", read_only);

            Array.Sort(arr1);
            Printarray(arr1);

            Console.WriteLine("Get Length:\t{0}", arr1.GetLength(0));
            Console.WriteLine("Get Value:\t{0}", arr1.GetValue(2));
            Console.WriteLine("Get Index:\t{0}", Array.IndexOf(arr1, 33));

            Array.Copy(arr1, arr2, 5);
            Printarray(arr2);
            Array.Clear(arr1, 0, 5);
            Printarray(arr1);

            Console.ReadLine();

        }
    }
}
