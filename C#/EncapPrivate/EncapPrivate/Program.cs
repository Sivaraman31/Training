using System;

namespace EncapPrivate
{
    class Rectangle
    {
        private double length, width;

        public void Acceptdetails()
        {
            Console.Write("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
       class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Acceptdetails();
            rect.Display();
            Console.ReadLine();
        }
    }
}
