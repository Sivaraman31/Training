using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStudent
{
    class Program
    {
        public class Student
        {
            public int nStudentId { get; set; }
            public string strStudentName { get; set; }
            public int nAge { get; set; }
        }
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){nStudentId=01,strStudentName="Jai",nAge=22},
                new Student(){nStudentId=02,strStudentName="Anbu",nAge=15},
                new Student(){nStudentId=03,strStudentName="Mani",nAge=16},
                new Student(){nStudentId=04,strStudentName="Ram",nAge=20},
                new Student(){nStudentId=05,strStudentName="Aji",nAge=14}
            };
            var teenAger = from stud in studentList where stud.nAge > 12 && stud.nAge < 20 select stud;
            Console.WriteLine("Teen Age Students: ");

            foreach(Student stud in teenAger)
            {
                Console.WriteLine(stud.strStudentName);
            }
        }
    }
}
