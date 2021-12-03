using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPara
{
    public class Employee
    {
        int nid, age;
        string strName;
        public Employee(int id, string name, int age)
        {
            this.nid = id;
            this.age = age;
            this.strName = name;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id is : " + nid);
            Console.WriteLine("Employee Name is : " + strName);
            Console.WriteLine("Employee Age is : " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(101,"Sam",25);
            Emp.Display();
        }
    }
}
