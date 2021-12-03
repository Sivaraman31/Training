using System;
using System.Collections.Generic;
using System.Text;

namespace Contact
{
    class Person
    {
        private string sF_Name;
        private string sL_Name;
        private int nNumber;

        public Person()
        {
           string sF_Name = Firstname;
            sL_Name = Lastname;
            nNumber = Number;
        }
      
        public void Show()
        {
            Console.WriteLine(sF_Name + " " + sL_Name + " " + nNumber);
        }
    }
}
