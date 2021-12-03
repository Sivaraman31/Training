using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Rectangle
    {
        public double length, Width;

        public double GetArea()
        {
           return length * Width;
        }
        public void Display()
        {
            Console.WriteLine("Length :{0}", length);
            Console.WriteLine("Width :{0}", Width);
            Console.WriteLine("Area : {0}", GetArea());
        }
    }
    class AccessSpecifierPublic
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.Write("Enter The Length Of Rectangle : ");
            rect.length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Width Of Rectangle : ");
            rect.Width = Convert.ToDouble(Console.ReadLine());
            rect.Display();
            Console.ReadLine();
        }
    }
}
