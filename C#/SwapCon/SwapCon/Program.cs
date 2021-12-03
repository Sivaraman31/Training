using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class functionexcercise
{
    public static int interchangenumber( int num1,  int num2)
    {
        int newnum;

        newnum = num1;
        num1 = num2;
        num2 = newnum;
        Console.WriteLine("Inside the swapping  Function the 1st number is : {0} , and the 2nd number is : {1}", num1, num2);
        return num1;

    }
    public static void Main()
    {
        int n1, n2;
        Console.Write("Enter two number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Value before Swap n1 =" + n1 + " n2= " + n2);
        int n3= interchangenumber( n1, n2);
        Console.WriteLine("After swapping the 1st number is : {0} , and the 2nd number is : {1}", n1,n2);
        Console.WriteLine(n3);

        Console.ReadLine();
    }
}