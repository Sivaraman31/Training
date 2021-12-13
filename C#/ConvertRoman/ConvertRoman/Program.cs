using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertRoman
{
    class Program
    {
       
    public static void Decimal2Roman(int nDigit)
    {
            int nNum1, nNumber1, nNumber2, nNumber = nDigit;
            
            nNum1 = nNumber % 10;
            nNumber1 = nNumber / 10;
            int nNum10;
            nNum10 = nNumber1 % 10;
            nNumber2 = nNumber / 100;
            int nNum100;
            nNum100 = nNumber2 % 10;
            int nNum1000;
            nNum1000 = nNumber / 1000;

            switch (nNum1000)
            {
                case 1:
                    Console.Write("M");
                    break;
                case 2:
                    Console.Write("MM");
                    break;
                case 3:
                    Console.Write("MMM");
                    break;
                case 4:
                    Console.Write("MMMM");
                    break;

            }

            switch (nNum100)
            {
                case 1:
                    Console.Write("C");
                    break;
                case 2:
                    Console.Write("CC");
                    break;
                case 3:
                    Console.Write("CCC");
                    break;
                case 4:
                    Console.Write("CD");
                    break;
                case 5:
                    Console.Write("D");
                    break;
                case 6:
                    Console.Write("DC");
                    break;
                case 7:
                    Console.Write("DCC");
                    break;
                case 8:
                    Console.Write("DCCC");
                    break;
                case 9:
                    Console.Write("CM");
                    break;
            }

            switch (nNum10)
            {
                case 1:
                    Console.Write("X");
                    break;
                case 2:
                    Console.Write("XX");
                    break;
                case 3:
                    Console.Write("XXX");
                    break;
                case 4:
                    Console.Write("XL");
                    break;
                case 5:
                    Console.Write("L");
                    break;
                case 6:
                    Console.Write("LX");
                    break;
                case 7:
                    Console.Write("LXX");
                    break;
                case 8:
                    Console.Write("LXXX");
                    break;
                case 9:
                    Console.Write("XC");
                    break;
            }

            switch (nNum1)
            {
                case 1:
                    Console.Write("I");
                    break;
                case 2:
                    Console.Write("II");
                    break;
                case 3:
                    Console.Write("III");
                    break;
                case 4:
                    Console.Write("IV");
                    break;
                case 5:
                    Console.Write("V");
                    break;
                case 6:
                    Console.Write("VI");
                    break;
                case 7:
                    Console.Write("VII");
                    break;
                case 8:
                    Console.Write("VIII");
                    break;
                case 9:
                    Console.Write("IX");
                    break;
            }
        }
        static void Main(string[] args)
        {
            int nDig;
            Console.Write("\n\n Enter The Number: ");
            if(int.TryParse(Console.ReadLine(), out nDig))
            {
                if (nDig > 0 && nDig < 5000)
                {
                    Decimal2Roman(nDig);
                }
                else
                {
                    Console.WriteLine("Invalid or Out Of Range..(: ");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input...");
            }
            
            Console.Write("\n");
        }
    }
}
