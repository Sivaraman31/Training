using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDefa
{
    public class Employee
    {
        int nId;
        string strName;
        public Employee()
        {
            this.nId = 101;
            this.strName = "Sam";
        }
        public void display()
        {
            Console.WriteLine("Employee Id is : " + nId);
            Console.WriteLine("Employee Name Is : " + strName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();
            Emp.display();
            Console.ReadKey();
        }
    }
}
