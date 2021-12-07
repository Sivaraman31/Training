using System;

namespace OverloadingPoly
{
    class Program
    {
        public void add(float x,float y)
        {
            Console.WriteLine(x + y);
        }
        public void add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.add(21.3f, 90);
            obj.add(12, 44, 23);
        }
    }
}
