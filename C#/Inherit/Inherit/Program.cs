using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Branch
    {
        int B_Code;
        string B_Name, B_Address;
        public void GetBranch()
        {
            Console.Write("Enter The Branch Code :\t");
            B_Code = int.Parse(Console.ReadLine());

            Console.Write("Enter The Branch Name :\t");
            B_Name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter The Branch Address :\t");
            B_Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");
        }
        public void DisplayBranch()
        {
            Console.WriteLine("Branch Code Is : " + B_Code);
            Console.WriteLine("Branch Name Is : " + B_Name);
            Console.WriteLine("Branch Address Is : " + B_Address+"\n");
        }
    }
    class Employee : Branch
    {
        int Emp_id, Emp_Age;
        string Emp_Name, Emp_Address;
        public void GetEmployee()
        {
            Console.Write("Enter Employee Id :\t");
            Emp_id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name :\t");
            Emp_Name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Employee Adress :\t");
            Emp_Address = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Employee Age :\t");
            Emp_Age = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Id Is :" + Emp_id);
            Console.WriteLine("Employee Name Is :" + Emp_Name);
            Console.WriteLine("Employee Address Is :" + Emp_Address);
            Console.WriteLine("Employee Age Is :" + Emp_Age+"\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();

            Console.WriteLine("\n -----------Branch Details---------- \n");
            Emp.GetBranch();
            Emp.DisplayBranch();

            Console.WriteLine("\n ----------Employee Details--------- \n");
            Emp.GetEmployee();
            Emp.DisplayEmployee();
        }
    }
}
