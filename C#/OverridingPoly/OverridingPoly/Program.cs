using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingPoly
{
    public class Flower
    {
        public virtual void color()
        {
            Console.WriteLine("White Flower..!");
        }
    }
    public class Rose : Flower
    {
        public override void color()
        {
            Console.WriteLine("Beautiful Rose..!");
        }
    }
    public class Lotus : Flower
    {
        public override void color()
        {
            Console.WriteLine("White Lotus in Lake..!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower();
            Rose rose = new Rose();
            Lotus lotus = new Lotus();

            flower.color();
            rose.color();
            lotus.color();
        }
    }
}
